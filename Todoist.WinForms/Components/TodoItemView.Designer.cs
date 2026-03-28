namespace Todoist.WinForms.Components
{
    partial class TodoItemView
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.iconDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(435, 29);
            this.txtTitle.TabIndex = 9;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
            this.cboStatus.Location = new System.Drawing.Point(441, 0);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(110, 29);
            this.cboStatus.TabIndex = 10;
            // 
            // iconDelete
            // 
            this.iconDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDelete.Image = global::Todoist.WinForms.Properties.Resources.close;
            this.iconDelete.Location = new System.Drawing.Point(559, 8);
            this.iconDelete.Name = "iconDelete";
            this.iconDelete.Size = new System.Drawing.Size(14, 14);
            this.iconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconDelete.TabIndex = 11;
            this.iconDelete.TabStop = false;
            // 
            // TodoItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconDelete);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cboStatus);
            this.Name = "TodoItemView";
            this.Size = new System.Drawing.Size(581, 29);
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconDelete;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}
