using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Tag;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api/tags")]
public class TagsController : ControllerBase
{
    private readonly ITagRepository _tagRepository;

    public TagsController(ITagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    // GET api/tags
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tags = await _tagRepository.GetAllAsync();

        IEnumerable<TagDto> result = tags.Select(t => new TagDto
        {
            Id = t.Id,
            UserId = t.UserId,
            TagName = t.TagName,
            CreatedAt = t.CreatedAt
        });

        return Ok(result);
    }

    // GET api/tags/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var tag = await _tagRepository.GetByIdAsync(id);
        if (tag == null)
            return NotFound();

        var result = new TagDto
        {
            Id = tag.Id,
            UserId = tag.UserId,
            TagName = tag.TagName,
            CreatedAt = tag.CreatedAt
        };

        return Ok(result);
    }

    // POST api/tags
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateTagDto tagDto)
    {
        var tag = new Tag
        {
            UserId = tagDto.UserId,
            TagName = tagDto.TagName
        };

        var id = await _tagRepository.CreateAsync(tag);

        return StatusCode(201,
            new TagDto
            {
                Id = id,
                UserId = tagDto.UserId,
                TagName = tagDto.TagName,
            });
    }

    // DELETE api/tags/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _tagRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
