using System;
using System.Windows.Forms;

using Todoist.WinForms.Components;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views.Components
{
    public partial class TodoListDetails : UserControl
    {
        private TodoItemsView _todoItemsView;

        public event Action OnCloseClicked;

        public string Title
        {
            get => txtListName.Text;
            set => txtListName.Text = value;
        }

        public TodoListDetails()
        {
            InitializeComponent();
        }

        public async void SetListId(int listId)
        {
            try
            {
                var items = await TodoItemsService.Instance.GetTodoItemsAsync(listId);

                if (_todoItemsView == null)
                {
                    _todoItemsView = new TodoItemsView();

                    _todoItemsView.Dock = DockStyle.Fill;

                    todoItemsPanel.Controls.Add(_todoItemsView);
                }

                _todoItemsView.SetListId(listId);
                _todoItemsView.SetData(listId, items);

                _todoItemsView.BringToFront();
            }
            catch
            {
                MessageBox.Show("Failed to load todo items");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            OnCloseClicked?.Invoke();
        }
    }
}
