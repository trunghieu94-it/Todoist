using Todoist.Domain.Enums;

namespace Todoist.Domain.Dtos.Task
{
    public class TaskBaseDto
    {
        public string TaskName { get; set; } = string.Empty;
        public TaskState Status { get; set; }
    }
}
