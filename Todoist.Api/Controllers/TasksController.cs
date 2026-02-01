using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Task;
using Todoist.Infrastructure.Repositories.Task;

[ApiController]
[Route("api/[controller]")] // controller = Tasks
public class TasksController : ControllerBase
{
    private readonly ITaskRepository _taskRepository;
    
    public TasksController(ITaskRepository userRepository)
    {
        _taskRepository = userRepository;
    }

    // GET api/users
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

    // GET api/users/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var task = await _taskRepository.GetByIdAsync(id);
        if (task == null)
            return NotFound();

        return Ok(task);
    }

    // POST api/users
    [HttpPost]
    public async Task<IActionResult> CreateAsync(DomainTask task)
    {
        var id = await _taskRepository.CreateAsync(task);
        task.Id = id;

        return CreatedAtAction(nameof(GetByIdAsync), new { id }, task);
    }

    // PUT api/users/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, DomainTask task)
    {
        if (id != task.Id)
            return BadRequest();

        var success = await _taskRepository.UpdateAsync(task);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/users/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _taskRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
