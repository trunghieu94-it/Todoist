using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Todoist.WinForms.Components;
using Todoist.WinForms.Models;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views
{
    /* ARCHITECTURE NOTE:
        - TodoLists = global state → managed by service events
        - TodoItems = contextual (by listId) → loaded via explicit calls here
        - This form acts as the orchestrator between UI and services.
    */
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
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Call Services
            await TodoListsService.Instance.GetTodoListsAsync();
        }

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
