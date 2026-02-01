namespace Todoist.Infrastructure.Repositories.Task
{
    public interface ITaskRepository
    {
        Task<IEnumerable<DomainTask>> GetAllAsync();
        Task<DomainTask?> GetByIdAsync(int id);
        Task<int> CreateAsync(DomainTask task);
        Task<bool> UpdateAsync(DomainTask task);
        Task<bool> DeleteAsync(int id);
    }
}
