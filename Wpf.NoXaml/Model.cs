using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Wpf.NoXaml
{
    public class Model
    {
        public static readonly Model Empty =
            new Model(default(DateTime), TodoItem.Empty, new TodoItem[0]);

        public DateTime CurrentTime { get; }
        public TodoItem NewItem { get; }
        public ImmutableList<TodoItem> TodoItems { get; }

        public Model(DateTime currentTime, TodoItem newItem, IEnumerable<TodoItem> todoItems)
        {
            CurrentTime = currentTime;
            NewItem = newItem;
            TodoItems = todoItems.ToImmutableList();
        }
    }

    public class TodoItem
    {
        public static readonly TodoItem Empty =
            new TodoItem(string.Empty, default(DateTime), default(bool));

        public string Title { get; }
        public DateTime DueTime { get; }
        public bool Done { get; }

        public TodoItem(string title, DateTime dueTime, bool done)
        {
            Title = title;
            DueTime = dueTime;
            Done = done;
        }
    }
}