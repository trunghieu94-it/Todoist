using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.TodoListTag;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api")]
public class TodoListTagsController : ControllerBase
{
    private readonly ITodoListTagRepository _todoListTagRepository;

    public TodoListTagsController(ITodoListTagRepository todoListTagRepository)
    {
        _todoListTagRepository = todoListTagRepository;
    }

    // GET api/todolist-tags
    [HttpGet("todolist-tags")]
    public async Task<IActionResult> GetAllAsync()
    {
        var userTodoLists = await _todoListTagRepository.GetAllAsync();

        IEnumerable<TodoListTagDto> result = userTodoLists.Select(l => new TodoListTagDto
        {
            TodoListId = l.TodoListId,
            TagId = l.TagId,
            CreatedAt = l.CreatedAt
        });

        return Ok(result);
    }

    // GET api/todolists/{todoListId}/tags/{tagId}
    [HttpGet("todolists/{todoListId}/tags/{tagId}")]
    public async Task<IActionResult> GetAsync(int todoListId, int tagId)
    {
        var list = await _todoListTagRepository.GetAsync(todoListId, tagId);

        if (list == null)
            return NotFound();

        var resutl = new TodoListTagDto
        {
            TodoListId = list.TodoListId,
            TagId = list.TagId,
            CreatedAt = list.CreatedAt
        };

        return Ok(resutl);
    }

    // GET api/todolists/{todoListId}/tags
    [HttpGet("todolists/{todoListId}/tags")]
    public async Task<IActionResult> GetByTodoListIdAsync(int todoListId)
    {
        var userTodoLists = await _todoListTagRepository.GetByTodoListIdAsync(todoListId);

        IEnumerable<TodoListTagDto> result = userTodoLists.Select(l => new TodoListTagDto
        {
            TodoListId = l.TodoListId,
            TagId = l.TagId,
            CreatedAt = l.CreatedAt
        });

        return Ok(result);
    }

    // GET api/tags/{tagId}/todolists
    [HttpGet("tags/{tagId}/todolists")]
    public async Task<IActionResult> GetByTagIdAsync(int tagId)
    {
        var userTodoLists = await _todoListTagRepository.GetByTagIdAsync(tagId);

        IEnumerable<TodoListTagDto> result = userTodoLists.Select(l => new TodoListTagDto
        {
            TodoListId = l.TodoListId,
            TagId = l.TagId,
            CreatedAt = l.CreatedAt
        });

        return Ok(result);
    }

    // POST api/todolist-tags
    [HttpPost("todolist-tags")]
    public async Task<IActionResult> CreateAsync(CreateTodoListTagDto todoListTagDto)
    {
        var todoListTag = new TodoListTag
        {
            TodoListId = todoListTagDto.TodoListId,
            TagId = todoListTagDto.TagId
        };

        await _todoListTagRepository.CreateAsync(todoListTag);

        return NoContent();
    }

    // DELETE api/todolists/{todoListId}/tags/{tagId}
    [HttpDelete("todolists/{todoListId}/tags/{tagId}")]
    public async Task<IActionResult> DeleteAsync(int todoListId, int tagId)
    {
        var success = await _todoListTagRepository.DeleteAsync(todoListId, tagId);

        if (!success)
            return NotFound();

        return NoContent();
    }
}
