using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.Work
{
    public class TodoListBaseDto
    {
        public string ListName { get; set; } = null!;
        //public DateTime? Deadline { get; set; }

        public TodoListPriority ListPriority { get; set; }
        public TodoListStatus ListStatus { get; set; }

        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
    }
}
