using System.Data;

using Dapper;

using Todoist.Domain.Entities;
using Todoist.Infrastructure.Data.Constants;

namespace Todoist.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _connection;

        public UserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var sql = $@"
            SELECT
                Id,
                UserName,
                PasswordHash,
                CreatedAt
            FROM {DbTables.Users}
            ";
            return await _connection.QueryAsync<User>(sql);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            var sql = $@"
            SELECT 
                Id,
                UserName,
                PasswordHash,
                CreatedAt
            FROM {DbTables.Users} 
            WHERE Id = @Id
            ";
            return await _connection.QueryFirstOrDefaultAsync<User>(sql, new { Id = id });
        }

        public async Task<int> CreateAsync(User user)
        {
            var sql = $@"
            INSERT INTO {DbTables.Users} 
            (
                UserName,
                PasswordHash
            )
            VALUES 
            (
                @UserName,
                @PasswordHash
            );
            SELECT 
                CAST(SCOPE_IDENTITY() as int);
            ";
            return await _connection.ExecuteScalarAsync<int>(sql, user);
        }

        public async Task<bool> UpdateAsync(User user)
        {
            var sql = $@"
            UPDATE {DbTables.Users}
            SET 
                PasswordHash = @PasswordHash
            WHERE Id = @Id
            ";

            var rows = await _connection.ExecuteAsync(sql, user);
            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sql = $@"
            DELETE 
            FROM {DbTables.Users} 
            WHERE Id = @Id";
            var rows = await _connection.ExecuteAsync(sql, new { Id = id });
            return rows > 0;
        }
    }
}
