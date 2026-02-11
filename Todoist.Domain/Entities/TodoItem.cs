using Todoist.Domain.Enums;

namespace Todoist.Domain.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }
        public int TodoListId { get; set; }

        public string Title { get; set; } = null!;
        public TodoItemStatus ItemStatus { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
