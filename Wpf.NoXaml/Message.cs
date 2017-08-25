using OneOf;

namespace Wpf.NoXaml
{
    public abstract class Message : OneOfBase<
        Message.AddTodo,
        Message.DisableAdd,
        Message.EnableAdd,
        Message.TodoAddSuccess,
        Message.TodoAddError,
        Message.SetNewTodoDueDate,
        Message.SetNewTodoTitle,
        Message.ToggleDone>
    {
        public class AddTodo : Message { }

        public class SetNewTodoTitle : Message
        {
            public string Title { get; }

            public SetNewTodoTitle(string title)
            {
                Title = title;
            }
        }

        public class SetNewTodoDueDate : Message
        {
            public string DueDate { get; }

            public SetNewTodoDueDate(string dueDate)
            {
                DueDate = dueDate;
            }
        }

        public class ToggleDone : Message
        {
            public TodoItem TodoItem { get; }

            public ToggleDone(TodoItem todoItem)
            {
                TodoItem = todoItem;
            }
        }

        public class DisableAdd : Message
        {
        }

        public class TodoAddSuccess : Message
        {
            public TodoItem TodoItem { get; }

            public TodoAddSuccess(TodoItem todoItem)
            {
                TodoItem = todoItem;
            }
        }

        public class TodoAddError : Message
        {
            public TodoItem TodoItem { get; }

            public TodoAddError(TodoItem todoItem)
            {
                TodoItem = todoItem;
            }
        }

        public class EnableAdd : Message
        {
        }
    }
}
