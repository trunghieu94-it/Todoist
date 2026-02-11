namespace Todoist.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string TagName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
