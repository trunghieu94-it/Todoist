using System.Collections.Generic;
using System.Threading.Tasks;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Services
{
    public class TodoItemsService
    {
        private readonly ApiClient _apiClient;

        private TodoItemsService()
        {
            _apiClient = new ApiClient();
        }

        public static TodoItemsService Instance { get; } = new TodoItemsService();

        private List<TodoItem> _items = new List<TodoItem>();

        //public event Action<List<TodoItem>> OnItemsChanged;
        //public event Action<TodoItem> OnItemSelected;

        #region Events
        public async Task<List<TodoItem>> GetTodoItemsAsync(int listId)
        {
            return await _apiClient.GetAsync<List<TodoItem>>($"todolists/{listId}/todoitems")
                ?? new List<TodoItem>();
        }
        #endregion
    }
}
