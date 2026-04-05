using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Services;
using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Components
{
    public partial class TodoListsView : UserControl
    {
        public event Action<int, string> OnTodoListDetailRequested;

        public List<TodoList> _selectedLists = new List<TodoList>();

        public TodoListsView()
        {
            InitializeComponent();

            // Subcribe events
            TodoListsService.Instance.OnListsChanged += RenderTodoLists;
        }

        public void RenderTodoLists(List<TodoList> lists)
        {
            tableListItems.SuspendLayout();

            tableListItems.Controls.Clear();
            tableListItems.RowStyles.Clear();
            tableListItems.RowCount = 0;

            foreach (var list in lists)
            {
                var item = ListItem(list);

                item.SetData(list);

                SubcribeEvents(item, list);

                item.Dock = DockStyle.Fill;
                item.Margin = new Padding(0, 10, 0, 10);

                tableListItems.RowCount++;

                tableListItems.RowStyles.Add(
                    new RowStyle(SizeType.AutoSize));

                tableListItems.Controls.Add(item, 0, tableListItems.RowCount - 1);
            }

            tableListItems.ResumeLayout();
        }

        private TodoListView ListItem(TodoList list)
        {
            TodoListView item = new TodoListView();

            item.ListName = list.ListName;
            item.Priority = list.ListPriority.ToString();
            item.DisplayDeadline(list);

            return item;
        }

        private void SubcribeEvents(TodoListView item, TodoList list)
        {
            item.OnDetailClicked += (listId, listName) => // subcribe
            {
                OnTodoListDetailRequested?.Invoke(listId, listName);
            };

            item.OnChecked += (isChecked) =>
            {
                if (isChecked)
                {
                    _selectedLists.Add(list);
                }
                else
                {
                    _selectedLists.RemoveAll(l => l.Id == list.Id);
                }
            };

            item.OnDeleteClicked += async (listId) =>
            {
                var confirmResult = MessageBox.Show(
                    "Bạn chắc chắn muốn xóa list này?",
                    "Xác nhận!",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var result = await TodoListsService.Instance.DeleteTodoListAsync(list);

                    if (result)
                    {
                        await TodoListsService.Instance.LoadTodoListsAsync(
                    new TodoListFilter
                    {
                        Status = null,
                        HasDeadline = null
                    });
                    }
                }
            };
        }
    }
}
