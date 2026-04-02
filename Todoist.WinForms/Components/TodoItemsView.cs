using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Todoist.WinForms.Enums;
using Todoist.WinForms.Models;
using Todoist.WinForms.Models.Enums;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Components
{
    public partial class TodoItemsView : UserControl
    {
        public TodoItemsView()
        {
            InitializeComponent();
        }

        #region Fields
        private int _currentListId;
        private bool _isAdding = false;

        private TodoItemsService _service = TodoItemsService.Instance;
        #endregion

        #region Methods
        private void RenderItems(List<TodoItem> items)
        {
            tableTodoItems.SuspendLayout();
            tableTodoItems.Controls.Clear();
            tableTodoItems.RowStyles.Clear();
            tableTodoItems.RowCount = 0;

            foreach (var item in items)
            {
                var itemView = new TodoItemView(item, TodoItemViewMode.Edit);

                itemView.OnUpdate += async (updatedItem) =>
                {
                    //await service.UpdateAsync(updatedItem);
                    await LoadDataAsync();
                };

                AddRow(itemView);
            }

            if (_isAdding)
            {
                var addView = new TodoItemView(
                    new TodoItem(),
                    TodoItemViewMode.Create
                );

                addView.OnCreate += async (item) =>
                {
                    await HandleCreateItemAsync(item);
                };

                addView.OnCancel += () =>
                {
                    _isAdding = false;
                    RenderItems(items);
                };

                AddRow(addView);
            }
            else
            {
                var btnAdd = new AddTodoItemButton();

                btnAdd.Click += (s, e) =>
                {
                    _isAdding = true;
                    RenderItems(items);
                };

                AddRow(btnAdd);
            }

            tableTodoItems.ResumeLayout();
        }

        private async Task HandleCreateItemAsync(TodoItemView itemView)
        {
            TodoItem item = new TodoItem();
            item.TodoListId = _currentListId;
            item.Title = itemView.Title;
            item.ItemStatus = TryParseEnum(itemView.Status, item.ItemStatus);

            await _service.PostTodoItemAsync(item);

            await LoadDataAsync();
        }

        private TodoItemStatus TryParseEnum(string statusView, TodoItemStatus status)
        {
            if (Enum.TryParse(statusView, out status))
            {
                return status;
            }
            else
            {
                MessageBox.Show($"Invalid status: {statusView}");
            }
            return status;
        }

        private void AddRow(Control control)
        {
            tableTodoItems.RowCount++;

            tableTodoItems.RowStyles.Add(
                new RowStyle(SizeType.AutoSize));

            tableTodoItems.Controls.Add(control, 0, tableTodoItems.RowCount - 1);
        }

        public async Task LoadDataAsync()
        {
            try
            {
                var items = await _service.GetTodoItemsAsync(_currentListId);

                RenderItems(items);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading todo items: {ex.Message}");
            }
        }


        public void SetListId(int listId)
        {
            _currentListId = listId;

            _ = LoadDataAsync();
        }
        #endregion
    }
}
