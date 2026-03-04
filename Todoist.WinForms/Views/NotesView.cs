using System.Windows.Forms;

namespace Todoist.WinForms.Views
{
    public partial class NotesView : UserControl
    {
        public NotesView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Notes";
            header.TitleIcon = Properties.Resources.note;
        }
    }
}
