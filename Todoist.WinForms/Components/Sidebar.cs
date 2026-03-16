using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Components
{
    public partial class Sidebar : UserControl
    {
        // Fields
        public event Action<string> OnMenuClick;

        public Sidebar()
        {
            InitializeComponent();
        }

        #region Methods
        public void RenderSidebar(List<TodoList> lists)
        {
            flowListNames.Controls.Clear();

            foreach (var list in lists)
            {
                Label lbl = new Label();
                lbl.Text = list.ListName;
                lbl.Width = flowListNames.Width - 5;
                lbl.Height = 35;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Padding = new Padding(10, 0, 0, 0);

                lbl.Font = new Font("Segoe UI", 12);

                flowListNames.Controls.Add(lbl);
            }
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
