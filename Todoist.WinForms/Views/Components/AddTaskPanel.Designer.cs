namespace Todoist.WinForms.Views.Components
{
    partial class AddTaskPanel
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
            this.txtNewTask = new System.Windows.Forms.TextBox();
            this.picAddTask = new System.Windows.Forms.PictureBox();
            this.borderPanel2 = new BorderPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTask)).BeginInit();
            this.borderPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.Color.White;
            this.borderPanel1.BorderColor = System.Drawing.Color.Black;
            this.borderPanel1.BorderThickness = 0;
            this.borderPanel1.BottomLeftRadius = 0;
            this.borderPanel1.BottomRightRadius = 0;
            this.borderPanel1.Controls.Add(this.txtNewTask);
            this.borderPanel1.Controls.Add(this.picAddTask);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(684, 50);
            this.borderPanel1.TabIndex = 0;
            // 
            // txtNewTask
            // 
            this.txtNewTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTask.Location = new System.Drawing.Point(46, 10);
            this.txtNewTask.Name = "txtNewTask";
            this.txtNewTask.Size = new System.Drawing.Size(625, 29);
            this.txtNewTask.TabIndex = 8;
            this.txtNewTask.WordWrap = false;
            // 
            // picAddTask
            // 
            this.picAddTask.BackColor = System.Drawing.Color.White;
            this.picAddTask.Image = global::Todoist.WinForms.Properties.Resources.plus;
            this.picAddTask.Location = new System.Drawing.Point(13, 13);
            this.picAddTask.Name = "picAddTask";
            this.picAddTask.Size = new System.Drawing.Size(24, 24);
            this.picAddTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddTask.TabIndex = 7;
            this.picAddTask.TabStop = false;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.borderPanel2.BorderColor = System.Drawing.Color.Black;
            this.borderPanel2.BorderThickness = 0;
            this.borderPanel2.Controls.Add(this.pictureBox2);
            this.borderPanel2.Controls.Add(this.dtpDeadline);
            this.borderPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderPanel2.Location = new System.Drawing.Point(0, 50);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Size = new System.Drawing.Size(684, 50);
            this.borderPanel2.TabIndex = 1;
            this.borderPanel2.TopLeftRadius = 0;
            this.borderPanel2.TopRightRadius = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::Todoist.WinForms.Properties.Resources.pending;
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(46, 11);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(265, 29);
            this.dtpDeadline.TabIndex = 9;
            // 
            // AddTaskPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.borderPanel2);
            this.Name = "AddTaskPanel";
            this.Size = new System.Drawing.Size(684, 100);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTask)).EndInit();
            this.borderPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderPanel borderPanel1;
        private BorderPanel borderPanel2;
        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.PictureBox picAddTask;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
    }
}
