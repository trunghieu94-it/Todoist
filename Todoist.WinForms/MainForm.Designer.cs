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
            this.contentPanel = new BorderPanel();
            this.sidebar1 = new Todoist.WinForms.Components.Sidebar();
            this.homeView1 = new Todoist.WinForms.Views.HomeView();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.BorderColor = System.Drawing.Color.Black;
            this.contentPanel.BorderThickness = 0;
            this.contentPanel.BottomLeftRadius = 0;
            this.contentPanel.BottomRightRadius = 0;
            this.contentPanel.Controls.Add(this.homeView1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(784, 601);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.TopLeftRadius = 0;
            this.contentPanel.TopRightRadius = 0;
            // 
            // sidebar1
            // 
            this.sidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar1.Location = new System.Drawing.Point(0, 0);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(200, 601);
            this.sidebar1.TabIndex = 0;
            // 
            // homeView1
            // 
            this.homeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeView1.Location = new System.Drawing.Point(0, 0);
            this.homeView1.Margin = new System.Windows.Forms.Padding(0);
            this.homeView1.Name = "homeView1";
            this.homeView1.Size = new System.Drawing.Size(784, 601);
            this.homeView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebar1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BorderPanel contentPanel;
        private WinForms.Components.Sidebar sidebar1;
        private HomeView homeView1;
    }
}
