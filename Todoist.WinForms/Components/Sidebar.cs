using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Models.Enums;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Components
{
    public partial class Sidebar : UserControl
    {
        private TodoListsService _service = TodoListsService.Instance;

        // Delegates
        public event Action<AppScreen> OnMenuClick;
        public event Action<CreateTodoList> OnSubmitted;
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

        private bool TryCreateTodoList(out CreateTodoList modelList)
        {
            modelList = null;
            errorProvider.Clear(); // dùng ErrorProvider để highlight field

            var name = txtAddTodoList.Text.Trim();

            var (isValidName, nameError) = _service.ValidateName(name);

            if (!isValidName)
            {
                errorProvider.SetIconPadding(txtAddTodoList, -25);
                errorProvider.SetError(txtAddTodoList, nameError);
                txtAddTodoList.Focus();
                return false;
            }

            modelList = new CreateTodoList
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
            OnMenuClick?.Invoke(AppScreen.Home);
        }
        private void BtnPlanned_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke(AppScreen.Planned);
        }
        private void BtnAchieved_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke(AppScreen.Achieved);
        }
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke(AppScreen.Notes);
        }
        
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
                PicAddTodoList_Click(sender, EventArgs.Empty);
                e.Handled = true; // ngăn chặn tiếng "ding" khi nhấn Enter
            }
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
