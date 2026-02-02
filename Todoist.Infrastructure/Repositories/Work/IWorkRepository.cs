using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface IWorkRepository
{
    Task<IEnumerable<Work>> GetAllAsync();
    Task<Work?> GetByIdAsync(int id);
    Task<int> CreateAsync(Work work);
    Task<bool> UpdateAsync(Work work);
    Task<bool> DeleteAsync(int id);
}
