using System;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views.Components
{
    public partial class AddTodoList : UserControl
    {
        #region Fields
        private TodoListsService _service = TodoListsService.Instance;

        // Delegate chứa model
        public event Action<CreateTodoList> OnSubmitted;
        #endregion

        public AddTodoList()
        {
            InitializeComponent();
        }

        #region Methods
        private bool TryCreateTodoList(out CreateTodoList modelList)
        {
            modelList = null;

            errorTxtAddTodoList.Clear(); // dùng ErrorProvider để highlight field

            var name = txtNewTodoList.Text.Trim();
            var deadline = GetDeadline();

            var (isValidName, nameError) = _service.ValidateName(name);
            var (isValidDeadline, deadlineError) = _service.ValidateDeadline(deadline);

            if (!isValidName)
            {
                errorTxtAddTodoList.SetIconPadding(txtNewTodoList, -25);
                errorTxtAddTodoList.SetError(txtNewTodoList, nameError);
                txtNewTodoList.Focus();
                return false;
            }

            if (!isValidDeadline)
            {
                errorTxtAddTodoList.SetError(dtpDate, deadlineError);
                return false;
            }

            modelList = new CreateTodoList
            {
                ListName = name,
                Deadline = deadline
            };

            ResetForm(); // reset form sau khi tạo model thành công
            return true;
        }

        public void ResetForm()
        {
            txtNewTodoList.Clear();
            dtpDate.Value = DateTime.Today;
            dtpDate.Checked = false;
            dtpTime.Value = DateTime.Now;
            dtpTime.Checked = false;
            errorTxtAddTodoList.Clear();
        }

        private DateTime? GetDeadline()
        {
            if (!dtpDate.Checked)
                return null;

            var deadline = dtpDate.Value.Date;

            if (dtpTime.Checked)
            {
                deadline = deadline.Add(dtpTime.Value.TimeOfDay);
            }
            else
            {
                deadline = deadline.Add(new TimeSpan(23, 59, 0));
            }

            return deadline;
        }

        #endregion

        #region Events
        private void PicAddTodoList_Click(object sender, EventArgs e)
        {
            if (!TryCreateTodoList(out var model))
                return; // lỗi đã hiển thị bên trong TryBuildModel

            OnSubmitted?.Invoke(model);
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PicAddTodoList_Click(sender, e);
                e.Handled = true; // ngăn chặn tiếng "ding" khi nhấn Enter
            }
        }
        #endregion
    }
}
