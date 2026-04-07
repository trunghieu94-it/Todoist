namespace Todoist.WinForms.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.homeView = new Todoist.WinForms.Views.HomeView();
            this.header = new Todoist.WinForms.Views.Components.HeaderControl();
            this.sidebar = new Todoist.WinForms.Components.Sidebar();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.homeView);
            this.contentPanel.Controls.Add(this.header);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(784, 601);
            this.contentPanel.TabIndex = 1;
            // 
            // homeView
            // 
            this.homeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeView.Location = new System.Drawing.Point(0, 75);
            this.homeView.Margin = new System.Windows.Forms.Padding(0);
            this.homeView.Name = "homeView";
            this.homeView.Size = new System.Drawing.Size(784, 526);
            this.homeView.TabIndex = 2;
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(784, 75);
            this.header.TabIndex = 1;
            this.header.Title = "Home";
            this.header.TitleIcon = ((System.Drawing.Image)(resources.GetObject("header.TitleIcon")));
            // 
            // sidebar
            // 
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 601);
            this.sidebar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todoist - Quản lý công việc";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private WinForms.Components.Sidebar sidebar;
        private System.Windows.Forms.Panel contentPanel;
        private Components.HeaderControl header;
        private HomeView homeView;
    }
}
