using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class UserTodoListRepository : IUserTodoListRepository
    {
        private readonly IDbConnection _connection;

        public UserTodoListRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<UserTodoList>> GetAllAsync()
        {
            var sql = $@"
            SELECT 
                UserId,
                TodoListId,
                UserRole,
                CreatedAt
            FROM {DbTables.UserTodoLists}";
            return await _connection.QueryAsync<UserTodoList>(sql);
        }

        public async Task<UserTodoList?> GetAsync(int userId, int todoListId)
        {
            var sql = $@"
            SELECT 
                UserId,
                TodoListId,
                UserRole,
                CreatedAt
            FROM {DbTables.UserTodoLists} 
            WHERE 
                UserId = @UserId 
            AND
                TodoListId = @TodoListId
            ";
            return await _connection.QueryFirstOrDefaultAsync<UserTodoList>(
                sql, new
                {
                    UserId = userId,
                    TodoListId = todoListId
                }
            );
        }

        public async Task<IEnumerable<UserTodoList>> GetByUserIdAsync(int id)
        {
            var sql = $@"
            SELECT
                UserId,
                TodoListId,
                UserRole,
                CreatedAt
            FROM {DbTables.UserTodoLists} 
            WHERE 
                UserId = @UserId
            ";
            return await _connection.QueryAsync<UserTodoList>(sql, new { UserId = id });
        }

        public async Task<IEnumerable<UserTodoList>> GetByTodoListIdAsync(int id)
        {
            var sql = $@"
            SELECT
                UserId,
                TodoListId,
                UserRole,
                CreatedAt
            FROM {DbTables.UserTodoLists} 
            WHERE 
                TodoListId = @TodoListId 
            ";
            return await _connection.QueryAsync<UserTodoList>(sql, new { TodoListId = id });
        }

        public async Task CreateAsync(UserTodoList userTodoList)
        {
            var sql = $@"
            INSERT INTO {DbTables.UserTodoLists}
            (
                UserId,
                TodoListId,
                UserRole,
                CreatedAt
            )
            VALUES 
            (
                @UserId,
                @TodoListId,
                @UserRole,
                SYSUTCDATETIME()
            )
            ";

            await _connection.ExecuteAsync(sql, new
            {
                userTodoList.UserId,
                userTodoList.TodoListId,
                userTodoList.UserRole,
            });
        }

        public async Task<bool> UpdateAsync(UserTodoList userTodoList)
        {
            var sql = $@"
            UPDATE {DbTables.UserTodoLists}
            SET 
                UserId = @UserId,
                TodoListId = @TodoListId,
                UserRole = @UserRole
            WHERE 
                UserId = @UserId
            AND
                TodoListId = @TodoListId
            ";

            var rows = await _connection.ExecuteAsync(sql, userTodoList);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int userId, int todoListId)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.UserTodoLists} 
            WHERE 
                UserId = @UserId
            AND
                TodoListId = @TodoListId
            ";
            var rows = await _connection.ExecuteAsync(
                sql,
                new
                {
                    UserId = userId,
                    TodoListId = todoListId
                }
            );
            return rows > 0;
        }
    }
}
