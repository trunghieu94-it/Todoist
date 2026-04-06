using System.Collections.Generic;
using System.Threading.Tasks;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Services
{
    public class TodoItemsService
    {
        private readonly ApiClient _apiClient;
        private readonly string _endpoint = "todoitems";

        private TodoItemsService()
        {
            _apiClient = new ApiClient();
        }

        public static TodoItemsService Instance { get; } = new TodoItemsService();

        private List<TodoItem> _items = new List<TodoItem>();

        #region Methods
        public async Task<List<TodoItem>> GetTodoItemsAsync(int listId)
        {
            return await _apiClient.GetAsync<List<TodoItem>>($"todolists/{listId}/{_endpoint}")
                ?? new List<TodoItem>();
        }

        public async Task PostTodoItemAsync(TodoItem item)
        {
            var success = await _apiClient.PostAsync<TodoItem>($"{_endpoint}", item);

            if (success != null)
            {
                await GetTodoItemsAsync(item.TodoListId);
            }
        }

        public async Task UpdateTodoItemAsync(TodoItem item)
        {
            var endpoint = $"{_endpoint}/{item.Id}";

            await _apiClient.UpdateAsync(endpoint, item);
        }

        public async Task<bool> DeleteTodoItemAsync(TodoItem item)
        {
            if (item == null)
                return false;

            return await _apiClient.DeleteAsync($"{_endpoint}/{item.Id}");
        }
        #endregion
    }
}
