using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly IDbConnection _connection;

        public TagRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            var sql = $@"
            SELECT
                Id,
                UserId,
                TagName,
                CreatedAt
            FROM {DbTables.Tags}
            ";
            return await _connection.QueryAsync<Tag>(sql);
        }

        public async Task<Tag?> GetByIdAsync(int id)
        {
            var sql = $@"
            SELECT 
                Id,
                UserId,
                TagName,
                CreatedAt
            FROM {DbTables.Tags} 
            WHERE Id = @Id
            ";
            return await _connection.QueryFirstOrDefaultAsync<Tag>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(Tag tag)
        {
            var sql = $@"
            INSERT INTO {DbTables.Tags} 
            (
                UserId,
                TagName
            )
            VALUES 
            (
                @UserId,
                @TagName
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, tag);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.Tags} 
            WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
