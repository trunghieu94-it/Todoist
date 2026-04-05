namespace Todoist.WinForms.Views.Components
{
    partial class TodoListView
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
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnDetail = new Todoist.WinForms.Views.Components.CustomButton();
            this.iconDelete = new System.Windows.Forms.PictureBox();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.chkTodoList = new System.Windows.Forms.CheckBox();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanel1
            // 
            this.borderPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.BorderColor = System.Drawing.Color.Black;
            this.borderPanel1.BorderThickness = 0;
            this.borderPanel1.BottomLeftRadius = 0;
            this.borderPanel1.BottomRightRadius = 0;
            this.borderPanel1.Controls.Add(this.dtpTime);
            this.borderPanel1.Controls.Add(this.dtpDate);
            this.borderPanel1.Controls.Add(this.btnDetail);
            this.borderPanel1.Controls.Add(this.iconDelete);
            this.borderPanel1.Controls.Add(this.txtListName);
            this.borderPanel1.Controls.Add(this.cboPriority);
            this.borderPanel1.Controls.Add(this.chkTodoList);
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(687, 70);
            this.borderPanel1.TabIndex = 0;
            this.borderPanel1.TopLeftRadius = 0;
            this.borderPanel1.TopRightRadius = 0;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(188, 38);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowCheckBox = true;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(139, 29);
            this.dtpTime.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(31, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(151, 29);
            this.dtpDate.TabIndex = 12;
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDetail.BorderRadius = 0;
            this.btnDetail.BorderSize = 0;
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDetail.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDetail.Icon = null;
            this.btnDetail.IconPadding = 10;
            this.btnDetail.IconSize = new System.Drawing.Size(24, 24);
            this.btnDetail.Location = new System.Drawing.Point(606, 3);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(58, 29);
            this.btnDetail.TabIndex = 11;
            this.btnDetail.Text = "Detail";
            this.btnDetail.TextColor = System.Drawing.Color.Black;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // iconDelete
            // 
            this.iconDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDelete.Image = global::Todoist.WinForms.Properties.Resources.close;
            this.iconDelete.Location = new System.Drawing.Point(669, 11);
            this.iconDelete.Name = "iconDelete";
            this.iconDelete.Size = new System.Drawing.Size(14, 14);
            this.iconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconDelete.TabIndex = 8;
            this.iconDelete.TabStop = false;
            this.iconDelete.Click += new System.EventHandler(this.IconDelete_Click);
            // 
            // txtListName
            // 
            this.txtListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListName.Location = new System.Drawing.Point(31, 3);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(475, 29);
            this.txtListName.TabIndex = 0;
            // 
            // cboPriority
            // 
            this.cboPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPriority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cboPriority.Location = new System.Drawing.Point(512, 3);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(88, 29);
            this.cboPriority.TabIndex = 7;
            // 
            // chkTodoList
            // 
            this.chkTodoList.AutoSize = true;
            this.chkTodoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTodoList.Location = new System.Drawing.Point(10, 11);
            this.chkTodoList.Name = "chkTodoList";
            this.chkTodoList.Size = new System.Drawing.Size(15, 14);
            this.chkTodoList.TabIndex = 0;
            this.chkTodoList.UseVisualStyleBackColor = true;
            this.chkTodoList.CheckedChanged += new System.EventHandler(this.ChkTodoList_CheckedChanged);
            // 
            // TodoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanel1);
            this.Name = "TodoListView";
            this.Size = new System.Drawing.Size(687, 70);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderPanel borderPanel1;
        private System.Windows.Forms.CheckBox chkTodoList;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.PictureBox iconDelete;
        private CustomButton btnDetail;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
