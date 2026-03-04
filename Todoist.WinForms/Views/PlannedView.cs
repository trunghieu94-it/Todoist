using System.Windows.Forms;

namespace Todoist.WinForms.Views
{
    public partial class PlannedView : UserControl
    {
        public PlannedView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Planned";
            header.TitleIcon = Properties.Resources.calendar;
        }
    }
}
