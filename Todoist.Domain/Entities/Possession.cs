namespace Todoist.Domain.Entities
{
    public class Possession
    {
        public int UserId { get; private set; }
        public int WorkId { get; private set; }
        public DateTime DateCreated { get; set; }
    }
}
