using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views.Components
{
    public partial class TodoListItem : UserControl
    {
        public TodoListItem()
        {
            InitializeComponent();
        }

        #region Fields
        public string ListName
        {
            get => txtListName.Text;
            set => txtListName.Text = value;
        }

        public string Priority
        {
            get => cboPriority.Text;
            set => cboPriority.Text = value;
        }
        #endregion

        #region Methods
        public void DisplayDeadline(TodoList list)
        {

            if (list.Deadline != null)
            {
                DateTime deadline = (DateTime)list.Deadline;

                dtpDate.Value = deadline;
                dtpDate.Checked = true;

                dtpTime.Value = deadline;
                dtpTime.Checked = true;
            }
            else
            {
                dtpDate.Checked = false;
                dtpTime.Checked = false;
            }
        }
        #endregion
    }
}
