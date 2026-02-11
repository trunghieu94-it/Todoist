using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface INoteRepository
{
    Task<IEnumerable<Note>> GetAllAsync();
    Task<Note?> GetByIdAsync(int id);
    Task<int> CreateAsync(Note note);
    Task<bool> UpdateAsync(Note note);
    Task<bool> DeleteAsync(int id);
}
