namespace Todoist.Domain.Dtos.Tag
{
    public class TagBaseDto
    {
        public int UserId { get; set; }
        public string TagName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
