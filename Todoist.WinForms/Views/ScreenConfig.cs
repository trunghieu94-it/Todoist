using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Todoist.WinForms.Views
{
    public class ScreenConfig
    {
        public string Title { get; set; }
        public Image TitleIcon { get; set; }
        public Func<Task> LoadDataAsync { get; set; }
    }
}
