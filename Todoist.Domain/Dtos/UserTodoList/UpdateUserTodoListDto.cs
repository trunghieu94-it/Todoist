using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.UserWork;

public class UpdateUserTodoListDto
{
    public UserTodoListRole UserRole { get; set; }
}
