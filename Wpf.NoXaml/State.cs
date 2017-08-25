using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Wpf.NoXaml
{
    public class State
    {
        public static readonly State Empty =
            new State(default(DateTime), TodoItem.Empty, new TodoItem[0], false);

        public DateTime CurrentTime { get; }
        public TodoItem NewItem { get; }
        public ImmutableList<TodoItem> TodoItems { get; }
        public bool IsSaving { get; }

        public State(DateTime currentTime, TodoItem newItem, IEnumerable<TodoItem> todoItems, bool isSaving)
        {
            CurrentTime = currentTime;
            NewItem = newItem;
            TodoItems = todoItems.ToImmutableList();
            IsSaving = isSaving;
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