namespace Todoist.Domain.Dtos.Work
{
    public class CreateTodoListDto : TodoListBaseDto
    {
        public int UserId { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
