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
using LanguageExt;
using MahApps.Metro.Controls;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Core;
using Wpf.Elmish.Sample.Utils;
using static LanguageExt.Prelude;
using WpfMap = Microsoft.Maps.MapControl.WPF.Map;

namespace Wpf.Elmish.Sample
{
    internal class Program
    {
        [STAThread]
        private static void Main()
        {
            var app = new App();
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
            app.Run(new MainWindow());
        }
    }

    internal class App : Application
    {
    }

    internal class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            Title = "Hello, XAML-free WPF";

            ElmishApp.Run(Init(), Update, View, () => Content);
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
                .Set(p => p.Areas, areas)
                .Set(p => p.MapZoomLevel, 15)
                .Set(p => p.Center, GetCenter(areas));
            return (initialState, Cmd.None<Message>());
        }

        private static (State, Cmd<Message>) Update(Message message, State state)
        {
            return message.Match(
                (Message.BeginMoveLocationMessage m) =>
                {
                    var newState = state.Set(p => p.Areas[m.AreaIndex].Coordinates[m.CoordinateIndex].IsDragging, true);
                    return (newState, Cmd.None<Message>());
                },
                (Message.MoveLocationMessage m) =>
                {
                    var newState = state.Set(p => p.Areas[m.AreaIndex].Coordinates[m.CoordinateIndex].Coordinate, m.Coordinate);
                    return (newState, Cmd.None<Message>());
                },
                (Message.EndMoveLocationMessage m) =>
                {
                    var newState = state.Set(p => p.Areas[m.AreaIndex].Coordinates[m.CoordinateIndex].IsDragging, false);
                    return (newState, Cmd.None<Message>());
                },
                (Message.InsertLocationMessage m) =>
                {
                    var newState = state.Set(
                        p => p.Areas[m.AreaIndex].Coordinates,
                        state.Areas[m.AreaIndex].Coordinates.Insert(m.CoordinateIndex, new DraggableCoordinate(m.Coordinate, false))
                    );
                    return (newState, Cmd.None<Message>());
                },
                (Message.RemoveLocationMessage m) =>
                {
                    var newState = state.Set(
                        p => p.Areas[m.AreaIndex].Coordinates,
                        state.Areas[m.AreaIndex].Coordinates.RemoveAt(m.CoordinateIndex)
                    );
                    return (newState, Cmd.None<Message>());
                },
                (Message.SelectAreaMessage m) =>
                {
                    Area Update(Area area, int index)
                    {
                        return area.Set(p => p.IsSelected, index == m.AreaIndex);
                    }

                    var newState = state.Set(p => p.Areas, state.Areas.Select(Update));
                    return (newState, Cmd.None<Message>());
                },
                (Message.UpdateAreaTitleMessage m) =>
                {
                    var newState = state.Set(p => p.Areas[m.AreaIndex].Note, m.Title);
                    return (newState, Cmd.None<Message>());
                },
                (Message.ChangeMapViewMessage m) =>
                {
                    var newState = state
                        .Set(p => p.MapZoomLevel, m.ZoomLevel)
                        .Set(p => p.Center, m.Center);
                    return (newState, Cmd.None<Message>());
                });
        }

        private static IVNode View(State state, Dispatch<Message> dispatch)
        {
            const double tolerancePixels = 10;

            return VNode.Create<StackPanel>()
                .SetCollection(
                    p => p.Children,
                    VNode.Create<WpfMap>()
                        .Set(
                            p => p.CredentialsProvider,
                            new ApplicationIdCredentialsProvider("AiYVQeyKth-2j8dkcIPe58rz3zxNt6Hw-ydHJhZLfklNfZPrWM9HlBr6LTnIgy65"),
                            EqualityComparer.Create((CredentialsProvider p) => ((ApplicationIdCredentialsProvider)p).ApplicationId))
                        .Set(p => p.Mode, VNode.Create<MapMode, AerialMode>())
                        .Set(p => p.Center, new Location(state.Center.Latitude, state.Center.Longitude))
                        .Set(p => p.ZoomLevel, state.MapZoomLevel)
                        .Set(p => p.Height, 500)
                        .Set(p => p.Culture, "de-AT")
                        .SetCollection(
                            p => p.Children,
                            VNode.Create<MapLayer>()
                                .SetCollection(
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

                            return d;
                        })
                        .Subscribe(map => map
                            .MouseLeftButtonDownObservable()
                            .Where(e => e.EventArgs.ClickCount == 2)
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
                                .Select(_ => new Message.ChangeMapViewMessage(p.ZoomLevel, new Coordinate(p.Center.Latitude, p.Center.Longitude)))
                                .Where(m => m.ZoomLevel != state.MapZoomLevel || m.Center != state.Center)
                                .Subscribe(m => dispatch(m))
                        ),
                    VNode.Create<DataGrid>()
                        .Set(p => p.AutoGenerateColumns, false)
                        .Set(p => p.SelectedIndex, state.Areas.FindIndex(area => area.IsSelected))
                        .SetCollection(p => p.Columns,
                            VNode.Create<DataGridTextColumn>()
                                .Set(p => p.Header, "Title")
                                .Set(p => p.Binding, new Binding(nameof(AreaInformation.Title)) { Mode = BindingMode.TwoWay })
                        )
                        .SetCollection(
                            p => p.ItemsSource,
                            state.Areas
                                .Select((area, index) => new AreaInformation(area.Note, index))
                                .ToList()
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
                                    App.Current.Dispatcher.BeginInvoke(
                                        new Action(() =>
                                        {
                                            var area = (AreaInformation)e.EventArgs.Row.Item;
                                            dispatch(new Message.UpdateAreaTitleMessage(area.Index, area.Title));
                                        }),
                                        DispatcherPriority.Background);
                                })
                        )
                );
        }

        private static IEnumerable<IVNode> AreaView(
            int areaIndex,
            Area area,
            Dispatch<Message> dispatch)
        {
            var locations = area
                .Coordinates
                .Select(p => new Location(p.Coordinate.Latitude, p.Coordinate.Longitude));

            var areaCenter = GetCenter(new[] { area });

            var color = area.IsSelected ? Colors.OrangeRed : Colors.PaleVioletRed;

            yield return VNode.Create<MapPolygon>()
                .Set(p => p.Stroke, new SolidColorBrush(color))
                .Set(p => p.StrokeThickness, 3)
                .Set(p => p.StrokeLineJoin, PenLineJoin.Round)
                .Set(p => p.Locations, new LocationCollection())
                .SetCollection(p => p.Locations, locations)
                .Set(p => p.Opacity, 0.7);

            var edgeWidth = 10;
            var edges = area.Coordinates
                .Select((p, locationIndex) => VNode.Create<Ellipse>()
                    .Set(q => q.Width, edgeWidth)
                    .Set(q => q.Height, edgeWidth)
                    .Set(q => q.Fill, new SolidColorBrush(color))
                    .Set(q => q.Opacity, 0.9)
                    .Attach(MapLayer.PositionProperty, new Location(p.Coordinate.Latitude, p.Coordinate.Longitude))
                    .Attach(MapLayer.PositionOffsetProperty, new Point(-edgeWidth / 2.0, -edgeWidth / 2.0))
                    .Subscribe(q =>
                    {
                        var d = new CompositeDisposable();

                        if (p.IsDragging)
                        {
                            var map = q.TryFindParent<WpfMap>();
                            map
                                .PreviewMouseMoveObservable()
                                .Do(mouseMoveEvent => mouseMoveEvent.EventArgs.Handled = true)
                                .Select(mouseMoveEvent => map.ViewportPointToLocation(mouseMoveEvent.EventArgs.GetPosition(map)))
                                .Where(location => location != null)
                                .Select(location =>
                                    new Message.MoveLocationMessage(
                                        areaIndex,
                                        locationIndex,
                                        new Coordinate(location.Latitude, location.Longitude)
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

            yield return VNode.Create<Pushpin>()
                .Set(p => p.Location, new Location(areaCenter.Latitude, areaCenter.Longitude))
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
                            var newCoordinate = new Coordinate(newLocation.Latitude, newLocation.Longitude);

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
