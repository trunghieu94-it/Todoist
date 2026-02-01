using System.Data;

using Dapper;

namespace Todoist.Infrastructure.Repositories.Task
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IDbConnection _connection;

        public TaskRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<DomainTask>> GetAllAsync()
        {
            var sql = "select Id, WorkId, TaskName, [Status] from Tasks";
            return await _connection.QueryAsync<DomainTask>(sql);
        }

        public async Task<DomainTask?> GetByIdAsync(int id)
        {
            var sql = "SELECT Id, Name, Email FROM Users WHERE Id = @Id";
            return await _connection.QueryFirstOrDefaultAsync<DomainTask>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(DomainTask task)
        {
            var sql = @"
            INSERT INTO Users (Name, Email)
            VALUES (@Name, @Email);
            SELECT CAST(SCOPE_IDENTITY() as int);
        ";

            return await _connection.ExecuteScalarAsync<int>(sql, task);
        }

        public async Task<bool> UpdateAsync(DomainTask task)
        {
            var sql = @"
            UPDATE Users
            SET Name = @Name,
                Email = @Email
            WHERE Id = @Id
        ";

            var rows = await _connection.ExecuteAsync(sql, task);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Users WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
