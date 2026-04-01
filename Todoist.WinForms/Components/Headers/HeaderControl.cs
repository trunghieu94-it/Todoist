using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Todoist.WinForms.Views.Components
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();

            SetTodayDate();
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set {
                lblTitle.Text = value;
            }
        }

        public Image TitleIcon
        {
            get { return lblTitle.Icon; }
            set { lblTitle.Icon = value; }
        }

        private void SetTodayDate()
        {
            var culture = new CultureInfo("vi-VN");
            lblDate.Text = DateTime.Now.ToString("dddd, d/M/yyyy", culture);
        }
    }
}
