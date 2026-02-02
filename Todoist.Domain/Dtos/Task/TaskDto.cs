namespace Todoist.Domain.Dtos.Task
{
    public class TaskDto : TaskBaseDto
    {
         public int Id { get; set; }
         public int WorkId { get; set; }
    }
}
