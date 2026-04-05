using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Todoist.WinForms.Enums;
using Todoist.WinForms.Models;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views.Components
{
    public partial class TodoListView : UserControl
    {
        #region Fields
        public int ListId { get; private set; }
        private TodoList _todo;

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

        public string ListPriority
        {
            get => cboPriority.Text;
            set => cboPriority.Text = value;
        }

        public TodoListStatus ListStatus
        {
            get => _todo.ListStatus;
            set => _todo.ListStatus = value;
        }
        #endregion

        public TodoListView()
        {
            InitializeComponent();
           
            SubcribeEvents();
        }

        #region Methods
        public void SetData(TodoList list)
        {
            ListId = list.Id;
            InitPriority();
            BindData(list);
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

        private void BindData(TodoList list)
        {
            _todo = list;

            ListName = list.ListName ?? string.Empty;

            if (cboPriority.DataSource != null)
            {
                cboPriority.SelectedItem = list.ListPriority;
            }

            if (list.Deadline.HasValue)
            {
                var dt = list.Deadline.Value;

                dtpDate.Value = dt.Date;
                dtpTime.Value = DateTime.Today.Add(dt.TimeOfDay);

                dtpDate.Checked = true;
            }
            else
            {
                dtpDate.Checked = false;
            }

            ListStatus = list.ListStatus;
        }

        private void InitPriority()
        {
            cboPriority.DataSource = Enum.GetValues(typeof(TodoListPriority));
        }
        private void SubcribeEvents()
        {
            txtListName.KeyDown += HandleEnterKey;
            cboPriority.KeyDown += HandleEnterKey;
            dtpDate.KeyDown += HandleEnterKey;
            dtpTime.KeyDown += HandleEnterKey;
        }

        private async void HandleEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await UpdateTodoAsync();
            }
        }

        private TodoList BuildUpdatedTodo()
        {
            return new TodoList
            {
                Id = ListId,
                ListName = txtListName.Text.Trim(),
                ListPriority = (TodoListPriority)cboPriority.SelectedValue,
                ListStatus = ListStatus,
                Deadline = GetDeadline()
            };
        }

        private DateTime? GetDeadline()
        {
            if (!dtpDate.Checked) return null; // nếu bạn dùng checkbox

            var date = dtpDate.Value.Date;
            var time = dtpTime.Value.TimeOfDay;

            return date.Add(time);
        }

        private async Task UpdateTodoAsync()
        {
            var updated = BuildUpdatedTodo();

            try
            {
                SetLoading(true);

                await TodoListsService.Instance.UpdateAsync(updated);

                _todo = updated;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update thất bại: " + ex.Message);
            }
            finally
            {
                SetLoading(false);
            }
        }

        private void SetLoading(bool isLoading)
        {
            txtListName.Enabled = !isLoading;
            cboPriority.Enabled = !isLoading;
            dtpDate.Enabled = !isLoading;
            dtpTime.Enabled = !isLoading;
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
