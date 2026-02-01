namespace Todoist.Domain.Entities
{
    public class Work
    {
        public enum WorkStatus
        {
            New,
            InProgress,
            Done
        }
        public int Id { get; private set; }
        public string WorkName { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public decimal Progress { get; set; }
        public int Priority { get; set; }
        public WorkStatus Status { get; set; }
    }
}
