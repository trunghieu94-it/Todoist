namespace Todoist.Domain.Dtos.TodoListTag
{
    public class UpdateTodoListTagDto : TodoListTagBaseDto
    {
        public int TodoListId { get; set; }
        public int TagId { get; set; }
    }
}
