using Microsoft.AspNetCore.Mvc;

using Todoist.Domain.Dtos.Note;
using Todoist.Domain.Entities;
using Todoist.Infrastructure.Repositories;

[ApiController]
[Route("api/notes")]
public class NotesController : ControllerBase
{
    private readonly INoteRepository _noteRepository;

    public NotesController(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    // GET api/notes
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var notes = await _noteRepository.GetAllAsync();

        IEnumerable<NoteDto> result = notes.Select(n => new NoteDto
        {
            Id = n.Id,
            UserId = n.UserId,
            TodoListId = n.TodoListId,
            Title = n.Title,
            NoteContent = n.NoteContent,
            CreatedAt = n.CreatedAt,
            UpdatedAt = n.UpdatedAt
        });

        return Ok(result);
    }

    // GET api/notes/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var note = await _noteRepository.GetByIdAsync(id);
        if (note == null)
            return NotFound();

        var result = new NoteDto
        {
            Id = note.Id,
            UserId = note.UserId,
            TodoListId = note.TodoListId,
            Title = note.Title,
            NoteContent = note.NoteContent,
            CreatedAt = note.CreatedAt,
            UpdatedAt = note.UpdatedAt
        };

        return Ok(result);
    }

    // POST api/notes
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateNoteDto noteDto)
    {
        var note = new Note
        {
            UserId = noteDto.UserId,
            TodoListId = noteDto.TodoListId,
            Title = noteDto.Title,
            NoteContent = noteDto.NoteContent,
            UpdatedAt = noteDto.UpdatedAt
        };

        var id = await _noteRepository.CreateAsync(note);

        return StatusCode(201,
            new NoteDto
            {
                Id = id,
                UserId = noteDto.UserId,
                TodoListId = noteDto.TodoListId,
                Title = noteDto.Title,
                NoteContent = noteDto.NoteContent,
                UpdatedAt = noteDto.UpdatedAt,
            });
    }

    // PUT api/notes/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateNoteDto noteDto)
    {
        var note = new Note
        {
            Id = id,
            Title = noteDto.Title,
            NoteContent = noteDto.NoteContent,
            UpdatedAt = noteDto.UpdatedAt
        };

        if (id != note.Id)
            return BadRequest("Route id and body id do not match.");

        var success = await _noteRepository.UpdateAsync(note);
        if (!success)
            return NotFound();

        return NoContent();
    }

    // DELETE api/notes/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var success = await _noteRepository.DeleteAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }
}
