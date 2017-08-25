using System;
using System.Collections.Generic;
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
            //modelSubject
            //    .Subscribe(model => Debug.WriteLine(JsonConvert.SerializeObject(model)));

            //var currentTimeLens = rootLens.Focus(model => model.CurrentTime);
            //Observable
            //    .Interval(TimeSpan.FromMilliseconds(1))
            //    .Select(_ => DateTime.Now)
            //    .Take(TimeSpan.FromSeconds(10))
            //    .ObserveOnDispatcher()
            //    .Subscribe(currentTimeLens.Set);

            // From DB
            var initialState = State
                .Empty
                .Set(
                    p => p.TodoItems,
                    ImmutableList<TodoItem>
                        .Empty
                        .Add(new TodoItem("Buy shoes", new DateTime(2017, 9, 11), true))
                        .Add(new TodoItem("Clean house", new DateTime(2017, 8, 20), false)));

            Title = "Hello, XAML-free WPF";

            var messageSubject = new Subject<Message>();
            Dispatch<Message> dispatch = messageSubject.OnNext;

            var initialUpdateResult = (State: initialState, Cmd: Cmd.None<Message>());

            messageSubject
                .Scan(initialUpdateResult, (updateResult, message) => Update(updateResult.State, message))
                //.Do(updateResult => updateResult.Cmd.Subs.ForEach(sub => sub(dispatch)))
                //.Select(p => p.State)
                .StartWith(initialUpdateResult)
                .Do(updateResult => Debug.WriteLine(JsonConvert.SerializeObject(updateResult.State)))
                .Select(updateResult =>
                {
                    var result = View(updateResult.State, dispatch);
                    return (View: result, Cmd: updateResult.Cmd);
                })
                .ObserveOnDispatcher()
                .Subscribe(p =>
                {
                    Content = p.View.Materialize();
                    p.Cmd.Subs.ForEach(sub => sub(dispatch));
                });
        }

        private static (State, Cmd<Message>) Update(State state, Message message)
        {
            return message.Match(
                (Message.AddTodo m) =>
                {
                    var todoItem = state.NewItem;
                    var cmds = Cmd.Batch(
                        Cmd.OfMsg<Message>(new Message.DisableAdd()),
                        Cmd.OfAsync<Message>(
                            () => Task.Delay(2000),
                            new Message.TodoAddSuccess(todoItem),
                            e => new Message.TodoAddError(todoItem)));
                    return (state, cmds);
                },
                (Message.DisableAdd m) =>
                {
                    var newState = state
                        .Set(p => p.IsSaving, true);
                    return (newState, Cmd.None<Message>());
                },
                (Message.EnableAdd m) =>
                {
                    var newState = state
                        .Set(p => p.IsSaving, false);
                    return (newState, Cmd.None<Message>());
                },
                (Message.TodoAddSuccess m) =>
                {
                    var newState = state
                        .Set(p => p.TodoItems, state.TodoItems.Add(state.NewItem))
                        .Set(p => p.NewItem, TodoItem.Empty);
                    return (newState, Cmd.OfMsg<Message>(new Message.EnableAdd()));
                },
                (Message.TodoAddError m) =>
                {
                    // TODO notify user
                    return (state, Cmd.OfMsg<Message>(new Message.EnableAdd()));
                },
                (Message.SetNewTodoDueDate m) =>
                {
                    if (DateTime.TryParse(m.DueDate, CultureInfo.CurrentUICulture, DateTimeStyles.None, out var dueTime))
                    {
                        var newState = state
                            .Set(p => p.NewItem.DueTime, dueTime);
                        return (newState, Cmd.None<Message>());
                    }
                    // TODO add error handling
                    return (state, Cmd.None<Message>());
                },
                (Message.SetNewTodoTitle m) =>
                {
                    var newState = state
                        .Set(p => p.NewItem.Title, m.Title);
                    return (newState, Cmd.None<Message>());
                },
                (Message.ToggleDone m) =>
                {
                    TodoItem Update(TodoItem item)
                    {
                        return item == m.TodoItem
                            ? item.Set(p => p.Done, !item.Done)
                            : item;
                    }
                    var newState = state
                        .Set(p => p.TodoItems, state.TodoItems.Select(Update));
                    return (newState, Cmd.None<Message>());
                });
        }

        private static IVNode View(State state, Dispatch<Message> dispatch)
        {
            return VNode.Create<StackPanel>()
                .Set(
                    p => p.Children,
                    VNode.Create<TextBlock>()
                        .Set(p => p.Text, state.CurrentTime.ToString("O", CultureInfo.CurrentUICulture)),
                    VNode.Create<DockPanel>()
                        .Set(
                            p => p.Children,
                            VNode.Create<Button>()
                                .Attach(DockPanel.DockProperty, Dock.Right)
                                .Set(p => p.Content, "+")
                                .Set(p => p.IsEnabled, !string.IsNullOrWhiteSpace(state.NewItem.Title) && !state.IsSaving)
                                .OnEvent(p => p.ClickObservable(), _ => dispatch(new Message.AddTodo())),
                            VNode.Create<TextBox>()
                                .Attach(DockPanel.DockProperty, Dock.Right)
                                .Set(p => p.Text, state.NewItem.DueTime.ToString(CultureInfo.CurrentUICulture))
                                .OnEvent(p => p.TextChangedObservable().Select(e => ((TextBox)e.Sender).Text), p => dispatch(new Message.SetNewTodoDueDate(p))),
                            VNode.Create<TextBox>()
                                .Attach(TextBoxHelper.WatermarkProperty, "What do you want to do?")
                                .Set(p => p.Text, state.NewItem.Title)
                                .OnEvent(p => p.TextChangedObservable().Select(e => ((TextBox)e.Sender).Text), p => dispatch(new Message.SetNewTodoTitle(p)))),
                    VNode.Create<ItemsControl>()
                        .Set(
                            p => p.Items,
                            state.TodoItems
                                .Select(todoItem =>
                                {
                                    return VNode.Create<StackPanel>()
                                        .Set(p => p.Orientation, Orientation.Horizontal)
                                        .Set(
                                            p => p.Children,
                                            VNode.Create<TextBlock>().Set(p => p.Text, todoItem.Title),
                                            VNode.Create<TextBlock>().Set(p => p.Text, todoItem.DueTime.ToString(CultureInfo.CurrentUICulture)),
                                            VNode.Create<CheckBox>()
                                                .Set(p => p.IsChecked, todoItem.Done)
                                                .OnEvent(p => p.CheckedObservable(), _ => dispatch(new Message.ToggleDone(todoItem)))
                                                .OnEvent(p => p.UncheckedObservable(), _ => dispatch(new Message.ToggleDone(todoItem))));
                                })));
        }
    }

    public class Cmd<TMessage>
    {
        public Cmd(IEnumerable<Sub<TMessage>> subs)
        {
            Subs = subs.ToList();
        }

        public IReadOnlyCollection<Sub<TMessage>> Subs { get; }
    }

    public static class Cmd
    {
        public static Cmd<TMessage> None<TMessage>()
        {
            return new Cmd<TMessage>(new Sub<TMessage>[0]);
        }

        public static Cmd<TMessage> OfSub<TMessage>(Sub<TMessage> sub)
        {
            return new Cmd<TMessage>(new[] { sub });
        }

        public static Cmd<TMessage> OfMsg<TMessage>(TMessage message)
        {
            return OfSub<TMessage>(dispatch => dispatch(message));
        }

        public static Cmd<TMessage> Batch<TMessage>(IEnumerable<Cmd<TMessage>> cmds)
        {
            return new Cmd<TMessage>(cmds.SelectMany(p => p.Subs));
        }

        public static Cmd<TMessage> Batch<TMessage>(params Cmd<TMessage>[] cmds)
        {
            return Batch(cmds.AsEnumerable());
        }

        public static Cmd<TMessage> OfAsync<TResult, TMessage>(
            Func<Task<TResult>> action,
            Func<TResult, TMessage> ofSuccess,
            Func<Exception, TMessage> ofError)
        {
            async void Sub(Dispatch<TMessage> dispatch)
            {
                try
                {
                    dispatch(ofSuccess(await action()));
                }
                catch (Exception e)
                {
                    dispatch(ofError(e));
                }
            }

            return OfSub<TMessage>(Sub);
        }

        public static Cmd<TMessage> OfAsync<TMessage>(
            Func<Task> action,
            TMessage success,
            Func<Exception, TMessage> ofError)
        {
            async void Sub(Dispatch<TMessage> dispatch)
            {
                try
                {
                    await action();
                    dispatch(success);
                }
                catch (Exception e)
                {
                    dispatch(ofError(e));
                }
            }

            return OfSub<TMessage>(Sub);
        }
    }

    public delegate void Dispatch<in TMessage>(TMessage message);

    public delegate void Sub<out TMessage>(Dispatch<TMessage> dispatch);
}
