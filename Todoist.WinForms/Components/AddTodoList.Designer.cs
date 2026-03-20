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
            this.txtNewTodoItem = new System.Windows.Forms.TextBox();
            this.picAddTodoItem = new System.Windows.Forms.PictureBox();
            this.borderPanel2 = new BorderPanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picDeadline = new System.Windows.Forms.PictureBox();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoItem)).BeginInit();
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
            this.borderPanel1.Controls.Add(this.txtNewTodoItem);
            this.borderPanel1.Controls.Add(this.picAddTodoItem);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(700, 50);
            this.borderPanel1.TabIndex = 0;
            // 
            // txtNewTodoItem
            // 
            this.txtNewTodoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewTodoItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTodoItem.Location = new System.Drawing.Point(46, 10);
            this.txtNewTodoItem.Name = "txtNewTodoItem";
            this.txtNewTodoItem.Size = new System.Drawing.Size(640, 29);
            this.txtNewTodoItem.TabIndex = 8;
            this.txtNewTodoItem.WordWrap = false;
            // 
            // picAddTodoItem
            // 
            this.picAddTodoItem.BackColor = System.Drawing.Color.White;
            this.picAddTodoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddTodoItem.Image = global::Todoist.WinForms.Properties.Resources.plus;
            this.picAddTodoItem.Location = new System.Drawing.Point(13, 13);
            this.picAddTodoItem.Name = "picAddTodoItem";
            this.picAddTodoItem.Size = new System.Drawing.Size(24, 24);
            this.picAddTodoItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddTodoItem.TabIndex = 7;
            this.picAddTodoItem.TabStop = false;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.borderPanel2.BorderColor = System.Drawing.Color.Black;
            this.borderPanel2.BorderThickness = 0;
            this.borderPanel2.Controls.Add(this.dateTimePicker2);
            this.borderPanel2.Controls.Add(this.dateTimePicker1);
            this.borderPanel2.Controls.Add(this.picDeadline);
            this.borderPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderPanel2.Location = new System.Drawing.Point(0, 50);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Size = new System.Drawing.Size(700, 50);
            this.borderPanel2.TabIndex = 1;
            this.borderPanel2.TopLeftRadius = 0;
            this.borderPanel2.TopRightRadius = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(202, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 29);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 29);
            this.dateTimePicker1.TabIndex = 14;
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
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoItem)).EndInit();
            this.borderPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDeadline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderPanel borderPanel1;
        private BorderPanel borderPanel2;
        private System.Windows.Forms.TextBox txtNewTodoItem;
        private System.Windows.Forms.PictureBox picAddTodoItem;
        private System.Windows.Forms.PictureBox picDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
