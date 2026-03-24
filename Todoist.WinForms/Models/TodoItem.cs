using System;

using Todoist.WinForms.Enums;

namespace Todoist.WinForms.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public int TodoListId { get; set; }

        public string Title { get; set; } = string.Empty;
        public TodoItemStatus ItemStatus { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
