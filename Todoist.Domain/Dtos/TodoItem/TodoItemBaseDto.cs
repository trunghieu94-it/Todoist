using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.Task
{
    public class TodoItemBaseDto
    {
        public string Title { get; set; } = null!;
        public TodoItemStatus ItemStatus { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
