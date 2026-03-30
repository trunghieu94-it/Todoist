using System;
using System.Windows.Forms;

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
        #region Views
        private PlannedView _plannedView;
        private AchievedView _achievedView;
        private NotesView _notesView;
        #endregion

        public event Action<int> OnTodoListDetailRequested;

        public MainForm()
        {
            InitializeComponent();

            homeView.OnTodoListSubmitted += HandleTodoListCreatedAsync;
            sidebar.OnMenuClick += Sidebar_OnMenuClick;
            sidebar.OnSubmitted += HandleTodoListCreatedAsync;
            sidebar.OnListLabelClicked += HandleLabelClicked;
        }

        #region Methods
        public void LoadView(UserControl view)
        {
            contentPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        private void HandleLabelClicked(int listId)
        {
            homeView.HandleDetailRequested(listId);
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
                    LoadView(homeView ?? (homeView = new HomeView()));
                    break;
                case "Planned":
                    LoadView(_plannedView ?? (_plannedView = new PlannedView()));
                    break;
                case "Achieved":
                    LoadView(_achievedView ?? (_achievedView= new AchievedView()));
                    break;
                case "Notes":
                    LoadView(_notesView ?? (_notesView = new NotesView()));
                    break;
            }
        }

        private async void HandleTodoListCreatedAsync(CreateTodoList model)
        {
            try
            {
                await TodoListsService.Instance.PostTodoListAsync(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo danh sách: {ex.Message}");
            }
        }
        #endregion
    }
}
