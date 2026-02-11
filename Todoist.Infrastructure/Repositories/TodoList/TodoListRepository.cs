using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class TodoListRepository : ITodoListRepository
    {
        private readonly IDbConnection _connection;

        public TodoListRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<TodoList>> GetAllAsync()
        {
            var sql = $@"
            SELECT 
                Id,
                UserId,
                ListName, 
                ListPriority, 
                ListStatus,
                Deadline,
                CreatedAt,
                UpdatedAt
            FROM {DbTables.TodoLists}";
            return await _connection.QueryAsync<TodoList>(sql);
        }

        public async Task<TodoList?> GetByIdAsync(int id)
        {
            var sql = $@"
            SELECT
                Id,
                UserId,
                ListName, 
                ListPriority, 
                ListStatus,
                Deadline,
                CreatedAt,
                UpdatedAt
            FROM {DbTables.TodoLists} 
            WHERE Id = @Id";
            return await _connection.QueryFirstOrDefaultAsync<TodoList>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(TodoList list)
        {
            var sql = $@"
            INSERT INTO {DbTables.TodoLists}
            (
                UserId,
                ListName, 
                ListPriority, 
                ListStatus,
                Deadline,
                UpdatedAt
            )
            VALUES 
            (
                @UserId,
                @ListName, 
                @ListPriority, 
                @ListStatus,
                @Deadline,
                NULL
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, list);
        }

        public async Task<bool> UpdateAsync(TodoList list)
        {
            var sql = $@"
            UPDATE {DbTables.TodoLists}
            SET 
                ListName = @ListName, 
                ListPriority = @ListPriority, 
                ListStatus = @ListStatus,
                Deadline = @Deadline,
                UpdatedAt = SYSDATETIME()
            WHERE Id = @Id
            ";

            var rows = await _connection.ExecuteAsync(sql, list);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.TodoLists} 
            WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
