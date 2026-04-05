using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Services;
using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Views
{
    public partial class HomeView : UserControl
    {
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
        private void ShowTodoListDetails(int listId, string listName)
        {
            try
            {
                if (_detailsView == null)
                {
                    _detailsView = new TodoListDetails();

                    _detailsView.OnCloseClicked += HandleCloseDetails;

                    _detailsView.Dock = DockStyle.Fill;
                    contentPanel.Controls.Add(_detailsView);
                }

                _detailsView.Title = listName;

                _detailsView.ShowTodoItems(listId);

                _detailsView.Show();
                _detailsView.BringToFront();
            }
            catch
            {
                MessageBox.Show("Don't show TodoListDetails");
            }
        }

        public void HandleDetailRequested(int listId, string listName)
        {
            ShowTodoListDetails(listId, listName);
        }

        private void HandleCloseDetails()
        {
            if (_detailsView != null)
            {
                _detailsView.Hide();
            }
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
                .Select(item => TodoListsService.Instance.DeleteTodoListAsync(item));

            var results = await Task.WhenAll(tasks);

            if (results.All(x => x))
            {
                MessageBox.Show("Xóa thành công!");
                listItems._selectedLists = new List<TodoList>();
                await TodoListsService.Instance.LoadTodoListsAsync(new TodoListFilter());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa!");
            }
        }
    }
}
