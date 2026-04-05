using System;
using System.Windows.Forms;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Views.Components
{
    public partial class TodoListView : UserControl
    {
        #region Fields
        public int ListId { get; private set; }

        public event Action<int, string> OnDetailClicked;
        public event Action<bool> OnChecked;
        public event Action<int> OnDeleteClicked;
        #endregion

        #region Properties
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

        public TodoListView()
        {
            InitializeComponent();
        }

        #region Methods
        public void SetData(TodoList list)
        {
            ListId = list.Id;
        }

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

        #region Events
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            OnDetailClicked?.Invoke(ListId, ListName);
        }
        #endregion

        private void ChkTodoList_CheckedChanged(object sender, EventArgs e)
        {
            OnChecked?.Invoke(chkTodoList.Checked);
        }

        private void IconDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClicked?.Invoke(ListId);
        }
    }
}
