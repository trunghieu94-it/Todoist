using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.UserWork;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api")]
public class UserTodoListsController : ControllerBase
{
    private readonly IUserTodoListRepository _userTodoListRepository;

    public UserTodoListsController(IUserTodoListRepository userTodoListRepository)
    {
        _userTodoListRepository = userTodoListRepository;
    }

    // GET api/user-todolists
    [HttpGet("user-todolists")]
    public async Task<IActionResult> GetAllAsync()
    {
        var userTodoLists = await _userTodoListRepository.GetAllAsync();

        IEnumerable<UserTodoListDto> result = userTodoLists.Select(l => new UserTodoListDto
        {
            UserId = l.UserId,
            TodoListId = l.TodoListId,
            UserRole = l.UserRole,
            CreatedAt = l.CreatedAt
        });

        return Ok(result);
    }

    // GET api/users/{userId}/todolists/{todoListId}
    [HttpGet("users/{userId}/todolists/{todoListId}")]
    public async Task<IActionResult> GetAsync(int userId, int todoListId)
    {
        var list = await _userTodoListRepository.GetAsync(userId, todoListId);

        if (list == null)
            return NotFound();

        var resutl = new UserTodoListDto
        {
            UserId = list.UserId,
            TodoListId = list.TodoListId,
            UserRole = list.UserRole,
            CreatedAt = list.CreatedAt
        };

        return Ok(resutl);
    }

    // GET api/users/{userId}/todolists
    [HttpGet("users/{userId}/todolists")]
    public async Task<IActionResult> GetByUserIdAsync(int userId)
    {
        var userTodoLists = await _userTodoListRepository.GetByUserIdAsync(userId);

        IEnumerable<UserTodoListDto> result = userTodoLists.Select(l => new UserTodoListDto
        {
            UserId = l.UserId,
            TodoListId = l.TodoListId,
            UserRole = l.UserRole,
            CreatedAt = l.CreatedAt
        });

        return Ok(result);
    }

    // GET api/todolists/{todoListId}/users
    [HttpGet("todolists/{todoListId}/users")]
    public async Task<IActionResult> GetByTodoListIdAsync(int todoListId)
    {
        var userTodoLists = await _userTodoListRepository.GetByTodoListIdAsync(todoListId);

        IEnumerable<UserTodoListDto> result = userTodoLists.Select(l => new UserTodoListDto
        {
            UserId = l.UserId,
            TodoListId = l.TodoListId,
            UserRole = l.UserRole,
            CreatedAt = l.CreatedAt
        });

        return Ok(result);
    }

    // POST api/user-todolists
    [HttpPost("user-todolists")]
    public async Task<IActionResult> CreateAsync(CreateUserTodoListDto userWorkDto)
    {
        var userTodoList = new UserTodoList
        {
            UserId = userWorkDto.UserId,
            TodoListId = userWorkDto.TodoListId,
            UserRole = userWorkDto.UserRole
        };

        await _userTodoListRepository.CreateAsync(userTodoList);

        return NoContent();
    }

    // PUT api/users/{userId}/todolists/{todoListId}
    [HttpPut("users/{userId}/todolists/{todoListId}")]
    public async Task<IActionResult> UpdateAsync(
        int userId,
        int todoListId,
        UpdateUserTodoListDto userWorkDto
    )
    {
        var userTodoList = new UserTodoList
        {
            UserId = userId,
            TodoListId = todoListId,
            UserRole = userWorkDto.UserRole,
        };

        if (userId != userTodoList.UserId || todoListId != userTodoList.TodoListId)
            return BadRequest("Route id and body id do not match.");

        var success = await _userTodoListRepository.UpdateAsync(userTodoList);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/users/{userId}/todolists/{todoListId}
    [HttpDelete("users/{userId}/todolists/{todoListId}")]
    public async Task<IActionResult> DeleteAsync(int userId, int todoListId)
    {
        var success = await _userTodoListRepository.DeleteAsync(userId, todoListId);

        if (!success)
            return NotFound();

        return NoContent();
    }
}
