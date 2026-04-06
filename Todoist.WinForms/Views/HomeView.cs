using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Todoist.WinForms.Enums;
using Todoist.WinForms.Models;
using Todoist.WinForms.Services;
using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Views
{
    public partial class HomeView : UserControl
    {
        private readonly TodoListsService _service = TodoListsService.Instance;
        private TodoListDetails _detailsView;

        public event Action<CreateTodoList> OnTodoListSubmitted;

        public HomeView()
        {
            InitializeComponent();

            //Subscribe events
            listItems.OnTodoListDetailRequested += HandleDetailRequested;
            addTodoListPanel.OnSubmitted += (model) => OnTodoListSubmitted?.Invoke(model);

        }

        #region Methods
        private void ShowTodoListDetails(TodoList list)
        {
            try
            {
                if (_detailsView == null)
                {
                    _detailsView = new TodoListDetails();

                    _detailsView.OnCloseClicked += HandleCloseDetails;

                    _detailsView.OnArchiveClicked += async (view, todoList) =>
                    {
                        await HandleArchiveListAsync(view, todoList);
                    };

                    contentPanel.Controls.Add(_detailsView);
                }

                _detailsView.BindData(list);

                _detailsView.Dock = DockStyle.Fill;

                _detailsView.Title = list.ListName;

                _detailsView.ShowTodoItems(list);

                _detailsView.Show();
                _detailsView.BringToFront();
            }
            catch
            {
                MessageBox.Show("Don't show TodoListDetails");
            }
        }

        public void HandleDetailRequested(TodoList list)
        {
            ShowTodoListDetails(list);
        }

        private void HandleCloseDetails(TodoListDetails detailView)
        {
            if (_detailsView != null)
            {
                _detailsView.Hide();
            }
        }

        private async Task HandleArchiveListAsync(Control sender, TodoList list)
        {
            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn lưu trữ TodoList này?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            list.ListStatus = TodoListStatus.Archived;
            await _service.UpdateTodoListAsync(list);

            ShowTodoListDetails(list);
        }
        #endregion

        private async Task BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedItems = listItems._selectedLists;

            if (selectedItems == null || !selectedItems.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 TodoList để xóa!");
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa {selectedItems.Count} TodoList?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            var tasks = selectedItems
                .Select(item => _service.DeleteTodoListAsync(item));

            var results = await Task.WhenAll(tasks);

            if (results.All(x => x))
            {
                MessageBox.Show("Xóa thành công!");
                listItems._selectedLists = new List<TodoList>();
                await _service.LoadTodoListsAsync(new TodoListFilter());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa!");
            }
        }
    }
}
