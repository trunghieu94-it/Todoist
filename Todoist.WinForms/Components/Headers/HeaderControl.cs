using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Models.Enums;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views.Components
{
    public partial class HeaderControl : UserControl
    {
        public event Action<TodoListFilter, string, string> OnSortOptionChanged;

        private TodoListSortType _currentSort = TodoListSortType.None;

        public HeaderControl()
        {
            InitializeComponent();

            cbSort.SelectedIndex = 0;
            SetTodayDate();
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
            }
        }

        public Image TitleIcon
        {
            get { return lblTitle.Icon; }
            set { lblTitle.Icon = value; }
        }

        #region Events
        private void CbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSort.SelectedItem)
            {
                case "Tên (A → Z)":
                    _currentSort = TodoListSortType.NameAsc;
                    break;

                case "Tên (Z → A)":
                    _currentSort = TodoListSortType.NameDesc;
                    break;

                case "Deadline gần nhất":
                    _currentSort = TodoListSortType.DeadlineAsc;
                    break;

                case "Deadline xa nhất":
                    _currentSort = TodoListSortType.DeadlineDesc;
                    break;

                case "Ngày tạo cũ nhất":
                    _currentSort = TodoListSortType.CreatedAtAsc;
                    break;

                case "Ngày tạo mới nhất":
                    _currentSort = TodoListSortType.CreatedAtDesc;
                    break;

                default:
                    _currentSort = TodoListSortType.None;
                    break;
            }

            TodoListsService.Instance.SetSort(_currentSort);
        }
        #endregion

        #region Methods
        private void SetTodayDate()
        {
            var culture = new CultureInfo("vi-VN");
            lblDate.Text = DateTime.Now.ToString("dddd, d/M/yyyy", culture);
        }
        #endregion
    }
}
