using System.Collections.Generic;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Services;
using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Components
{
    public partial class TodoListItems : UserControl
    {
        public TodoListItems()
        {
            InitializeComponent();

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

                item.Dock = DockStyle.Fill;
                item.Margin = new Padding(0, 10, 0, 10);

                tableListItems.RowCount++;

                tableListItems.RowStyles.Add(
                    new RowStyle(SizeType.AutoSize));

                tableListItems.Controls.Add(item, 0, tableListItems.RowCount - 1);
            }

            tableListItems.ResumeLayout();
        }

        private TodoListItem ListItem(TodoList list)
        {
            TodoListItem item = new TodoListItem();

            item.ListName = list.ListName;
            item.Priority = list.ListPriority.ToString();

            return item;
        }
    }
}
