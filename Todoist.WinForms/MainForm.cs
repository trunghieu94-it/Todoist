using System;
using System.Windows.Forms;

using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            sidebar.OnMenuClick += Sidebar_OnMenuClick;
        }

        #region Methods
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            await TodoListsService.Instance.GetTodoListsAsync();
        }

        public void LoadView(UserControl view)
        {
            contentPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }
        #endregion

        #region Events
        private void Sidebar_OnMenuClick(string menu)
        {
            switch (menu)
            {
                case "Home":
                    LoadView(new HomeView());
                    break;
                case "Planned":
                    LoadView(new PlannedView());
                    break;
                case "Achieved":
                    LoadView(new AchievedView());
                    break;
                case "Notes":
                    LoadView(new NotesView());
                    break;
            }
        }
        #endregion
    }
}
