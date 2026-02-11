namespace Todoist.Domain.Dtos.Note
{
    public class NoteDto : NoteBaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
