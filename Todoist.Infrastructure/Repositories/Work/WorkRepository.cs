using System.Data;

using Dapper;

using Todoist.Domain.Entities;

namespace Todoist.Infrastructure.Repositories
{
    public class WorkRepository : IWorkRepository
    {
        private readonly IDbConnection _connection;

        public WorkRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Work>> GetAllAsync()
        {
            var sql = @"
            SELECT 
                Id, 
                WorkName, 
                Deadline, 
                Progress,
                Priority,
                Status
            FROM dbo.Works";
            return await _connection.QueryAsync<Work>(sql);
        }

        public async Task<Work?> GetByIdAsync(int id)
        {
            var sql = @"
            SELECT
                Id, 
                WorkName, 
                Deadline, 
                Progress,
                Priority,
                Status
            FROM dbo.Works 
            WHERE Id = @Id";
            return await _connection.QueryFirstOrDefaultAsync<Work>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(Work work)
        {
            var sql = @"
            INSERT INTO dbo.Works
            (
                WorkName, 
                Deadline, 
                Progress,
                Priority,
                Status
            )
            VALUES 
            (
                @WorkName, 
                @Deadline, 
                @Progress,
                @Priority,
                @Status
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, work);
        }

        public async Task<bool> UpdateAsync(Work work)
        {
            var sql = @"
            UPDATE dbo.Works
            SET 
                WorkName = @WorkName, 
                Deadline = @Deadline, 
                Progress = @Progress,
                Priority = @Priority,
                Status = @Status
            WHERE Id = @Id
            ";

            var rows = await _connection.ExecuteAsync(sql, work);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = @"
            DELETE 
            FROM dbo.Works 
            WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
