using System;
using System.Windows.Forms;

namespace Todoist.WinForms.Components
{
    public partial class Sidebar : UserControl
    {
        // Fields
        public event Action<string> OnMenuClick;

        public Sidebar()
        {
            InitializeComponent();
        }

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
            OnMenuClick?.Invoke("Priority");
        }
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke("Notes");
        }
        #endregion


    }
}
