using System;
using System.Windows.Forms;

using Todoist.WinForms.Models;
using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Views
{
    public partial class HomeView : UserControl
    {
        private TodoListDetails _detailsView;

        public event Action<CreateTodoList> OnTodoListSubmitted;
        
        public HomeView()
        {
            InitializeComponent();

            //Subscribe events
            listItems.OnTodoListDetailRequested += HandleDetailRequested;
            addTodoListPanel.OnSubmitted += (model) => OnTodoListSubmitted?.Invoke(model);

        }

        #region Methods
        private void ShowTodoListDetails(int listId, string listName)
        {
            try
            {
                if (_detailsView == null)
                {
                    _detailsView = new TodoListDetails();

                    _detailsView.OnCloseClicked += HandleCloseDetails;

                    _detailsView.Dock = DockStyle.Fill;
                    contentPanel.Controls.Add(_detailsView);
                }

                _detailsView.Title = listName;

                _detailsView.SetListId(listId);

                _detailsView.Show();
                _detailsView.BringToFront();
            }
            catch
            {
                MessageBox.Show("Don't show TodoListDetails");
            }
        }

        public void HandleDetailRequested(int listId, string listName)
        {
            ShowTodoListDetails(listId, listName);
        }

        private void HandleCloseDetails()
        {
            if (_detailsView != null)
            {
                _detailsView.Hide();
            }
        }
        #endregion
    }
}
