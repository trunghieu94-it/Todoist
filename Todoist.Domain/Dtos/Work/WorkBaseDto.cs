using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.Work
{
    public class WorkBaseDto
    {
        public string WorkName { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public decimal Progress { get; set; }
        public int Priority { get; set; }
        public State Status { get; set; }
    }
}
