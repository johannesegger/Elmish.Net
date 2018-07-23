using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Elmish.Net;
using Elmish.Net.VDom;
using LanguageExt;
using MahApps.Metro.Controls;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Core;
using Wpf.Elmish.Net.Sample.Utils;
using static LanguageExt.Prelude;
using WpfMap = Microsoft.Maps.MapControl.WPF.Map;

namespace Wpf.Elmish.Net.Sample
{
    internal class Program
    {
        [STAThread]
        private static void Main()
        {
            var app = new Application();
            new[]
                {
                    "pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml",
                    "pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml",
                    "pack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml",
                    "pack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml",
                    "pack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml"
                }
                .Select(p => new ResourceDictionary { Source = new Uri(p) })
                .ForEach(app.Resources.MergedDictionaries.Add);
            WpfElmishApp.Run(app, Init(), Update, View);
        }

        private static (State, Cmd<Message>) Init()
        {
            var areas =
                ImmutableList<Area>
                    .Empty
                    .Add(Area.Create(new[] { DraggableCoordinate.Create(47.946812, 13.777095), DraggableCoordinate.Create(47.944375, 13.777380), DraggableCoordinate.Create(47.944338, 13.776286), DraggableCoordinate.Create(47.946508, 13.776049), DraggableCoordinate.Create(47.946485, 13.776685) }, "Enser"))
                    .Add(Area.Create(new[] { DraggableCoordinate.Create(47.946927, 13.777057), DraggableCoordinate.Create(47.947813, 13.776992), DraggableCoordinate.Create(47.948885, 13.780077), DraggableCoordinate.Create(47.948237, 13.780352) }, "Galler"));
            var initialState = State
                .Empty
                .With(p => p.Areas, areas)
                .With(p => p.MapZoomLevel, 15)
                .With(p => p.Center, GetCenter(areas));
            return (initialState, Cmd.None<Message>());
        }

        private static (State, Cmd<Message>) Update(Message message, State state)
        {
            return message.Match(
                (Message.SetTitleMessage m) =>
                {
                    var newState = state.With(p => p.Title, m.Title);
                    return (newState, Cmd.None<Message>());
                },
                (Message.BeginMoveLocationMessage m) =>
                {
                    var newState = state.With(p => p.Areas[m.AreaIndex].Coordinates[m.CoordinateIndex].IsDragging, true);
                    return (newState, Cmd.None<Message>());
                },
                (Message.MoveLocationMessage m) =>
                {
                    var newState = state.With(p => p.Areas[m.AreaIndex].Coordinates[m.CoordinateIndex].Coordinate, m.Coordinate);
                    return (newState, Cmd.None<Message>());
                },
                (Message.EndMoveLocationMessage m) =>
                {
                    var newState = state.With(p => p.Areas[m.AreaIndex].Coordinates[m.CoordinateIndex].IsDragging, false);
                    return (newState, Cmd.None<Message>());
                },
                (Message.InsertLocationMessage m) =>
                {
                    var newState = state.With(
                        p => p.Areas[m.AreaIndex].Coordinates,
                        state.Areas[m.AreaIndex].Coordinates.Insert(m.CoordinateIndex, new DraggableCoordinate(m.Coordinate, false))
                    );
                    return (newState, Cmd.None<Message>());
                },
                (Message.RemoveLocationMessage m) =>
                {
                    var newState = state.With(
                        p => p.Areas[m.AreaIndex].Coordinates,
                        state.Areas[m.AreaIndex].Coordinates.RemoveAt(m.CoordinateIndex)
                    );
                    return (newState, Cmd.None<Message>());
                },
                (Message.SelectAreaMessage m) =>
                {
                    Area Update(Area area, int index)
                    {
                        return area.With(p => p.IsSelected, index == m.AreaIndex);
                    }

                    var newState = state.With(p => p.Areas, state.Areas.Select(Update));
                    return (newState, Cmd.None<Message>());
                },
                (Message.UpdateAreaTitleMessage m) =>
                {
                    var newState = state.With(p => p.Areas[m.AreaIndex].Note, m.Title);
                    return (newState, Cmd.None<Message>());
                },
                (Message.AddAreaMessage m) =>
                {
                    var newArea = new Area(Enumerable.Empty<DraggableCoordinate>(), m.Title, isSelected: false, isDefined: false);
                    var newState = state.With(p => p.Areas, state.Areas.Add(newArea));
                    var newAreaIndex = newState.Areas.Count - 1;
                    var (newState1, cmd1) = Update(new Message.SelectAreaMessage(newAreaIndex), newState);
                    var (newState2, cmd2) = Update(new Message.BeginDefineAreaMessage(newAreaIndex), newState1);
                    return (newState2, Cmd.Batch(cmd1, cmd2));
                },
                (Message.BeginDefineAreaMessage m) =>
                {
                    Area Update(Area area, int index)
                    {
                        return area.With(p => p.IsDefined, index != m.AreaIndex);
                    }

                    var newState = state.With(p => p.Areas, state.Areas.Select(Update));
                    return (newState, Cmd.None<Message>());
                },
                (Message.EndDefineAreaMessage m) =>
                {
                    var newState = state.With(p => p.Areas[m.AreaIndex].IsDefined, true);
                    return (newState, Cmd.None<Message>());
                },
                (Message.ChangeMapViewMessage m) =>
                {
                    var newState = state
                        .With(p => p.MapZoomLevel, m.ZoomLevel)
                        .With(p => p.Center, m.Center);
                    return (newState, Cmd.None<Message>());
                });
        }

        private static IVDomNode<Window> View(State state, Dispatch<Message> dispatch)
        {
            const double tolerancePixels = 10;

            return WpfVDomNode.Create<MetroWindow>()
                .Set(p => p.Visibility, Visibility.Visible)
                .Set(p => p.Title, $"Wpf.Elmish.Net.Sample - {state.Title}")
                .Set(p => p.Width, 1024)
                .Set(p => p.Height, 768)
                .Set(
                    p => p.Content,
                    WpfVDomNode.Create<StackPanel>()
                        .SetChildNodes(
                            p => p.Children,
                            WpfVDomNode.Create<StackPanel>()
                                .Set(p => p.Orientation, Orientation.Horizontal)
                                .SetChildNodes(
                                    p => p.Children,
                                    WpfVDomNode.Create<TextBlock>()
                                        .Set(p => p.Text, "Map title: ")
                                        .Set(p => p.Margin, new Thickness(5, 0, 5, 0))
                                        .Set(p => p.VerticalAlignment, VerticalAlignment.Center),
                                    WpfVDomNode.Create<TextBox>()
                                        .Set(p => p.Text, state.Title)
                                        .Subscribe(p => p
                                            .TextChangedObservable()
                                            .Subscribe(e => dispatch(new Message.SetTitleMessage(p.Text)))
                                        )
                                ),
                            WpfVDomNode.Create<WpfMap>()
                                .Set(
                                    p => p.CredentialsProvider,
                                    new ApplicationIdCredentialsProvider("AiYVQeyKth-2j8dkcIPe58rz3zxNt6Hw-ydHJhZLfklNfZPrWM9HlBr6LTnIgy65"),
                                    EqualityComparer.Create((CredentialsProvider p) => 1))
                                .Set(p => p.Mode, WpfVDomNode.Create<AerialMode>())
                                .Set(p => p.Center, state.Center.ToLocation())
                                .Set(p => p.ZoomLevel, state.MapZoomLevel)
                                .Set(p => p.Height, 500)
                                .Set(p => p.Culture, "de-AT")
                                .SetChildNodes(
                                    p => p.Children,
                                    WpfVDomNode.Create<MapLayer>()
                                        .SetChildNodes(
                                            p => p.Children,
                                            state.Areas
                                                .SelectMany((area, i) => AreaView(i, area, dispatch))
                                        )
                                )
                                .Subscribe(map =>
                                {
                                    var d = new CompositeDisposable();

                                    if (!state.Areas.SelectMany(p => p.Coordinates).Any(p => p.IsDragging))
                                    {
                                        map
                                            .PreviewMouseDownObservable()
                                            .Select(e => e.EventArgs.GetPosition(map))
                                            .Choose(point => TryGetEdgePoint(map, point, tolerancePixels))
                                            .Select(((int areaIndex, int coordinateIndex) p) =>
                                                new Message.BeginMoveLocationMessage(
                                                    p.areaIndex,
                                                    p.coordinateIndex
                                                )
                                            )
                                            .Subscribe(m => dispatch(m))
                                            .DisposeWith(d);
                                    }

                                    var definingAreaIndex = state.Areas.FindIndex(a => !a.IsDefined);
                                    if (definingAreaIndex >= 0)
                                    {
                                        var definingArea = state.Areas[definingAreaIndex];
                                        map
                                            .PreviewMouseDownObservable()
                                            .Select(e => e.EventArgs.GetPosition(map))
                                            .Subscribe(position =>
                                            {
                                                var isClosing =
                                                    definingArea.Coordinates.Count > 0
                                                    && definingArea.Coordinates[0].Coordinate.ToLocation().ToViewportPoint(map).DistanceTo(position) < tolerancePixels;
                                                if (isClosing)
                                                {
                                                    dispatch(new Message.EndDefineAreaMessage(definingAreaIndex));
                                                }
                                                else
                                                {
                                                    var message = new Message.InsertLocationMessage(
                                                        definingAreaIndex,
                                                        definingArea.Coordinates.Count,
                                                        map.ViewportPointToLocation(position).ToCoordinate());
                                                    dispatch(message);
                                                }
                                            })
                                            .DisposeWith(d);
                                    }

                                    return d;
                                })
                                .Subscribe(map => map
                                    .PreviewMouseLeftButtonDownObservable()
                                    .Where(e => e.EventArgs.ClickCount == 2)
                                    .Do(e => e.EventArgs.Handled = true)
                                    .Select(mouseMoveEvent => mouseMoveEvent.EventArgs.GetPosition(map))
                                    .Choose(point => TryGetVertexPoint(map, point, tolerancePixels))
                                    .Subscribe(((int areaIndex, int coordinateIndex, Coordinate coordinate) q) =>
                                        dispatch(new Message.InsertLocationMessage(q.areaIndex, q.coordinateIndex, q.coordinate))
                                    )
                                )
                                .Subscribe(map => map
                                    .MouseRightButtonDownObservable()
                                    .Select(mouseMoveEvent => mouseMoveEvent.EventArgs.GetPosition(map))
                                    .Choose(point => TryGetEdgePoint(map, point, tolerancePixels))
                                    .Subscribe(((int areaIndex, int coordinateIndex) q) =>
                                        dispatch(new Message.RemoveLocationMessage(q.areaIndex, q.coordinateIndex))
                                    )
                                )
                                .Subscribe(p =>
                                    Observable
                                        .FromEventPattern<MapEventArgs>(
                                            h => p.ViewChangeEnd += h,
                                            h => p.ViewChangeEnd -= h
                                        )
                                        .Select(_ => new Message.ChangeMapViewMessage(p.ZoomLevel, p.Center.ToCoordinate()))
                                        .Where(m => m.ZoomLevel != state.MapZoomLevel || m.Center != state.Center)
                                        .Subscribe(m => dispatch(m))
                                ),
                            WpfVDomNode.Create<DataGrid>()
                                .Set(p => p.AutoGenerateColumns, false)
                                .Set(p => p.CanUserAddRows, true)
                                .Set(p => p.SelectedIndex, state.Areas.FindIndex(area => area.IsSelected))
                                .SetChildNodes(p => p.Columns,
                                    WpfVDomNode.Create<DataGridTextColumn>()
                                        .Set(p => p.Header, "Title")
                                        .Set(p => p.Binding, new Binding(nameof(AreaInformation.Title))),
                                    WpfVDomNode.Create<DataGridTextColumn>()
                                        .Set(p => p.Header, "Number of edges")
                                        .Set(p => p.Binding, new Binding(nameof(AreaInformation.EdgeCount)))
                                )
                                .SetCollection(
                                    p => p.ItemsSource,
                                    state.Areas
                                        .Select((area, index) => new AreaInformation(area.Note, area.Coordinates.Count, index))
                                )
                                .Subscribe(
                                    p => p.SelectionChangedObservable()
                                        .Select(q => q.EventArgs.AddedItems.OfType<AreaInformation>().FirstOrDefault())
                                        .Subscribe(q => dispatch(new Message.SelectAreaMessage(q?.Index ?? -1)))
                                )
                                .Subscribe(
                                    p => p
                                        .RowEditEndingObservable()
                                        .Subscribe(e =>
                                        {
                                            // WPF doesn't contain a `RowEditEnded` event
                                            // so the common suggestion is to wait until
                                            // the data context is updated before using it.
                                            // see e.g. item 5 in https://blogs.msdn.microsoft.com/vinsibal/2009/04/14/5-more-random-gotchas-with-the-wpf-datagrid/
                                            Application.Current.Dispatcher.BeginInvoke(
                                                new Action(() =>
                                                {
                                                    var area = (AreaInformation)e.EventArgs.Row.Item;
                                                    var message =
                                                        area.IsNewArea
                                                        ? (Message)new Message.AddAreaMessage(area.Title)
                                                        : new Message.UpdateAreaTitleMessage(area.Index, area.Title);
                                                    dispatch(message);
                                                }),
                                                DispatcherPriority.Background);
                                        })
                                )
                        )
                );
        }

        private static IEnumerable<IVDomNode> AreaView(
            int areaIndex,
            Area area,
            Dispatch<Message> dispatch)
        {
            var locations = area
                .Coordinates
                .Select(p => p.Coordinate.ToLocation());

            var areaCenter = GetCenter(new[] { area });

            var color = area.IsSelected ? Colors.OrangeRed : Colors.PaleVioletRed;

            var node = area.IsDefined
                ? (IVDomNode<MapShapeBase>)WpfVDomNode.Create<MapPolygon>()
                : WpfVDomNode.Create<MapPolyline>();
            yield return node
                .Set(p => p.Stroke, WpfVDomNode.Create<SolidColorBrush>().Set(p => p.Color, color))
                .Set(p => p.StrokeThickness, 3)
                .Set(p => p.StrokeLineJoin, PenLineJoin.Round)
                .Set(
                    p => p.Locations,
                    new LocationCollection(),
                    EqualityComparer.Create((System.Collections.IList l) => l == null))
                .SetCollection(p => p.Locations, locations)
                .Set(p => p.Opacity, 0.7);

            var edgeWidth = 10;
            var edges = area.Coordinates
                .Select((coord, locationIndex) => WpfVDomNode.Create<Ellipse>()
                    .Set(p => p.Width, edgeWidth)
                    .Set(p => p.Height, edgeWidth)
                    .Set(p => p.Fill, WpfVDomNode.Create<SolidColorBrush>().Set(p => p.Color, color))
                    .Set(p => p.Opacity, 0.9)
                    .Attach(MapLayer.PositionProperty, coord.Coordinate.ToLocation())
                    .Attach(MapLayer.PositionOffsetProperty, new Point(-edgeWidth / 2.0, -edgeWidth / 2.0))
                    .Subscribe(p =>
                    {
                        var d = new CompositeDisposable();

                        if (coord.IsDragging)
                        {
                            var map = p.TryFindParent<WpfMap>();
                            map
                                .PreviewMouseMoveObservable()
                                .Do(mouseMoveEvent => mouseMoveEvent.EventArgs.Handled = true)
                                .Select(mouseMoveEvent => map.ViewportPointToLocation(mouseMoveEvent.EventArgs.GetPosition(map)))
                                .Where(location => location != null)
                                .Select(location =>
                                    new Message.MoveLocationMessage(
                                        areaIndex,
                                        locationIndex,
                                        location.ToCoordinate()
                                    )
                                )
                                .Subscribe(m => dispatch(m))
                                .DisposeWith(d);

                            map
                                .MouseUpObservable()
                                .Select(_ => new Message.EndMoveLocationMessage(areaIndex, locationIndex))
                                .Subscribe(m => dispatch(m))
                                .DisposeWith(d);
                        }

                        return d;
                    })
                );
            foreach (var edge in edges)
            {
                yield return edge;
            }

            yield return WpfVDomNode.Create<Pushpin>()
                .Set(p => p.Location, areaCenter.ToLocation())
                .Set(p => p.Content, area.Note.Substring(0, 1))
                .Attach(ToolTipService.ToolTipProperty, area.Note);
        }

        private static Option<(int areaIndex, int coordinateIndex, Coordinate coordinate)> TryGetVertexPoint(
            WpfMap map,
            Point point,
            double tolerancePixels)
        {
            var nearest = map
                .FindChildren<MapPolygon>(forceUsingTheVisualTreeHelper: true)
                .SelectMany((polygon, polygonIndex) =>
                {
                    return polygon
                        .Locations
                        .Concat(Optional(polygon.Locations.FirstOrDefault()))
                        .Buffer(2, 1)
                        .Where(buffer => buffer.Count == 2)
                        .Select((buffer, i) =>
                        {
                            var point1 = map.LocationToViewportPoint(buffer[0]);
                            var point2 = map.LocationToViewportPoint(buffer[1]);
                            var lineVector = new Vector2((float)(point2.X - point1.X), (float)(point2.Y - point1.Y));
                            var pointVector = new Vector2((float)(point.X - point1.X), (float)(point.Y - point1.Y));
                            var nearestPoint = pointVector.GetNearestPointAt(lineVector);
                            var distance = Vector2.Distance(pointVector, nearestPoint);
                            var newPoint = new Point(point1.X + nearestPoint.X, point1.Y + nearestPoint.Y);
                            var newLocation = map.ViewportPointToLocation(newPoint);
                            var newCoordinate = newLocation.ToCoordinate();

                            return new { AreaIndex = polygonIndex, CoordinateIndex = i + 1, Distance = distance, Coordinate = newCoordinate };
                        });
                })
                .MinBy(p => p.Distance)
                [0];

            return nearest.Distance < tolerancePixels
                ? Some((nearest.AreaIndex, nearest.CoordinateIndex, nearest.Coordinate))
                : None;
        }

        private static Option<(int areaIndex, int coordinateIndex)> TryGetEdgePoint(
            WpfMap map,
            Point point,
            double tolerancePixels)
        {
            var nearest = map
                .FindChildren<MapPolygon>(forceUsingTheVisualTreeHelper: true)
                .SelectMany((polygon, polygonIndex) =>
                {
                    return polygon
                        .Locations
                        .Select((location, i) =>
                        {
                            var edgePoint = map.LocationToViewportPoint(location);
                            var distance = edgePoint.DistanceTo(point);

                            return new { AreaIndex = polygonIndex, CoordinateIndex = i, Distance = distance };
                        });
                })
                .MinBy(p => p.Distance)
                [0];

            return nearest.Distance < tolerancePixels
                ? Some((nearest.AreaIndex, nearest.CoordinateIndex))
                : None;
        }

        // see https://stackoverflow.com/a/14231286/1293659
        private static Coordinate GetCenter(IEnumerable<Area> areas)
        {
            var (x, y, z, count) = areas
                .SelectMany(area => area.Coordinates)
                .Select(p => p.Coordinate)
                .Aggregate((x: 0.0, y: 0.0, z: 0.0, count: 0), (center, point) =>
                {
                    var latitude = point.Latitude * Math.PI / 180;
                    var longitude = point.Longitude * Math.PI / 180;
                    return (
                        center.x + Math.Cos(latitude) * Math.Cos(longitude),
                        center.y + Math.Cos(latitude) * Math.Sin(longitude),
                        center.z + Math.Sin(latitude),
                        center.count + 1
                    );
                });

            var avgX = x / count;
            var avgY = y / count;
            var avgZ = z / count;

            var centralLongitude = Math.Atan2(avgY, avgX);
            var centralSquareRoot = Math.Sqrt(avgX * avgX + avgY * avgY);
            var centralLatitude = Math.Atan2(avgZ, centralSquareRoot);

            return new Coordinate(centralLatitude * 180 / Math.PI, centralLongitude * 180 / Math.PI);
        }
    }
}
