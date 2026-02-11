using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly IDbConnection _connection;

        public TodoItemRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            var sql = $@"
            SELECT
                Id,
                TodoListId, 
                Title,
                ItemStatus,
                CreatedAt 
            FROM {DbTables.TodoItems}
            ";
            return await _connection.QueryAsync<TodoItem>(sql);
        }

        public async Task<TodoItem?> GetByIdAsync(int id)
        {
            var sql = $@"
            SELECT 
                Id,
                TodoListId, 
                Title,
                ItemStatus,
                CreatedAt
            FROM {DbTables.TodoItems} 
            WHERE Id = @Id
            ";
            return await _connection.QueryFirstOrDefaultAsync<TodoItem>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(TodoItem task)
        {
            var sql = $@"
            INSERT INTO {DbTables.TodoItems} 
            (
                TodoListId, 
                Title,
                ItemStatus,
                CreatedAt
            )
            VALUES 
            (
                @TodoListId, 
                @Title,
                @ItemStatus,
                @CreatedAt
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, task);
        }

        public async Task<bool> UpdateAsync(TodoItem task)
        {
            var sql = $@"
            UPDATE {DbTables.TodoItems}
            SET 
                Title = @Title,
                ItemStatus = @ItemStatus,
                CreatedAt = @CreatedAt
            WHERE Id = @Id
            ";

            var rows = await _connection.ExecuteAsync(sql, task);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.TodoItems} 
            WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
