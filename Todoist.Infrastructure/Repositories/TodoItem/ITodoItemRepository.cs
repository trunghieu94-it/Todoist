using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface ITodoItemRepository
{
    Task<IEnumerable<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(int id);
    Task<int> CreateAsync(TodoItem item);
    Task<bool> UpdateAsync(TodoItem item);
    Task<bool> DeleteAsync(int id);
}
