using Todoist.Domain.Enums;

namespace Todoist.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public int WorkId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public State Status { get; set; }
    }
}
