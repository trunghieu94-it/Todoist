namespace Todoist.WinForms.Components
{
    partial class Sidebar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAddTodoList = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Panel();
            this.txtAddTodoList = new System.Windows.Forms.TextBox();
            this.flowListNames = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotes = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnPlanned = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnAchieved = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnHome = new Todoist.WinForms.Views.Components.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowListNames);
            this.panel1.Controls.Add(this.picAddTodoList);
            this.panel1.Controls.Add(this.divider);
            this.panel1.Controls.Add(this.txtAddTodoList);
            this.panel1.Controls.Add(this.btnNotes);
            this.panel1.Controls.Add(this.btnPlanned);
            this.panel1.Controls.Add(this.btnAchieved);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 601);
            this.panel1.TabIndex = 1;
            // 
            // picAddTodoList
            // 
            this.picAddTodoList.BackColor = System.Drawing.Color.White;
            this.picAddTodoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddTodoList.Image = global::Todoist.WinForms.Properties.Resources.add_file;
            this.picAddTodoList.Location = new System.Drawing.Point(166, 289);
            this.picAddTodoList.Name = "picAddTodoList";
            this.picAddTodoList.Size = new System.Drawing.Size(24, 24);
            this.picAddTodoList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddTodoList.TabIndex = 6;
            this.picAddTodoList.TabStop = false;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.divider.Location = new System.Drawing.Point(10, 269);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(180, 1);
            this.divider.TabIndex = 1;
            // 
            // txtAddTodoList
            // 
            this.txtAddTodoList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTodoList.Location = new System.Drawing.Point(10, 286);
            this.txtAddTodoList.Name = "txtAddTodoList";
            this.txtAddTodoList.Size = new System.Drawing.Size(150, 29);
            this.txtAddTodoList.TabIndex = 4;
            this.txtAddTodoList.Text = "New todolist";
            // 
            // flowListNames
            // 
            this.flowListNames.AutoScroll = true;
            this.flowListNames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowListNames.Location = new System.Drawing.Point(10, 321);
            this.flowListNames.Name = "flowListNames";
            this.flowListNames.Size = new System.Drawing.Size(180, 277);
            this.flowListNames.TabIndex = 8;
            this.flowListNames.WrapContents = false;
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
            this.btnNotes.Click += new System.EventHandler(this.BtnNotes_Click);
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
            this.btnPlanned.Click += new System.EventHandler(this.BtnPlanned_Click);
            // 
            // btnAchieved
            // 
            this.btnAchieved.BackColor = System.Drawing.Color.White;
            this.btnAchieved.BackgroundColor = System.Drawing.Color.White;
            this.btnAchieved.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAchieved.BorderRadius = 0;
            this.btnAchieved.BorderSize = 0;
            this.btnAchieved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAchieved.FlatAppearance.BorderSize = 0;
            this.btnAchieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchieved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchieved.ForeColor = System.Drawing.Color.Black;
            this.btnAchieved.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnAchieved.Icon = global::Todoist.WinForms.Properties.Resources.star;
            this.btnAchieved.IconPadding = 25;
            this.btnAchieved.IconSize = new System.Drawing.Size(24, 24);
            this.btnAchieved.IconTextSpacing = 0;
            this.btnAchieved.Location = new System.Drawing.Point(0, 135);
            this.btnAchieved.Margin = new System.Windows.Forms.Padding(0);
            this.btnAchieved.Name = "btnAchieved";
            this.btnAchieved.Size = new System.Drawing.Size(200, 40);
            this.btnAchieved.TabIndex = 0;
            this.btnAchieved.Text = "Achieved";
            this.btnAchieved.TextColor = System.Drawing.Color.Black;
            this.btnAchieved.UseVisualStyleBackColor = false;
            this.btnAchieved.Click += new System.EventHandler(this.BtnPriority_Click);
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
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // Sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Sidebar";
            this.Size = new System.Drawing.Size(200, 601);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAddTodoList;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.TextBox txtAddTodoList;
        private Views.Components.CustomButton btnNotes;
        private Views.Components.CustomButton btnPlanned;
        private Views.Components.CustomButton btnAchieved;
        private Views.Components.CustomButton btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowListNames;
    }
}
