using System;
using System.Diagnostics;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Views
{
    public partial class HomeView : UserControl
    {
        public event Action<int> OnTodoListDetailRequested;
        public event Action<TodoListDetails> OnCloseClicked;
        public event Action<CreateTodoList> OnTodoListSubmitted;

        public HomeView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Home";
            header.TitleIcon = Properties.Resources.home_2;


            //Subscribe events
            listItems.OnTodoListDetailRequested += HandleDetailRequested;
            addTodoListPanel.OnSubmitted += (model) => OnTodoListSubmitted?.Invoke(model);

        }

        #region Methods
        private void ShowTodoListDetails(int listId)
        {
            try
            {
                TodoListDetails detailsView = new TodoListDetails();
                detailsView.SetListId(listId);

                detailsView.OnCloseClicked += HandleCloseDetails;

                detailsView.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(detailsView);
                detailsView.BringToFront();
            }
            catch
            {
                MessageBox.Show("Don't show TodoListDetails");
            }
        }

        private void HandleDetailRequested(int listId)
        {
            ShowTodoListDetails(listId);
        }

        private void HandleCloseDetails(TodoListDetails detailsView)
        {
            detailsView.OnCloseClicked -= HandleCloseDetails;

            contentPanel.Controls.Remove(detailsView);
            detailsView.Dispose();
        }

        #endregion
    }
}
