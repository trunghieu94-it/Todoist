namespace Todoist.Domain.Dtos.Work
{
    public class WorkBaseDto
    {
        public enum WorkStatus
        {
            New,
            InProgress,
            Done
        }
        public string WorkName { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public int Priority { get; set; }
        public WorkStatus Status { get; set; }
    }
}
