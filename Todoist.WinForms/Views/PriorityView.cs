using System.Windows.Forms;

namespace Todoist.WinForms.Views
{
    public partial class PriorityView : UserControl
    {
        public PriorityView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Priority";
            header.TitleIcon = Properties.Resources.star;
        }
    }
}
