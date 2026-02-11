namespace Todoist.Domain.Dtos.Task
{
    public class CreateTodoItemDto : TodoItemBaseDto
    {
        public int TodoListId { get; set; }
    }
}
