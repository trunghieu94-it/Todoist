namespace Todoist.Domain.Dtos.Work
{
    public class UpdateTodoListDto : TodoListBaseDto
    {
        public DateTime? Deadline { get; set; }
    }
}
