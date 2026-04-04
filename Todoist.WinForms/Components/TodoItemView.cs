using System;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Models.Enums;

namespace Todoist.WinForms.Components
{
    public partial class TodoItemView : UserControl
    {
        public TodoItemView(TodoItem item, TodoItemViewMode mode)
        {
            this._item = item;
            this._mode = mode;

            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.Margin = new Padding(0, 10, 0, 10);
            cboStatus.SelectedIndex = 0;

            BindData();
            BindEvents();
        }

        private TodoItemViewMode _mode;
        private TodoItem _item;

        public event Action<TodoItem> OnUpdate;
        public event Action<TodoItemView> OnCreate;
        public event Action OnCancel;

        private void BindData()
        {
            if (_mode == TodoItemViewMode.Edit && _item != null)
            {
                txtTitle.Text = _item.Title;
                cboStatus.SelectedItem = _item.ItemStatus.ToString();
            }
        }

        private void BindEvents()
        {
            // Enter
            txtTitle.KeyDown += (s, e) =>
            {
                HandleKeyDown(s, e);
            };

            cboStatus.KeyDown += (s, e) =>
            {
                HandleKeyDown(s, e);
            };

            // Blur → cancel (chỉ áp dụng cho Create)
            txtTitle.LostFocus += HandleLostFocus;
            cboStatus.LostFocus += HandleLostFocus;

            // Focus khi create
            if (_mode == TodoItemViewMode.Create)
            {
                this.Load += (s, e) => txtTitle.Focus();
            }
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_mode == TodoItemViewMode.Edit)
                {
                    txtTitle.Text = _item.Title;
                    cboStatus.SelectedItem = _item.ItemStatus.ToString();

                    OnUpdate?.Invoke(_item);
                }
                else if (_mode == TodoItemViewMode.Create)
                {
                    OnCreate?.Invoke(this);
                }
            }
        }

        private void HandleLostFocus(object sender, EventArgs e)
        {
            if (_mode != TodoItemViewMode.Create) return;

            this.BeginInvoke(new Action(() =>
            {
                if (!txtTitle.Focused && !cboStatus.Focused)
                {
                    OnCancel?.Invoke();
                }
            }));
        }

        #region Properties
        public string Title
        {
            get => txtTitle.Text;
            set => txtTitle.Text = value;
        }

        public string Status
        {
            get => cboStatus.Text;
            set => cboStatus.Text = value;
        }
        #endregion
    }
}
