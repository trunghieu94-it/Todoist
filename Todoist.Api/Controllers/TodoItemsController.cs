using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Task;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api/todoitems")]
public class TodoItemsController : ControllerBase
{
    private readonly ITodoItemRepository _todoItemRepository;

    public TodoItemsController(ITodoItemRepository taskRepository)
    {
        _todoItemRepository = taskRepository;
    }

    // GET api/todoitems
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var items = await _todoItemRepository.GetAllAsync();

        IEnumerable<TodoItemDto> result = items.Select(i => new TodoItemDto
        {
            Id = i.Id,
            TodoListId = i.TodoListId,
            Title = i.Title,
            ItemStatus = i.ItemStatus,
            CreatedAt = i.CreatedAt
        });

        return Ok(result);
    }

    // GET api/todoitems/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var item = await _todoItemRepository.GetByIdAsync(id);
        if (item == null)
            return NotFound();

        var result = new TodoItemDto
        {
            Id = item.Id,
            TodoListId = item.TodoListId,
            Title = item.Title,
            ItemStatus = item.ItemStatus,
            CreatedAt = item.CreatedAt
        };

        return Ok(result);
    }

    // POST api/todoitems
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateTodoItemDto itemDto)
    {
        var item = new TodoItem
        {
            TodoListId = itemDto.TodoListId,
            Title = itemDto.Title,
            ItemStatus = itemDto.ItemStatus,
            CreatedAt = itemDto.CreatedAt
        };

        var id = await _todoItemRepository.CreateAsync(item);

        return StatusCode(201,
            new TodoItemDto
            {
                Id = id,
                TodoListId = itemDto.TodoListId,
                Title = itemDto.Title,
                ItemStatus = itemDto.ItemStatus,
                CreatedAt = itemDto.CreatedAt
            });
    }

    // PUT api/todoitems/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateTodoItemDto itemDto)
    {
        var item = new TodoItem
        {
            Id = id,
            Title = itemDto.Title,
            ItemStatus = itemDto.ItemStatus,
            CreatedAt = itemDto.CreatedAt
        };

        if (id != item.Id)
            return BadRequest("Route id and body id do not match.");

        var success = await _todoItemRepository.UpdateAsync(item);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/todoitems/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _todoItemRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
