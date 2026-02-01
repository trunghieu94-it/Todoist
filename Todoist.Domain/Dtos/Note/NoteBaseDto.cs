namespace Todoist.Domain.Dtos.Note
{
    public class NoteBaseDto
    {
        public int WorkId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
