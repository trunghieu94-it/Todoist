using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Work;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api/works")]
public class WorksController : ControllerBase
{
    private readonly IWorkRepository _workRepository;

    public WorksController(IWorkRepository workRepository)
    {
        _workRepository = workRepository;
    }

    // GET api/works
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var works = await _workRepository.GetAllAsync();

        IEnumerable<WorkDto> result = works.Select(w => new WorkDto
        {
            Id = w.Id,
            WorkName = w.WorkName,
            Deadline = w.Deadline,
            Progress = w.Progress,
            Priority = w.Priority,
            Status = w.Status
        });

        return Ok(result);
    }

    // GET api/works/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var work = await _workRepository.GetByIdAsync(id);
        if (work == null)
            return NotFound();

        return Ok(work);
    }

    // POST api/works
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateWorkDto workDto)
    {
        var work = new Work
        {
            WorkName = workDto.WorkName,
            Deadline = workDto.Deadline,
            Progress = workDto.Progress,
            Priority = workDto.Priority,
            Status = workDto.Status
        };

        var id = await _workRepository.CreateAsync(work);

        return StatusCode(201,
            new WorkDto
            {
                Id = id,
                WorkName = workDto.WorkName,
                Deadline = workDto.Deadline,
                Progress = workDto.Progress,
                Priority = workDto.Priority,
                Status = workDto.Status
            });
    }

    // PUT api/works/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateWorkDto workDto)
    {
        var work = new Work
        {
            Id = id,
            WorkName = workDto.WorkName,
            Deadline = workDto.Deadline,
            Progress = workDto.Progress,
            Priority = workDto.Priority,
            Status = workDto.Status
        };

        if (id != work.Id)
            return BadRequest("Route id and body id do not match.");

        var success = await _workRepository.UpdateAsync(work);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/works/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _workRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}