namespace Todoist.WinForms.Views.Components
{
    partial class TodoListDetails
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
            this.borderPanel1 = new BorderPanel();
            this.todoItemsPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTags = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnRemind = new Todoist.WinForms.Views.Components.CustomButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.Color.White;
            this.borderPanel1.BorderColor = System.Drawing.Color.Black;
            this.borderPanel1.BorderThickness = 0;
            this.borderPanel1.Controls.Add(this.todoItemsPanel);
            this.borderPanel1.Controls.Add(this.btnClose);
            this.borderPanel1.Controls.Add(this.label2);
            this.borderPanel1.Controls.Add(this.label1);
            this.borderPanel1.Controls.Add(this.btnAddTags);
            this.borderPanel1.Controls.Add(this.btnRemind);
            this.borderPanel1.Controls.Add(this.txtNotes);
            this.borderPanel1.Controls.Add(this.txtListName);
            this.borderPanel1.Controls.Add(this.pictureBox1);
            this.borderPanel1.Controls.Add(this.lblComplete);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(700, 490);
            this.borderPanel1.TabIndex = 0;
            // 
            // todoItemsPanel
            // 
            this.todoItemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoItemsPanel.Location = new System.Drawing.Point(22, 241);
            this.todoItemsPanel.Name = "todoItemsPanel";
            this.todoItemsPanel.Size = new System.Drawing.Size(655, 249);
            this.todoItemsPanel.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Todoist.WinForms.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(659, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notes";
            // 
            // btnAddTags
            // 
            this.btnAddTags.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddTags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAddTags.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddTags.BorderRadius = 30;
            this.btnAddTags.BorderSize = 0;
            this.btnAddTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTags.FlatAppearance.BorderSize = 0;
            this.btnAddTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTags.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTags.ForeColor = System.Drawing.Color.Black;
            this.btnAddTags.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAddTags.Icon = global::Todoist.WinForms.Properties.Resources.tag;
            this.btnAddTags.IconPadding = 10;
            this.btnAddTags.IconSize = new System.Drawing.Size(20, 20);
            this.btnAddTags.IconTextSpacing = 30;
            this.btnAddTags.Location = new System.Drawing.Point(138, 94);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Size = new System.Drawing.Size(71, 36);
            this.btnAddTags.TabIndex = 5;
            this.btnAddTags.Text = "Tags";
            this.btnAddTags.TextColor = System.Drawing.Color.Black;
            this.btnAddTags.UseVisualStyleBackColor = false;
            // 
            // btnRemind
            // 
            this.btnRemind.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemind.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRemind.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemind.BorderRadius = 30;
            this.btnRemind.BorderSize = 0;
            this.btnRemind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemind.FlatAppearance.BorderSize = 0;
            this.btnRemind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemind.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemind.ForeColor = System.Drawing.Color.Black;
            this.btnRemind.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnRemind.Icon = global::Todoist.WinForms.Properties.Resources.bell;
            this.btnRemind.IconPadding = 10;
            this.btnRemind.IconSize = new System.Drawing.Size(20, 20);
            this.btnRemind.IconTextSpacing = 30;
            this.btnRemind.Location = new System.Drawing.Point(22, 94);
            this.btnRemind.Name = "btnRemind";
            this.btnRemind.Size = new System.Drawing.Size(110, 36);
            this.btnRemind.TabIndex = 5;
            this.btnRemind.Text = "Remind me";
            this.btnRemind.TextColor = System.Drawing.Color.Black;
            this.btnRemind.UseVisualStyleBackColor = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(22, 170);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(655, 29);
            this.txtNotes.TabIndex = 3;
            // 
            // txtListName
            // 
            this.txtListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListName.Location = new System.Drawing.Point(22, 53);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(655, 29);
            this.txtListName.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Todoist.WinForms.Properties.Resources.archieve;
            this.pictureBox1.Location = new System.Drawing.Point(619, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblComplete
            // 
            this.lblComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(498, 17);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(113, 17);
            this.lblComplete.TabIndex = 1;
            this.lblComplete.Text = "Mark as complete";
            // 
            // TodoListDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanel1);
            this.Name = "TodoListDetails";
            this.Size = new System.Drawing.Size(700, 490);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderPanel borderPanel1;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtListName;
        private CustomButton btnRemind;
        private CustomButton btnAddTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel todoItemsPanel;
    }
}
