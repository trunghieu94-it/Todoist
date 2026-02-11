namespace Todoist.Domain.Dtos.Work
{
    public class TodoListDto : TodoListBaseDto
    {
        public int Id { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
