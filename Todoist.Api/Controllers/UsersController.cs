using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.User;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // GET api/users
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _userRepository.GetAllAsync();

        IEnumerable<UserBaseDto> result = users.Select(u => new UserBaseDto
        {
            UserName = u.UserName,
            PasswordHash = u.PasswordHash
        });

        return Ok(result);
    }

    // GET api/users/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
            return NotFound();

        return Ok(user);
    }

    // POST api/users
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateUserDto userDto)
    {
        var user = new User
        {
            UserName = userDto.UserName,
            PasswordHash = userDto.PasswordHash
        };

        var id = await _userRepository.CreateAsync(user);

        return StatusCode(201,
            new UserBaseDto
            {
                UserName = userDto.UserName,
                PasswordHash = userDto.PasswordHash
            });
    }

    // PUT api/users/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateUserDto itemDto)
    {
        var user = new User
        {
            Id = id,
            PasswordHash = itemDto.PasswordHash
        };

        if (id != user.Id)
            return BadRequest("Route id and body id do not match.");

        var success = await _userRepository.UpdateAsync(user);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/users/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _userRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
