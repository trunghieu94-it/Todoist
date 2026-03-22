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
        // Fields
        public event Action<string> OnMenuClick;

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
            lbl.Text = list.ListName;
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(flowListNames.Width - 30, 0);
            lbl.Margin = new Padding(0, 10, 0, 10);

            lbl.Font = new Font("Segoe UI", 12);
            lbl.Cursor = Cursors.Hand;
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
        #endregion
    }
}
