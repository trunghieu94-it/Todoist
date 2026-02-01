namespace Todoist.Domain.Entities
{
    public class Note
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int WorkId { get; private set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
