using System;
using System.Threading.Tasks;
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

        public void ShowTodoItems(int listId)
        {
                if (_todoItemsView == null)
                {
                    _todoItemsView = new TodoItemsView();

                    _todoItemsView.Dock = DockStyle.Fill;

                    todoItemsPanel.Controls.Add(_todoItemsView);
                }

                _todoItemsView.SetListId(listId);

            _todoItemsView.BringToFront();
                        
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            OnCloseClicked?.Invoke();
        }
    }
}
