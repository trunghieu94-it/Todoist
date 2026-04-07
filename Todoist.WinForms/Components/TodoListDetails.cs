using System;
using System.Drawing;
using System.Windows.Forms;

using Todoist.WinForms.Components;
using Todoist.WinForms.Enums;
using Todoist.WinForms.Models;
using Todoist.WinForms.Enums;
using Todoist.WinForms.Models;

namespace Todoist.WinForms.Views.Components
{
    public partial class TodoListDetails : UserControl
    {
        private TodoItemsView _todoItemsView;
        private TodoList _list;
        private TodoList _list;

        public event Action<TodoListDetails> OnCloseClicked;
        public event Action<Control, TodoList> OnArchiveClicked;
        public event Action<Control, TodoList> OnCompleteClicked;

        public string Title
        {
            get => txtListName.Text;
            set => txtListName.Text = value;
        }

        public string Complete
        {
            get => lblComplete.Text;
            set => lblComplete.Text = value;
        }

        public string Complete
        {
            get => lblComplete.Text;
            set => lblComplete.Text = value;
        }

        public TodoListDetails()
        {
            InitializeComponent();
        }

        #region Methods
        public void ShowTodoItems(TodoList list)
        #region Methods
        public void ShowTodoItems(TodoList list)
        {
            if (_todoItemsView == null)
            {
                _todoItemsView = new TodoItemsView();
            if (_todoItemsView == null)
            {
                _todoItemsView = new TodoItemsView();

                _todoItemsView.Dock = DockStyle.Fill;
                _todoItemsView.Dock = DockStyle.Fill;

                todoItemsPanel.Controls.Add(_todoItemsView);
            }
                todoItemsPanel.Controls.Add(_todoItemsView);
            }

            _todoItemsView.SetListId(list.Id);
            _todoItemsView.SetListId(list.Id);

            _todoItemsView.BringToFront();


        }

        public void BindData(TodoList list)
        {
            _list = list;
            Title = list.ListName;
            switch (list.ListStatus)
            {
                case TodoListStatus.Completed:
                    Complete = "Đã hoàn thành";
                    lblComplete.Enabled = false;
                    break;
                case TodoListStatus.Archived:
                    Complete = "Đã lưu trữ";
                    lblComplete.Enabled = false;
                    break;
                default:
                    Complete = "Đánh dấu đã hoàn thành";
                    lblComplete.Enabled = true;
                    lblComplete.Cursor = Cursors.Hand;
                    break;
            }
        }
        #endregion

        #region Event Handlers
        private void BtnClose_Click(object sender, EventArgs e)
        {
            OnCloseClicked?.Invoke(this);
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            OnArchiveClicked?.Invoke(this, _list);
        }

        private void LblComplete_Click(object sender, EventArgs e)
        {
            OnCompleteClicked?.Invoke(this, _list);
        }
        #endregion
    }
}
