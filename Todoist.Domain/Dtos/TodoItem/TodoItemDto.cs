namespace Todoist.Domain.Dtos.Task
{
    public class TodoItemDto : TodoItemBaseDto
    {
        public int Id { get; set; }
        public int TodoListId { get; set; }
    }
}
