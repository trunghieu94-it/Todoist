using System.Windows.Forms;

namespace Todoist.WinForms.Components
{
    public partial class TodoItemView : UserControl
    {
        public TodoItemView()
        {
            InitializeComponent();
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
