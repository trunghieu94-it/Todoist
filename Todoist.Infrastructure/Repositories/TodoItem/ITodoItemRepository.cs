using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface ITodoItemRepository
{
    Task<IEnumerable<TodoItem>> GetAllAsync();
    Task<IEnumerable<TodoItem>> GetByListIdAsync(int listId);
    Task<int> CreateAsync(TodoItem item);
    Task<bool> UpdateAsync(TodoItem item);
    Task<bool> DeleteAsync(int id);

    //Task<TodoItem?> GetByIdAsync(int id);
}
