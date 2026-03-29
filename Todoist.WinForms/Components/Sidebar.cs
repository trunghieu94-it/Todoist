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
        // Delegate chứa model
        public event Action<CreateTodoList> OnSubmitted;

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

        private bool TryBuildModel(out CreateTodoList model)
        {
            model = null;
            errorProvider.Clear(); // dùng ErrorProvider để highlight field

            var name = txtAddTodoList.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider.SetError(txtAddTodoList, "Tên danh sách không được để trống");
                txtAddTodoList.Focus();
                return false;
            }
            model = new CreateTodoList
            {
                ListName = name
            };
            ResetForm(); // reset form sau khi tạo model thành công
            return true;
        }

        public void ResetForm()
        {
            txtAddTodoList.Clear();
            errorProvider.Clear();
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
                PicAddTodoList_Click(sender, EventArgs.Empty);
                e.Handled = true; // ngăn chặn tiếng "ding" khi nhấn Enter
            }
        }
        private void TextBox_Click(object sender, EventArgs e)
        {
            txtAddTodoList.Clear();
        }
        #endregion
    }
}
