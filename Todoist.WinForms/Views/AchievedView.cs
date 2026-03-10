using System.Windows.Forms;

namespace Todoist.WinForms.Views
{
    public partial class AchievedView : UserControl
    {
        public AchievedView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Achieved";
            header.TitleIcon = Properties.Resources.star;
        }
    }
}
