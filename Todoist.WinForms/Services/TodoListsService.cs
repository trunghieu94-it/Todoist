using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Services
{
    public class TodoListsService
    {
        private readonly ApiClient _apiClient;

        private TodoListsService()
        {
            _apiClient = new ApiClient();
        }

        public static TodoListsService Instance { get; } = new TodoListsService();

        private List<TodoList> _lists = new List<TodoList>();

        public event Action<List<TodoList>> OnListsChanged;
        public event Action<TodoList> OnListSelected;
        
        #region Events
        public async Task GetTodoListsAsync()
        {
            var todoLists = await _apiClient.GetAsync<List<TodoList>>("todolists")
                ?? new List<TodoList>();
            SetLists(todoLists);
        }

        public void SetLists(List<TodoList> lists)
        {
            _lists = lists;
            OnListsChanged?.Invoke(_lists);
        }

        public void SelectList(TodoList list)
        {
            OnListSelected?.Invoke(list);
        }
        #endregion
    }
}
