using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Work;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api/todolists")]
public class TodoListsController : ControllerBase
{
    private readonly ITodoListRepository _todoListRepository;

    public TodoListsController(ITodoListRepository todoListRepository)
    {
        _todoListRepository = todoListRepository;
    }

    // GET api/todolists
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var lists = await _todoListRepository.GetAllAsync();

        IEnumerable<TodoListDto> result = lists.Select(l => new TodoListDto
        {
            Id = l.Id,
            ListName = l.ListName,
            ListPriority = l.ListPriority,
            ListStatus = l.ListStatus,
            Deadline = l.Deadline,
            CreatedAt = l.CreatedAt,
            UpdatedAt = l.UpdatedAt
        });

        return Ok(result);
    }

    // GET api/todolist/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var list = await _todoListRepository.GetByIdAsync(id);
        if (list == null)
            return NotFound();

        var result = new TodoListDto
        {
            Id = list.Id,
            ListName = list.ListName,
            Deadline = list.Deadline,
            ListPriority = list.ListPriority,
            ListStatus = list.ListStatus,
            CreatedAt = list.CreatedAt,
            UpdatedAt = list.UpdatedAt
        };

        return Ok(result);
    }

    // POST api/todolist/{id}
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateTodoListDto listDto)
    {
        var list = new TodoList
        {
            UserId = listDto.UserId,
            ListName = listDto.ListName,
            ListPriority = listDto.ListPriority,
            ListStatus = listDto.ListStatus,
            Deadline = listDto.Deadline
        };

        var id = await _todoListRepository.CreateAsync(list);

        return StatusCode(201,
            new TodoListDto
            {
                Id = id,
                ListName = listDto.ListName,
                ListPriority = listDto.ListPriority,
                ListStatus = listDto.ListStatus,
                Deadline = listDto.Deadline
            });
    }

    // PUT api/todolist/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateTodoListDto listDto)
    {
        var list = new TodoList
        {
            Id = id,
            ListName = listDto.ListName,
            ListPriority = listDto.ListPriority,
            ListStatus = listDto.ListStatus,
            Deadline = listDto.Deadline,
        };

        if (id != list.Id)
            return BadRequest("Route id and body id do not match.");

        var success = await _todoListRepository.UpdateAsync(list);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/todolist/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _todoListRepository.DeleteAsync(id);

        if (!success)
            return NotFound();

        return NoContent();
    }
}
