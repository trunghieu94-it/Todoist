namespace Todoist.WinForms.Views.Components
{
    partial class AddTodoList
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
            this.txtNewTodoList = new System.Windows.Forms.TextBox();
            this.picAddTodoList = new System.Windows.Forms.PictureBox();
            this.borderPanel2 = new BorderPanel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.picDeadline = new System.Windows.Forms.PictureBox();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoList)).BeginInit();
            this.borderPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadline)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.Color.White;
            this.borderPanel1.BorderColor = System.Drawing.Color.Black;
            this.borderPanel1.BorderThickness = 0;
            this.borderPanel1.BottomLeftRadius = 0;
            this.borderPanel1.BottomRightRadius = 0;
            this.borderPanel1.Controls.Add(this.txtNewTodoList);
            this.borderPanel1.Controls.Add(this.picAddTodoList);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(700, 50);
            this.borderPanel1.TabIndex = 0;
            // 
            // txtNewTodoList
            // 
            this.txtNewTodoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewTodoList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTodoList.Location = new System.Drawing.Point(46, 10);
            this.txtNewTodoList.Name = "txtNewTodoList";
            this.txtNewTodoList.Size = new System.Drawing.Size(640, 29);
            this.txtNewTodoList.TabIndex = 8;
            this.txtNewTodoList.WordWrap = false;
            // 
            // picAddTodoList
            // 
            this.picAddTodoList.BackColor = System.Drawing.Color.White;
            this.picAddTodoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddTodoList.Image = global::Todoist.WinForms.Properties.Resources.plus;
            this.picAddTodoList.Location = new System.Drawing.Point(13, 13);
            this.picAddTodoList.Name = "picAddTodoList";
            this.picAddTodoList.Size = new System.Drawing.Size(24, 24);
            this.picAddTodoList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddTodoList.TabIndex = 7;
            this.picAddTodoList.TabStop = false;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.borderPanel2.BorderColor = System.Drawing.Color.Black;
            this.borderPanel2.BorderThickness = 0;
            this.borderPanel2.Controls.Add(this.dtpTime);
            this.borderPanel2.Controls.Add(this.dtpDate);
            this.borderPanel2.Controls.Add(this.picDeadline);
            this.borderPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderPanel2.Location = new System.Drawing.Point(0, 50);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Size = new System.Drawing.Size(700, 50);
            this.borderPanel2.TabIndex = 1;
            this.borderPanel2.TopLeftRadius = 0;
            this.borderPanel2.TopRightRadius = 0;
            // 
            // dtpTime
            // 
            this.dtpTime.Checked = false;
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(202, 10);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowCheckBox = true;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(139, 29);
            this.dtpTime.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(46, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(150, 29);
            this.dtpDate.TabIndex = 14;
            // 
            // picDeadline
            // 
            this.picDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picDeadline.BackColor = System.Drawing.SystemColors.Control;
            this.picDeadline.Image = global::Todoist.WinForms.Properties.Resources.pending;
            this.picDeadline.Location = new System.Drawing.Point(13, 14);
            this.picDeadline.Name = "picDeadline";
            this.picDeadline.Size = new System.Drawing.Size(24, 24);
            this.picDeadline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeadline.TabIndex = 10;
            this.picDeadline.TabStop = false;
            // 
            // AddTodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.borderPanel2);
            this.Name = "AddTodoList";
            this.Size = new System.Drawing.Size(700, 100);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoList)).EndInit();
            this.borderPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDeadline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderPanel borderPanel1;
        private BorderPanel borderPanel2;
        private System.Windows.Forms.TextBox txtNewTodoList;
        private System.Windows.Forms.PictureBox picAddTodoList;
        private System.Windows.Forms.PictureBox picDeadline;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
