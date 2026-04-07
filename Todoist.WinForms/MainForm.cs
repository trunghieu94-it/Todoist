using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Models.Enums;
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
        private TodoListsService _service = TodoListsService.Instance;

        private Dictionary<AppScreen, ScreenConfig> _screens;

        public MainForm()
        {
            InitializeComponent();

            SubcribeEvents();
        }

        #region Methods
        private void SubcribeEvents()
        {
            homeView.OnTodoListSubmitted += HandleTodoListCreatedAsync;

            sidebar.OnMenuClick += NavigateAsync;
            sidebar.OnSubmitted += HandleTodoListCreatedAsync;
            sidebar.OnListLabelClicked += HandleLabelClicked;

        }

        private void HandleLabelClicked(TodoList list)
        {
            homeView.HandleDetailRequested(list);
        }

        private async void NavigateAsync(AppScreen screen)
        {
            _screens = ScreenRegistry.Create();

            var config = _screens[screen];

            await config.LoadDataAsync();

            header.Title = config.Title;
            header.TitleIcon = config.TitleIcon;
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

        #region Events
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Call Services
            await TodoListsService.Instance.LoadTodoListsAsync(
                new TodoListFilter
                {
                    Status = null,
                    HasDeadline = null
                });
        }
        #endregion
    }
}
