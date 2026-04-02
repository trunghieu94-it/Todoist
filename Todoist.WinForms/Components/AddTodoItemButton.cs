using System.Windows.Forms;

namespace Todoist.WinForms.Components
{
    public partial class AddTodoItemButton : UserControl
    {
        public AddTodoItemButton()
        {
            InitializeComponent();

            foreach (Control ctl in this.Controls)
            {
                ctl.Click += (s, e) => this.OnClick(e);
            }

        }
    }
}
