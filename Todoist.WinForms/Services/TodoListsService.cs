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

        private TodoListSortType _currentSort = TodoListSortType.None;

        private TodoListsService()
        {
            _apiClient = new ApiClient();
        }

        public static TodoListsService Instance { get; } = new TodoListsService();

        private List<TodoList> _lists = new List<TodoList>();

        public event Action<List<TodoList>> OnListsChanged;
        public event Action<TodoList> OnListSelected;

        #region Methods
        public async Task GetTodoListsAsync()
        {
            var endpoint = "todolists";

            var todoLists = await _apiClient.GetAsync<List<TodoList>>(endpoint)
                ?? new List<TodoList>();

            SetLists(todoLists);
        }

        public async Task GetByFilterTodoListsAsync(TodoListFilter filter)
        {
            var endpoint = "todolists/filter";

            var queryParams = new List<string>();

            if (!string.IsNullOrEmpty(filter.Status))
                queryParams.Add($"status={filter.Status}");

            if (filter.HasDeadline.HasValue)
                queryParams.Add($"hasDeadline={filter.HasDeadline.Value.ToString().ToLower()}");

            if (queryParams.Any())
                endpoint += "?" + string.Join("&", queryParams);

            var todoLists = await _apiClient.GetAsync<List<TodoList>>(endpoint)
                ?? new List<TodoList>();

            SetLists(todoLists);
        }

        public async Task GetByFilterTodoListsAsync(
            TodoListFilter filter,
            string sortBy = null,
            string order = "asc"
        )
        {
            var endpoint = "todolists/filter";

            var queryParams = new List<string>();

            if (!string.IsNullOrEmpty(filter.Status))
                queryParams.Add($"status={filter.Status}");

            if (filter.HasDeadline.HasValue)
                queryParams.Add($"hasDeadline={filter.HasDeadline.Value.ToString().ToLower()}");

            if (queryParams.Any())
                endpoint += "?" + string.Join("&", queryParams);

            var todoLists = await _apiClient.GetAsync<List<TodoList>>(endpoint)
                ?? new List<TodoList>();

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "name":
                        todoLists = order == "asc"
                            ? todoLists.OrderBy(x => x.ListName).ToList()
                            : todoLists.OrderByDescending(x => x.ListName).ToList();
                        break;
                    case "deadline":
                        todoLists = order == "asc"
                            ? todoLists.OrderBy(x => x.Deadline).ToList()
                            : todoLists.OrderByDescending(x => x.Deadline).ToList();
                        break;
                    case "createdat":
                        todoLists = order == "asc"
                            ? todoLists.OrderBy(x => x.CreatedAt).ToList()
                            : todoLists.OrderByDescending(x => x.CreatedAt).ToList();
                        break;
                }
            }

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

        private List<TodoList> ApplySort(List<TodoList> lists)
        {
            switch (_currentSort)
            {
                case TodoListSortType.NameAsc:
                    return lists.OrderBy(x => x.ListName).ToList();

                case TodoListSortType.NameDesc:
                    return lists.OrderByDescending(x => x.ListName).ToList();

                case TodoListSortType.DeadlineAsc:
                    return lists.OrderBy(
                        x => x.Deadline ?? DateTime.MaxValue
                    ).ToList();

                case TodoListSortType.DeadlineDesc:
                    return lists.OrderByDescending(
                        x => x.Deadline ?? DateTime.MinValue
                    ).ToList();

                case TodoListSortType.CreatedAtAsc:
                    return lists.OrderBy(x => x.CreatedAt).ToList();

                case TodoListSortType.CreatedAtDesc:
                    return lists.OrderByDescending(x => x.CreatedAt).ToList();

                default:
                    return lists;
            }
        }

        public void SetLists(List<TodoList> lists)
        {
            _lists = ApplySort(lists);
            OnListsChanged?.Invoke(_lists);
        }

        public void SetSort(TodoListSortType sortType)
        {
            _currentSort = sortType;

            SetLists(_lists);
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
