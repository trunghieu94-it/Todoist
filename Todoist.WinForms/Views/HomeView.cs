using System.Windows.Forms;

namespace Todoist.WinForms.Views
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Home";
            header.TitleIcon = Properties.Resources.home_2;
        }
    }
}
