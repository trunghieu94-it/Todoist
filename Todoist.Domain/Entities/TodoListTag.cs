namespace Todoist.Domain.Entities
{
    public class TodoListTag
    {
        public int TodoListId { get; set; }
        public int TagId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
