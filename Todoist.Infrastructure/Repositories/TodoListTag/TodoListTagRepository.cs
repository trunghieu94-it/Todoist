using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class TodoListTagRepository : ITodoListTagRepository
    {
        private readonly IDbConnection _connection;

        public TodoListTagRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<TodoListTag>> GetAllAsync()
        {
            var sql = $@"
            SELECT
                TodoListId,
                TagId,
                CreatedAt
            FROM {DbTables.TodoListTags}
            ";
            return await _connection.QueryAsync<TodoListTag>(sql);
        }

        public async Task<TodoListTag?> GetAsync(int todoListId, int tagId)
        {
            var sql = $@"
            SELECT 
                TodoListId,
                TagId,
                CreatedAt
            FROM {DbTables.TodoListTags} 
            WHERE
                TodoListId = @TodoListId
            AND
                TagId = @TagId

            ";
            return await _connection.QueryFirstOrDefaultAsync<TodoListTag>(
                sql, new
                {
                    TodoListId = todoListId,
                    TagId = tagId
                }
            );
        }

        public async Task<IEnumerable<TodoListTag>> GetByTodoListIdAsync(int todoListId)
        {
            var sql = $@"
            SELECT 
                TodoListId,
                TagId,
                CreatedAt
            FROM {DbTables.TodoListTags} 
            WHERE
                TodoListId = @TodoListId
            ";
            return await _connection.QueryAsync<TodoListTag>(sql, new { TodoListId = todoListId });
        }

        public async Task<IEnumerable<TodoListTag>> GetByTagIdAsync(int tagId)
        {
            var sql = $@"
            SELECT 
                TodoListId,
                TagId,
                CreatedAt
            FROM {DbTables.TodoListTags} 
            WHERE
                TagId = @TagId
            ";
            return await _connection.QueryAsync<TodoListTag>(sql, new { TagId = tagId });
        }

        public async Task<int> CreateAsync(TodoListTag todoListTag)
        {
            var sql = $@"
            INSERT INTO {DbTables.TodoListTags} 
            (
                TodoListId,
                TagId
            )
            VALUES 
            (
                @TodoListId,
                @TagId
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, todoListTag);
        }

        public async Task<bool> DeleteAsync(int todoListId, int tagId)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.TodoListTags} 
            WHERE
                TodoListId = @TodoListId
            AND
                TagId = @TagId
            ";
            var rows = await _connection.ExecuteAsync(
                sql, new
                {
                    TodoListId = todoListId,
                    TagId = tagId
                }
            );
            return rows > 0;
        }
    }
}
