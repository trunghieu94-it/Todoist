namespace Todoist.Domain.Dtos.Possession
{
    public class PossessionDto
    {
        public int UserId { get; private set; }
        public int WorkId { get; private set; }
        public DateTime DateCreated { get; set; }
    }
}
