using System;

using Todoist.WinForms.Enums;

namespace Todoist.WinForms.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string ListName { get; set; } = string.Empty;

        public DateTime? Deadline { get; set; }
        public DateTime CreatedAt { get; set; }

        public TodoListPriority ListPriority { get; set; }
        public TodoListStatus ListStatus { get; set; }
    }
}
