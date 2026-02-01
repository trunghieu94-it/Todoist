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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.picAddTag = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Panel();
            this.txtAddTag = new System.Windows.Forms.TextBox();
            this.btnNotes = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnPlanned = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnPriority = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnHome = new Todoist.WinForms.Views.Components.CustomButton();
            this.WorkDetails1 = new Todoist.WinForms.Views.Components.WorkDetails();
            this.addTaskPanel1 = new Todoist.WinForms.Views.Components.AddTaskPanel();
            this.header = new Todoist.WinForms.Views.Components.Header();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.picAddTag);
            this.panel1.Controls.Add(this.divider);
            this.panel1.Controls.Add(this.txtAddTag);
            this.panel1.Controls.Add(this.btnNotes);
            this.panel1.Controls.Add(this.btnPlanned);
            this.panel1.Controls.Add(this.btnPriority);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 601);
            this.panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 318);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 21);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Learn English";
            // 
            // picAddTag
            // 
            this.picAddTag.BackColor = System.Drawing.Color.White;
            this.picAddTag.Image = global::Todoist.WinForms.Properties.Resources.add_file;
            this.picAddTag.Location = new System.Drawing.Point(166, 278);
            this.picAddTag.Name = "picAddTag";
            this.picAddTag.Size = new System.Drawing.Size(24, 24);
            this.picAddTag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddTag.TabIndex = 6;
            this.picAddTag.TabStop = false;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.divider.Location = new System.Drawing.Point(10, 258);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(180, 1);
            this.divider.TabIndex = 1;
            // 
            // txtAddTag
            // 
            this.txtAddTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTag.Location = new System.Drawing.Point(10, 275);
            this.txtAddTag.Name = "txtAddTag";
            this.txtAddTag.Size = new System.Drawing.Size(150, 29);
            this.txtAddTag.TabIndex = 4;
            this.txtAddTag.Text = "New tag";
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.White;
            this.btnNotes.BackgroundColor = System.Drawing.Color.White;
            this.btnNotes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNotes.BorderRadius = 0;
            this.btnNotes.BorderSize = 0;
            this.btnNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.ForeColor = System.Drawing.Color.Black;
            this.btnNotes.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnNotes.Icon = global::Todoist.WinForms.Properties.Resources.note;
            this.btnNotes.IconPadding = 25;
            this.btnNotes.IconSize = new System.Drawing.Size(24, 24);
            this.btnNotes.IconTextSpacing = 0;
            this.btnNotes.Location = new System.Drawing.Point(0, 215);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(200, 40);
            this.btnNotes.TabIndex = 0;
            this.btnNotes.Text = "Notes";
            this.btnNotes.TextColor = System.Drawing.Color.Black;
            this.btnNotes.UseVisualStyleBackColor = false;
            // 
            // btnPlanned
            // 
            this.btnPlanned.BackColor = System.Drawing.Color.White;
            this.btnPlanned.BackgroundColor = System.Drawing.Color.White;
            this.btnPlanned.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlanned.BorderRadius = 0;
            this.btnPlanned.BorderSize = 0;
            this.btnPlanned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanned.FlatAppearance.BorderSize = 0;
            this.btnPlanned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanned.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanned.ForeColor = System.Drawing.Color.Black;
            this.btnPlanned.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPlanned.Icon = global::Todoist.WinForms.Properties.Resources.calendar;
            this.btnPlanned.IconPadding = 25;
            this.btnPlanned.IconSize = new System.Drawing.Size(24, 24);
            this.btnPlanned.IconTextSpacing = 0;
            this.btnPlanned.Location = new System.Drawing.Point(0, 175);
            this.btnPlanned.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlanned.Name = "btnPlanned";
            this.btnPlanned.Size = new System.Drawing.Size(200, 40);
            this.btnPlanned.TabIndex = 0;
            this.btnPlanned.Text = "Planned";
            this.btnPlanned.TextColor = System.Drawing.Color.Black;
            this.btnPlanned.UseVisualStyleBackColor = false;
            // 
            // btnPriority
            // 
            this.btnPriority.BackColor = System.Drawing.Color.White;
            this.btnPriority.BackgroundColor = System.Drawing.Color.White;
            this.btnPriority.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPriority.BorderRadius = 0;
            this.btnPriority.BorderSize = 0;
            this.btnPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriority.FlatAppearance.BorderSize = 0;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriority.ForeColor = System.Drawing.Color.Black;
            this.btnPriority.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnPriority.Icon = global::Todoist.WinForms.Properties.Resources.star;
            this.btnPriority.IconPadding = 25;
            this.btnPriority.IconSize = new System.Drawing.Size(24, 24);
            this.btnPriority.IconTextSpacing = 0;
            this.btnPriority.Location = new System.Drawing.Point(0, 135);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(0);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(200, 40);
            this.btnPriority.TabIndex = 0;
            this.btnPriority.Text = "Priority";
            this.btnPriority.TextColor = System.Drawing.Color.Black;
            this.btnPriority.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundColor = System.Drawing.Color.White;
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnHome.Icon = global::Todoist.WinForms.Properties.Resources.home_2;
            this.btnHome.IconPadding = 25;
            this.btnHome.IconSize = new System.Drawing.Size(24, 24);
            this.btnHome.IconTextSpacing = 0;
            this.btnHome.Location = new System.Drawing.Point(0, 95);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // WorkDetails1
            // 
            this.WorkDetails1.Location = new System.Drawing.Point(231, 95);
            this.WorkDetails1.Name = "WorkDetails1";
            this.WorkDetails1.Size = new System.Drawing.Size(684, 490);
            this.WorkDetails1.TabIndex = 3;
            // 
            // addTaskPanel1
            // 
            this.addTaskPanel1.Location = new System.Drawing.Point(231, 95);
            this.addTaskPanel1.Name = "addTaskPanel1";
            this.addTaskPanel1.Size = new System.Drawing.Size(684, 100);
            this.addTaskPanel1.TabIndex = 2;
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(200, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(744, 75);
            this.header.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WorkDetails1);
            this.Controls.Add(this.addTaskPanel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTag)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Todoist.WinForms.Views.Components.CustomButton btnHome;
        private Components.CustomButton btnNotes;
        private Components.CustomButton btnPlanned;
        private Components.CustomButton btnPriority;
        private Components.Header header;
        private Components.AddTaskPanel addTaskPanel1;
        private System.Windows.Forms.TextBox txtAddTag;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.PictureBox picAddTag;
        private Components.WorkDetails WorkDetails1;
        private System.Windows.Forms.Label Label1;
    }
}
