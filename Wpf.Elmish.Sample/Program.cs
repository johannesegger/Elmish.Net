using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
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

            ElmishApp.Run(Init, Update, View, () => Content);
        }

        private static (State, Cmd<Message>) Init()
        {
            var areas =
                ImmutableList<Area>
                    .Empty
                    .Add(new Area(new[] { new Coordinate(47.946812, 13.777095), new Coordinate(47.944375, 13.777380), new Coordinate(47.944338, 13.776286), new Coordinate(47.946508, 13.776049), new Coordinate(47.946485, 13.776685) }, "Enser"))
                    .Add(new Area(new[] { new Coordinate(47.946927, 13.777057), new Coordinate(47.947813, 13.776992), new Coordinate(47.948885, 13.780077), new Coordinate(47.948237, 13.780352) }, "Galler"));
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
                (Message.MoveLocationMessage m) =>
                {
                    Area Update(Area area)
                    {
                        if (area == m.Area)
                        {
                            return area.Set(p => p.Coordinates[m.CoordinateIndex], m.Coordinate);
                        }

                        return area;
                    }
                    var newState = state.Set(p => p.Areas, state.Areas.Select(Update));
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
            return VNode.Create<StackPanel>()
                .SetChildren(
                    p => p.Children,
                    VNode.Create<WpfMap>()
                        .Set(
                            p => p.CredentialsProvider,
                            new ApplicationIdCredentialsProvider("AiYVQeyKth-2j8dkcIPe58rz3zxNt6Hw-ydHJhZLfklNfZPrWM9HlBr6LTnIgy65"),
                            EqualityComparer.Create((CredentialsProvider p) => ((ApplicationIdCredentialsProvider)p).ApplicationId))
                        .Set(p => p.Mode, VNode.Create<MapMode, AerialMode>())
                        .Set(
                            p => p.Center,
                            new Location(state.Center.Latitude, state.Center.Longitude),
                            EqualityComparer.Create((Location p) => new { p.Latitude, p.Longitude })
                        )
                        .Set(p => p.ZoomLevel, state.MapZoomLevel)
                        .Set(p => p.Height, 500)
                        .Set(p => p.Culture, "de-AT")
                        .SetChildren(
                            p => p.Children,
                            state.Areas
                                .SelectMany(area =>
                                {
                                    var locationCollection = new LocationCollection();
                                    area
                                        .Coordinates
                                        .Select(p => new Location(p.Latitude, p.Longitude))
                                        .ForEach(locationCollection.Add);

                                    var areaCenter = GetCenter(new[] { area });

                                    return new IVNode[]
                                    {
                                        VNode.Create<MapPolygon>()
                                            .Set(p => p.Stroke, new SolidColorBrush(Colors.PaleVioletRed))
                                            .Set(p => p.StrokeThickness, 3)
                                            .Set(p => p.StrokeLineJoin, PenLineJoin.Round)
                                            .Set(p => p.Locations, new LocationCollection())
                                            .SetChildren(p => p.Locations, area.Coordinates
                                                .Select(p => new Location(p.Latitude, p.Longitude)))
                                            .Set(p => p.Opacity, 0.7)
                                            .OnEvent(
                                                p => p
                                                    .MouseDownObservable()
                                                    .Select(mouseDownEvent =>
                                                    {
                                                        var map = p.TryFindParent<WpfMap>();
                                                        var mousePosition = mouseDownEvent.EventArgs.GetPosition(map);
                                                        return TryGetPolygonLocation(p, mousePosition)
                                                            .Some(locationIndex =>
                                                            {
                                                                return map
                                                                    .PreviewMouseMoveObservable()
                                                                    .Do(mouseMoveEvent => mouseMoveEvent.EventArgs.Handled = true)
                                                                    .Select(mouseMoveEvent =>
                                                                    {
                                                                        var location = map.ViewportPointToLocation(mouseMoveEvent.EventArgs.GetPosition(map));
                                                                        return location;
                                                                    })
                                                                    .Where(location => location != null)
                                                                    .Do(location => p.Locations[locationIndex] = location)
                                                                    .TakeUntil(map.MouseUpObservable())
                                                                    .LastAsync()
                                                                    .Select(location => (
                                                                        Area: area,
                                                                        CoordinateIndex: locationIndex,
                                                                        Coordinate: new Coordinate(location.Latitude, location.Longitude)
                                                                    ));
                                                            })
                                                            .None(Observable.Empty((Area: default(Area), CoordinateIndex: default(int), Coordinate: default(Coordinate))));
                                                    })
                                                    .Switch(),
                                                move =>
                                                {
                                                    dispatch(new Message.MoveLocationMessage(move.Area, move.CoordinateIndex, move.Coordinate));
                                                }
                                            ),

                                        VNode.Create<Pushpin>()
                                            .Set(p => p.Location, new Location(areaCenter.Latitude, areaCenter.Longitude))
                                            .Set(p => p.Content, area.Note.Substring(0, 1))
                                            .Attach(ToolTipService.ToolTipProperty, area.Note)
                                    };
                                }))
                        .OnEvent(p =>
                            Observable
                                .FromEventPattern<MapEventArgs>(
                                    h => p.ViewChangeEnd += h,
                                    h => p.ViewChangeEnd -= h
                                )
                                .Select(e => new Message.ChangeMapViewMessage(p.ZoomLevel, new Coordinate(p.Center.Latitude, p.Center.Longitude))),
                            m => dispatch(m)
                        ),
                    VNode.Create<DataGrid>()
                        .Set(p => p.AutoGenerateColumns, false)
                        .SetChildren(p => p.Columns,
                            VNode.Create<DataGridTextColumn>()
                                .Set(p => p.Header, "Title")
                                .Set(p => p.Binding, new Binding("Title")))
                        .SetChildren(
                            p => p.Items,
                            state.Areas
                                .Select(area =>
                                {
                                    return new { Title = area.Note };
                                })));
        }

        private static Option<int> TryGetPolygonLocation(MapPolygon polygon, Point point)
        {
            var map = polygon.TryFindParent<WpfMap>();
            var nearest = polygon
                .Locations
                .Select((location, index) =>
                {
                    var distance = map.LocationToViewportPoint(location).DistanceTo(point);
                    return new { location, index, distance };
                })
                .MinBy(p => p.distance)
                [0];

            return nearest.distance < 5 /* pixels */ ? Some(nearest.index) : None;
        }

        // see https://stackoverflow.com/a/14231286/1293659
        private static Coordinate GetCenter(IEnumerable<Area> areas)
        {
            var (x, y, z, count) = areas
                .SelectMany(area => area.Coordinates)
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
