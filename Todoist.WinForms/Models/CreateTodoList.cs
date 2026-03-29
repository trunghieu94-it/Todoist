using System;

using Todoist.WinForms.Enums;


namespace Todoist.WinForms.Models
{
    public class CreateTodoList
    {
        public int UserId { get; } = 1;
        public string ListName { get; set; } = string.Empty;
        public DateTime? Deadline { get; set; }
        public TodoListPriority ListPriority { get;} = TodoListPriority.Low;
        public TodoListStatus ListStatus { get;} = TodoListStatus.Active;
    }
}
