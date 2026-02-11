using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly IDbConnection _connection;

        public NoteRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            var sql = $@"
            SELECT
                Id,
                UserId,
                TodoListId, 
                Title,
                NoteContent,
                CreatedAt,
                UpdatedAt
            FROM {DbTables.Notes}
            ";
            return await _connection.QueryAsync<Note>(sql);
        }

        public async Task<Note?> GetByIdAsync(int id)
        {
            var sql = $@"
            SELECT 
                Id,
                UserId,
                TodoListId, 
                Title,
                NoteContent,
                CreatedAt,
                UpdatedAt
            FROM {DbTables.Notes} 
            WHERE Id = @Id
            ";
            return await _connection.QueryFirstOrDefaultAsync<Note>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(Note task)
        {
            var sql = $@"
            INSERT INTO {DbTables.Notes} 
            (
                UserId,
                TodoListId, 
                Title,
                NoteContent,
                UpdatedAt
            )
            VALUES 
            (
                @UserId,
                @TodoListId,
                @Title,
                @NoteContent,
                @UpdatedAt
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, task);
        }

        public async Task<bool> UpdateAsync(Note task)
        {
            var sql = $@"
            UPDATE {DbTables.Notes}
            SET 
                Title = @Title,
                NoteContent = @NoteContent,
                UpdatedAt = SYSDATETIME()
            WHERE Id = @Id
            ";

            var rows = await _connection.ExecuteAsync(sql, task);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.Notes} 
            WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
