using System.Windows.Forms;

namespace Todoist.WinForms.Views.Components
{
    public partial class TodoListItem : UserControl
    {
        public TodoListItem()
        {
            InitializeComponent();
        }

        public string ListName
        {
            get => txtListName.Text;
            set => txtListName.Text = value;
        }

        public string Priority
        {
            get => cboPriority.Text;
            set => cboPriority.Text = value;
        }
    }
}
