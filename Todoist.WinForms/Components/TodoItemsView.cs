using System.Collections.Generic;
using System.Windows.Forms;

using Todoist.WinForms.Models;

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
        #endregion

        #region Methods
        public void SetListId(int listId)
        {
            _currentListId = listId;
        }

        public void SetData(int listId, List<TodoItem> items)
        {
            if (listId != _currentListId) return;

            RenderItems(items);
        }

        private void RenderItems(List<TodoItem> items)
        {
            tableTodoItems.SuspendLayout();
            tableTodoItems.Controls.Clear();
            tableTodoItems.RowStyles.Clear();
            tableTodoItems.RowCount = 0;

            foreach (var item in items)
            {
                var itemView = ItemView(item);

                itemView.Dock = DockStyle.Fill;
                itemView.Margin = new Padding(0, 10, 0, 10);

                tableTodoItems.RowCount++;

                tableTodoItems.RowStyles.Add(
                    new RowStyle(SizeType.AutoSize));

                tableTodoItems.Controls.Add(itemView, 0, tableTodoItems.RowCount - 1);
            }

            tableTodoItems.ResumeLayout();
        }

        private TodoItemView ItemView(TodoItem todoItem)
        {
            TodoItemView item = new TodoItemView();

            item.Title = todoItem.Title;
            item.Status = todoItem.ItemStatus.ToString();

            return item;
        }
        #endregion
    }
}
