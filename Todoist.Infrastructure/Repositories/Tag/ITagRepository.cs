using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface ITagRepository
{
    Task<IEnumerable<Tag>> GetAllAsync();
    Task<Tag?> GetByIdAsync(int id);
    Task<int> CreateAsync(Tag tag);
    Task<bool> DeleteAsync(int id);
}
