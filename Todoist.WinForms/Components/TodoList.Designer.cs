namespace Todoist.WinForms.Views.Components
{
    partial class TodoList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTodoListName = new System.Windows.Forms.TextBox();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.chkTodoList = new System.Windows.Forms.CheckBox();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.BorderColor = System.Drawing.Color.Black;
            this.borderPanel1.BorderThickness = 0;
            this.borderPanel1.BottomLeftRadius = 0;
            this.borderPanel1.BottomRightRadius = 0;
            this.borderPanel1.Controls.Add(this.pictureBox1);
            this.borderPanel1.Controls.Add(this.txtTodoListName);
            this.borderPanel1.Controls.Add(this.cboPriority);
            this.borderPanel1.Controls.Add(this.dtpDeadline);
            this.borderPanel1.Controls.Add(this.chkTodoList);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(700, 35);
            this.borderPanel1.TabIndex = 0;
            this.borderPanel1.TopLeftRadius = 0;
            this.borderPanel1.TopRightRadius = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Todoist.WinForms.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(676, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtTodoListName
            // 
            this.txtTodoListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTodoListName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTodoListName.Location = new System.Drawing.Point(31, 3);
            this.txtTodoListName.Name = "txtTodoListName";
            this.txtTodoListName.Size = new System.Drawing.Size(303, 29);
            this.txtTodoListName.TabIndex = 0;
            // 
            // cboPriority
            // 
            this.cboPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPriority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(550, 3);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(121, 29);
            this.cboPriority.TabIndex = 7;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeadline.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(340, 3);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(204, 29);
            this.dtpDeadline.TabIndex = 6;
            // 
            // chkTodoList
            // 
            this.chkTodoList.AutoSize = true;
            this.chkTodoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTodoList.Location = new System.Drawing.Point(9, 11);
            this.chkTodoList.Name = "chkTodoList";
            this.chkTodoList.Size = new System.Drawing.Size(15, 14);
            this.chkTodoList.TabIndex = 0;
            this.chkTodoList.UseVisualStyleBackColor = true;
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanel1);
            this.Name = "TodoList";
            this.Size = new System.Drawing.Size(700, 35);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderPanel borderPanel1;
        private System.Windows.Forms.CheckBox chkTodoList;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.TextBox txtTodoListName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
