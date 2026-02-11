using Todoist.Domain.Enums;

namespace Todoist.Domain.Entities
{
    public class UserTodoList
    {
        public int UserId { get; set; }
        public int TodoListId { get; set; }

        public UserTodoListRole UserRole { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
