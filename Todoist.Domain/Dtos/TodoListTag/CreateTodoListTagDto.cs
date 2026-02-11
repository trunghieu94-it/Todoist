namespace Todoist.Domain.Dtos.TodoListTag
{
    public class CreateTodoListTagDto : TodoListTagBaseDto
    {
        public int TodoListId { get; set; }
        public int TagId { get; set; }
    }
}
