using System.Collections.Generic;
using System.Threading.Tasks;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Services
{
    public class TodoListsService
    {
        private readonly ApiClient _apiClient;

        public TodoListsService()
        {
            _apiClient = new ApiClient();
        }

        public async Task<List<TodoList>> GetTodoListsAsync()
        {
            var todoLists = await _apiClient.GetAsync<List<TodoList>>("todolists");

            return todoLists ?? new List<TodoList>();
        }
    }
}
