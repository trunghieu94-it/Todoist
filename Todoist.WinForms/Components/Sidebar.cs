using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Components
{
    public partial class Sidebar : UserControl
    {
        public event Action<string> OnMenuClick;
        public event Action<int> OnListLabelClicked;

        public Sidebar()
        {
            InitializeComponent();

            TodoListsService.Instance.OnListsChanged += RenderListNames;
        }

        #region Methods
        public void RenderListNames(List<TodoList> lists)
        {
            flowListNames.Controls.Clear();

            foreach (var list in lists)
            {
                flowListNames.Controls.Add(LblListName(list));
            }
        }

        private Label LblListName(TodoList list)
        {
            Label lbl = new Label();

            lbl.Tag = list.Id;

            lbl.Text = list.ListName;
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(flowListNames.Width - 30, 0);
            lbl.Margin = new Padding(0, 10, 0, 10);

            lbl.Font = new Font("Segoe UI", 12);
            lbl.Cursor = Cursors.Hand;

            lbl.Click += LabelList_Click;

            return lbl;
        }
        #endregion

        #region Events
        private void BtnHome_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke("Home");
        }
        private void BtnPlanned_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke("Planned");
        }
        private void BtnPriority_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke("Achieved");
        }
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke("Notes");
        }

        private void LabelList_Click(object sender, EventArgs args)
        {
            var lbl = sender as Label;

            if (lbl?.Tag is int listId)
            {
                OnListLabelClicked?.Invoke(listId);
            }
        }

        private void TxtTitle_Enter(object sender, EventArgs e)
        {
            if (txtAddTodoList.Text == "New todolist")
            {
                txtAddTodoList.Text = "";
                txtAddTodoList.ForeColor = Color.Black;
            }
        }

        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddTodoList.Text))
            {
                txtAddTodoList.Text = "New todolist";
                txtAddTodoList.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
