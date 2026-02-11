using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories;

public interface IUserTodoListRepository
{
    Task<IEnumerable<UserTodoList>> GetAllAsync();
    Task<UserTodoList?> GetAsync(int userId, int todoListId);
    Task<IEnumerable<UserTodoList>> GetByUserIdAsync(int userId);
    Task<IEnumerable<UserTodoList>> GetByTodoListIdAsync(int todoListId);
    Task CreateAsync(UserTodoList useTodoList);
    Task<bool> UpdateAsync(UserTodoList userTodoList);
    Task<bool> DeleteAsync(int userId, int todoListId);
}
