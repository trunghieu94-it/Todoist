using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Todoist.WinForms.Models;
using Todoist.WinForms.Models.Enums;

namespace Todoist.WinForms.Services
{
    public class TodoListsService
    {
        private readonly ApiClient _apiClient;

        public static TodoListsService Instance { get; } = new TodoListsService();

        private List<TodoList> _originalLists = new List<TodoList>();
        private List<TodoList> _currentLists = new List<TodoList>();

        private TodoListSortType _currentSort = TodoListSortType.CreatedAtDesc;

        public event Action<List<TodoList>> OnListsChanged;
        public event Action<TodoList> OnListSelected;

        private TodoListsService()
        {
            _apiClient = new ApiClient();
        }

        #region Methods
        //public async Task GetTodoListsAsync()
        //{
        //    var endpoint = "todolists";

        //    _originalLists = await _apiClient.GetAsync<List<TodoList>>(endpoint)
        //        ?? new List<TodoList>();

        //    _currentLists = _originalLists;

        //    SetLists();
        //}

        public async Task GetByFilterTodoListsAsync(TodoListFilter filter)
        {
            var endpoint = "todolists/filter";

            var queryParams = new List<string>();

            if (string.IsNullOrEmpty(filter.Status) && !filter.HasDeadline.HasValue)
            {
                endpoint = "todolists";
            }

            if (!string.IsNullOrEmpty(filter.Status))
                queryParams.Add($"status={filter.Status}");

            if (filter.HasDeadline.HasValue)
                queryParams.Add($"hasDeadline={filter.HasDeadline.Value.ToString().ToLower()}");

            if (queryParams.Any())
                endpoint += "?" + string.Join("&", queryParams);

            _currentLists = await _apiClient.GetAsync<List<TodoList>>(endpoint)
                ?? new List<TodoList>();

            SetLists();
        }


        public async Task PostTodoListAsync(CreateTodoList list)
        {
            var success = await _apiClient.PostAsync<TodoList>("todolists", list);

            if (success != null)
            {
                await GetByFilterTodoListsAsync(
                    new TodoListFilter
                    {
                        Status = null,
                        HasDeadline = null
                    });
            }
        }

        private List<TodoList> ApplySort()
        {
            switch (_currentSort)
            {
                case TodoListSortType.NameAsc:
                    return _currentLists.OrderBy(x => x.ListName).ToList();

                case TodoListSortType.NameDesc:
                    return _currentLists.OrderByDescending(x => x.ListName).ToList();

                case TodoListSortType.DeadlineAsc:
                    return _currentLists.OrderBy(
                        x => x.Deadline ?? DateTime.MaxValue
                    ).ToList();

                case TodoListSortType.DeadlineDesc:
                    return _currentLists.OrderByDescending(
                        x => x.Deadline ?? DateTime.MinValue
                    ).ToList();

                case TodoListSortType.CreatedAtAsc:
                    return _currentLists.OrderBy(x => x.CreatedAt).ToList();

                case TodoListSortType.CreatedAtDesc:
                    return _currentLists.OrderByDescending(x => x.CreatedAt).ToList();

                case TodoListSortType.PriorityAsc:
                    return _currentLists.OrderBy(x => x.ListPriority).ToList();

                case TodoListSortType.PriorityDesc:
                    return _currentLists.OrderByDescending(x => x.ListPriority).ToList();

                default:
                    return _currentLists;
            }
        }

        public void SetLists()
        {
            _currentLists = ApplySort();
            OnListsChanged?.Invoke(_currentLists);
        }

        public void SetSort(TodoListSortType sortType)
        {
            _currentSort = sortType;

            SetLists();
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
