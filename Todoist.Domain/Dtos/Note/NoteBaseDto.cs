namespace Todoist.Domain.Dtos.Note
{
    public class NoteBaseDto
    {
        //public int Id { get; set; }
        public int UserId { get; set; }
        public int? TodoListId { get; set; }

        public string Title { get; set; } = null!;
        public string? NoteContent { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
