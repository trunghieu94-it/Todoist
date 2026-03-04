using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface ITodoListTagRepository
{
    Task<IEnumerable<TodoListTag>> GetAllAsync();
    Task<TodoListTag?> GetAsync(int todoListId, int tagId);
    Task<IEnumerable<TodoListTag>> GetByTodoListIdAsync(int todoListId);
    Task<IEnumerable<TodoListTag>> GetByTagIdAsync(int tagId);
    Task<int> CreateAsync(TodoListTag todoListTag);
    Task<bool> DeleteAsync(int todoListId, int tagId);
}
