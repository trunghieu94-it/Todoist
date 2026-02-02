using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Task;
using Todoist.Infrastructure.Repositories.Task;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly ITaskRepository _taskRepository;

    public TasksController(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    // GET api/tasks
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tasks = await _taskRepository.GetAllAsync();

        IEnumerable<TaskDto> result = tasks.Select(t => new TaskDto
        {
            Id = t.Id,
            WorkId = t.WorkId,
            TaskName = t.TaskName,
            Status = t.Status
        });

        return Ok(result);
    }

    // GET api/tasks/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var task = await _taskRepository.GetByIdAsync(id);
        if (task == null)
            return NotFound();

        return Ok(task);
    }

    // POST api/tasks
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateTaskDto taskDto)
    {
        var task = new DomainTask
        {
            WorkId = taskDto.WorkId,
            TaskName = taskDto.TaskName,
            Status = taskDto.Status
        };

        var id = await _taskRepository.CreateAsync(task);

        return StatusCode(201,
            new TaskDto
            {
                Id = id,
                WorkId = taskDto.WorkId,
                TaskName = taskDto.TaskName,
                Status = taskDto.Status
            });
    }

    // PUT api/tasks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateTaskDto taskDto)
    {
        var task = new DomainTask
        {
            Id = id,
            TaskName = taskDto.TaskName,
            Status = taskDto.Status
        };

        if (id != task.Id)
            return BadRequest("Route id and body id do not match.");

        var success = await _taskRepository.UpdateAsync(task);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/tasks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _taskRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
