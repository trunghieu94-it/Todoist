using System;
using System.Windows.Forms;

using Todoist.WinForms.Views.Components;

namespace Todoist.WinForms.Views
{
    public partial class HomeView : UserControl
    {
        private TodoListDetails _detailsView;

        public event Action<int> OnTodoListDetailRequested;
        public event Action OnCloseClicked;

        public HomeView()
        {
            InitializeComponent();

            // Initial values
            header.LblTitle = "Home";
            header.TitleIcon = Properties.Resources.home_2;

            listItems.OnTodoListDetailRequested += HandleDetailRequested;
        }

        #region Methods
        private void ShowTodoListDetails(int listId)
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

                _detailsView.SetListId(listId);

                _detailsView.Show();
                _detailsView.BringToFront();
            }
            catch
            {
                MessageBox.Show("Don't show TodoListDetails");
            }
        }

        public void HandleDetailRequested(int listId)
        {
            ShowTodoListDetails(listId);
        }

        private void HandleCloseDetails()
        {
            if (_detailsView != null)
            {
                _detailsView.Hide();
            }
        }
    }
    #endregion
}
