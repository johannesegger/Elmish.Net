using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using Newtonsoft.Json;
using Wpf.NoXaml.Utils;

namespace Wpf.NoXaml
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
            var modelSubject = new BehaviorSubject<Model>(Model.Empty);
            var rootLens = Lens.Create(modelSubject);

            modelSubject
                .Subscribe(model => Debug.WriteLine(JsonConvert.SerializeObject(model)));

            var currentTimeLens = rootLens.Focus(model => model.CurrentTime);
            Observable
                .Interval(TimeSpan.FromMilliseconds(1))
                .Select(_ => DateTime.Now)
                .Take(TimeSpan.FromSeconds(10))
                .ObserveOnDispatcher()
                .Subscribe(currentTimeLens.Set);

            // From DB
            var todoItemsLens = rootLens.Focus(model => model.TodoItems);
            ImmutableList<TodoItem>
                .Empty
                .Add(new TodoItem("Buy shoes", new DateTime(2017, 9, 11), true))
                .Add(new TodoItem("Clean house", new DateTime(2017, 8, 20), false))
                .Then(todoItemsLens.Set);

            var newItemLens = rootLens.Focus(model => model.NewItem);

            Title = "Hello, XAML-free WPF";
            Content = new StackPanel
            {
                Children =
                {
                    new TextBlock()
                        .Bind(o => o.OneWay(
                            p => p.Text,
                            rootLens.Focus(model => model.CurrentTime),
                            d => $"Current time: {d.ToString("O", CultureInfo.CurrentUICulture)}"))
                        .Element,
                    new DockPanel
                    {
                        Children =
                        {
                            new Button { Content = "+" }
                                .Attach(DockPanel.DockProperty, Dock.Right)
                                .Bind(o => o.Command(
                                    o.Element.ClickObservable(),
                                    newItemLens.Select(item => !string.IsNullOrWhiteSpace(item.Title)),
                                    async (_, ct) =>
                                    {
                                        // TODO extract logic
                                        await Task.Delay(TimeSpan.FromSeconds(2), ct);
                                        rootLens
                                            .ExecuteAtomic(lens =>
                                            {
                                                lens
                                                    .Focus(model => model.TodoItems)
                                                    .Update(todoItems => lens
                                                        .Focus(model => model.NewItem)
                                                        .Exchange(TodoItem.Empty)
                                                        .Then(todoItems.Add));
                                            });
                                    }))
                                .Element,
                            new TextBox()
                                .Attach(DockPanel.DockProperty, Dock.Right)
                                .Bind(o => o.TwoWay(
                                    p => p.Text,
                                    newItemLens.Focus(model => model.DueTime),
                                    d => DateTime.Parse(d, CultureInfo.CurrentUICulture), // TODO add error handling
                                    d => d.ToString(CultureInfo.CurrentUICulture)))
                                .Element,
                            new TextBox()
                                .Attach(TextBoxHelper.WatermarkProperty, "What do you want to do?")
                                .Bind(o => o.TwoWay(p => p.Text, newItemLens.Focus(model => model.Title)))
                                .Element
                        }
                    },
                    new ItemsControl()
                        .Bind(o => o.Collection(
                            p => p.Items,
                            rootLens.Focus<IImmutableList<TodoItem>>(model => model.TodoItems),
                            (personLens, registerBinding) =>
                                new StackPanel
                                {
                                    Orientation = Orientation.Horizontal,
                                    Children =
                                    {
                                        new TextBlock()
                                            .Bind().OneWay(p => p.Text, personLens.Focus(p => p.Title))
                                            .Register(registerBinding),
                                        new TextBlock()
                                            .Bind().OneWay(p => p.Text, personLens.Focus(p => p.DueTime), d => d.ToString(CultureInfo.CurrentUICulture))
                                            .Register(registerBinding),
                                        new CheckBox()
                                            .Bind().TwoWay(p => p.IsChecked, personLens.Focus(p => p.Done), p => p ?? false, p => p)
                                            .Register(registerBinding)
                                    }
                                }))
                        .Element
                }
            };
        }
    }
}
