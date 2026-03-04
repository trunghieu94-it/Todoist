namespace Todoist.WinForms.Views
{
    partial class PriorityView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriorityView));
            this.header = new Todoist.WinForms.Views.Components.HeaderControl();
            this.addTodoList1 = new Todoist.WinForms.Views.Components.AddTodoList();
            this.btnDelete = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnSelect = new Todoist.WinForms.Views.Components.CustomButton();
            this.todoLists1 = new Todoist.WinForms.Components.TodoLists();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.LblTitle = "Home";
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(760, 75);
            this.header.TabIndex = 0;
            this.header.TitleIcon = ((System.Drawing.Image)(resources.GetObject("header.TitleIcon")));
            // 
            // addTodoList1
            // 
            this.addTodoList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTodoList1.Location = new System.Drawing.Point(30, 81);
            this.addTodoList1.Name = "addTodoList1";
            this.addTodoList1.Size = new System.Drawing.Size(700, 100);
            this.addTodoList1.TabIndex = 1;
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
            this.btnDelete.Location = new System.Drawing.Point(665, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 36);
            this.btnDelete.TabIndex = 10;
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
            this.btnSelect.Location = new System.Drawing.Point(519, 187);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 36);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Select/Deselect All";
            this.btnSelect.TextColor = System.Drawing.Color.Black;
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // todoLists1
            // 
            this.todoLists1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoLists1.Location = new System.Drawing.Point(30, 226);
            this.todoLists1.Margin = new System.Windows.Forms.Padding(0);
            this.todoLists1.Name = "todoLists1";
            this.todoLists1.Size = new System.Drawing.Size(700, 394);
            this.todoLists1.TabIndex = 8;
            // 
            // PriorityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.todoLists1);
            this.Controls.Add(this.addTodoList1);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PriorityView";
            this.Size = new System.Drawing.Size(760, 640);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.HeaderControl header;
        private Components.AddTodoList addTodoList1;
        private Components.CustomButton btnDelete;
        private Components.CustomButton btnSelect;
        private WinForms.Components.TodoLists todoLists1;
    }
}
