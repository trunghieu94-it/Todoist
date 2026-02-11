using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.UserWork;

public class UserTodoListBaseDto
{
    public int UserId { get; set; }
    public int TodoListId { get; set; }
    public UserTodoListRole UserRole { get; set; }
}
