using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.Task
{
    public class TaskBaseDto
    {
        public int Id { get; set; }
        public int WorkId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public TaskState Status { get; set; }
    }
}
