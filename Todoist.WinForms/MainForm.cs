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
        public event Action<int, List<TodoItem>> OnTodoItemsLoaded;

        private TodoItemsView _todoItemsView;

        public MainForm()
        {
            InitializeComponent();

            sidebar.OnMenuClick += Sidebar_OnMenuClick;
            homeView.OnTodoListDetailRequested += async (listId) =>
            {
                await LoadTodoItemsAsync(listId);
            };
        }

        #region Methods
        public void LoadView(UserControl view)
        {
            contentPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        private async Task LoadTodoItemsAsync(int listId)
        {
            try
            {
                var items = await TodoItemsService.Instance.GetTodoItemsAsync(listId);

                if (_todoItemsView == null)
                {
                    _todoItemsView = new TodoItemsView();
                    _todoItemsView.Dock = DockStyle.Fill;

                    contentPanel.Controls.Add(_todoItemsView);
                }

                _todoItemsView.SetListId(listId);
                _todoItemsView.SetData(listId, items);

                _todoItemsView.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load todo items");
            }
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
