namespace Todoist.WinForms.Views
{
    partial class HomeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentPanel = new System.Windows.Forms.Panel();
            this.addTodoListPanel = new Todoist.WinForms.Views.Components.AddTodoList();
            this.listItems = new Todoist.WinForms.Components.TodoListsView();
            this.btnDelete = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnSelect = new Todoist.WinForms.Views.Components.CustomButton();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.listItems);
            this.contentPanel.Controls.Add(this.btnDelete);
            this.contentPanel.Controls.Add(this.btnSelect);
            this.contentPanel.Controls.Add(this.addTodoListPanel);
            this.contentPanel.Location = new System.Drawing.Point(30, 3);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(900, 442);
            this.contentPanel.TabIndex = 9;
            // 
            // addTodoListPanel
            // 
            this.addTodoListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTodoListPanel.Location = new System.Drawing.Point(0, 0);
            this.addTodoListPanel.Name = "addTodoListPanel";
            this.addTodoListPanel.Size = new System.Drawing.Size(900, 100);
            this.addTodoListPanel.TabIndex = 4;
            // 
            // listItems
            // 
            this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItems.AutoScroll = true;
            this.listItems.Location = new System.Drawing.Point(0, 145);
            this.listItems.Margin = new System.Windows.Forms.Padding(0);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(900, 281);
            this.listItems.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 30;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDelete.Icon = null;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconSize = new System.Drawing.Size(20, 20);
            this.btnDelete.IconTextSpacing = 30;
            this.btnDelete.Location = new System.Drawing.Point(832, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.Black;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSelect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSelect.BorderRadius = 30;
            this.btnSelect.BorderSize = 0;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnSelect.Icon = null;
            this.btnSelect.IconPadding = 10;
            this.btnSelect.IconSize = new System.Drawing.Size(20, 20);
            this.btnSelect.IconTextSpacing = 30;
            this.btnSelect.Location = new System.Drawing.Point(686, 106);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 36);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select/Deselect All";
            this.btnSelect.TextColor = System.Drawing.Color.Black;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(960, 448);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Components.AddTodoList addTodoListPanel;
        private Components.CustomButton btnDelete;
        private WinForms.Components.TodoListsView listItems;
        private System.Windows.Forms.Panel contentPanel;
        private Components.CustomButton btnSelect;
    }
}
