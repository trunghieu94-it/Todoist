using Todoist.Domain.Entities;
using Todoist.Domain.Enums;

namespace Todoist.Infrastructure.Repositories;

public interface ITodoListRepository
{
    Task<IEnumerable<TodoList>> GetAllAsync();
    Task<TodoList?> GetByIdAsync(int id);
    Task<IEnumerable<TodoList>> GetByFilterAsync(TodoListStatus? status, bool? hasDeadline);
    Task<int> CreateAsync(TodoList list);
    Task<bool> UpdateAsync(TodoList list);
    Task<bool> DeleteAsync(int id);
}
