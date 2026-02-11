using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface ITodoListRepository
{
    Task<IEnumerable<TodoList>> GetAllAsync();
    Task<TodoList?> GetByIdAsync(int id);
    Task<int> CreateAsync(TodoList list);
    Task<bool> UpdateAsync(TodoList list);
    Task<bool> DeleteAsync(int id);
}
