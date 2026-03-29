using System;
using System.Windows.Forms;

using Todoist.WinForms.Models;

namespace Todoist.WinForms.Views.Components
{
    public partial class AddTodoList : UserControl
    {
        #region Fields
        // Delegate chứa model
        public event Action<CreateTodoList> OnSubmitted;
        #endregion

        public AddTodoList()
        {
            InitializeComponent();
        }

        #region Methods
        private bool TryBuildModel(out CreateTodoList model)
        {
            model = null;
            errorProvider.Clear(); // dùng ErrorProvider để highlight field

            var name = txtNewTodoList.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider.SetError(txtNewTodoList, "Tên danh sách không được để trống");
                txtNewTodoList.Focus();
                return false;
            }

            DateTime? deadline = null;
            if (dtpDate.Checked)  // checkbox bật/tắt deadline
            {
                deadline = dtpDate.Value.Date;
                if (dtpTime.Checked)
                {
                    deadline = deadline.Value.Add(dtpTime.Value.TimeOfDay);
                }

                if (deadline < DateTime.Today)
                {
                    errorProvider.SetError(dtpDate, "Deadline không được ở trong quá khứ");
                    return false;
                }
            }

            model = new CreateTodoList
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
            errorProvider.Clear();
        }
        #endregion

        #region Events
        private void PicAddTodoList_Click(object sender, EventArgs e)
        {
            if (!TryBuildModel(out var model))
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
