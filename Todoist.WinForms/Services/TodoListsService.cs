using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Todoist.Domain.Dtos.Work;
using Todoist.Domain.Enums;

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
            var dto = new CreateTodoListDto
            {
                ListName = list.ListName,
                Deadline = list.Deadline,
                ListPriority = (TodoListPriority)list.ListPriority,
                ListStatus = (TodoListStatus)list.ListStatus,
                UserId = list.UserId
            };
            var success = await _apiClient.PostAsync<TodoList>("todolists", dto);
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
    }
}
