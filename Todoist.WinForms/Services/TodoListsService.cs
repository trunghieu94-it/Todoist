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

        public async Task PostTodoListAsync(CreateTodoList list)
        {
            var success = await _apiClient.PostAsync<TodoList>("todolists", list);

            if (success != null)
            {
                await GetTodoListsAsync();
            }
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

        #region Validate Methods
        public (bool IsValid, string Error) ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return (false, "Tên danh sách không được để trống!");
            return (true, null);
        }

        public (bool IsValid, string Error) ValidateDeadline(DateTime? deadline)
        {
            if (deadline.HasValue && deadline < DateTime.Today)
            {
                return (false, "Deadline không được ở trong quá khứ!");
            }

            return (true, null);
        }
        #endregion
    }
}
