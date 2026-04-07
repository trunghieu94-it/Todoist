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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowListNames = new System.Windows.Forms.FlowLayoutPanel();
            this.divider = new System.Windows.Forms.Panel();
            this.txtAddTodoList = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnActive = new Todoist.WinForms.Views.Components.CustomButton();
            this.picAddTodoList = new System.Windows.Forms.PictureBox();
            this.btnCompleted = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnPlanned = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnArchived = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnHome = new Todoist.WinForms.Views.Components.CustomButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.flowListNames);
            this.panel1.Controls.Add(this.picAddTodoList);
            this.panel1.Controls.Add(this.divider);
            this.panel1.Controls.Add(this.txtAddTodoList);
            this.panel1.Controls.Add(this.btnCompleted);
            this.panel1.Controls.Add(this.btnPlanned);
            this.panel1.Controls.Add(this.btnArchived);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 601);
            this.panel1.TabIndex = 1;
            // 
            // flowListNames
            // 
            this.flowListNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowListNames.AutoScroll = true;
            this.flowListNames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowListNames.Location = new System.Drawing.Point(10, 333);
            this.flowListNames.Name = "flowListNames";
            this.flowListNames.Size = new System.Drawing.Size(180, 265);
            this.flowListNames.TabIndex = 8;
            this.flowListNames.WrapContents = false;
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
            this.txtAddTodoList.ForeColor = System.Drawing.Color.Gray;
            this.txtAddTodoList.Location = new System.Drawing.Point(10, 286);
            this.txtAddTodoList.Name = "txtAddTodoList";
            this.txtAddTodoList.Size = new System.Drawing.Size(150, 29);
            this.txtAddTodoList.TabIndex = 4;
            this.txtAddTodoList.Text = "New todolist";
            this.txtAddTodoList.Enter += new System.EventHandler(this.TxtTitle_Enter);
            this.txtAddTodoList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.txtAddTodoList.Leave += new System.EventHandler(this.TxtTitle_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.White;
            this.btnActive.BackgroundColor = System.Drawing.Color.White;
            this.btnActive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActive.BorderRadius = 0;
            this.btnActive.BorderSize = 0;
            this.btnActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActive.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnActive.Icon = global::Todoist.WinForms.Properties.Resources.note;
            this.btnActive.IconPadding = 25;
            this.btnActive.IconSize = new System.Drawing.Size(24, 24);
            this.btnActive.IconTextSpacing = 0;
            this.btnActive.Location = new System.Drawing.Point(0, 95);
            this.btnActive.Margin = new System.Windows.Forms.Padding(0);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(200, 40);
            this.btnActive.TabIndex = 9;
            this.btnActive.Text = "Active";
            this.btnActive.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.BtnActive_Click);
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
            this.picAddTodoList.Click += new System.EventHandler(this.PicAddTodoList_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.White;
            this.btnCompleted.BackgroundColor = System.Drawing.Color.White;
            this.btnCompleted.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCompleted.BorderRadius = 0;
            this.btnCompleted.BorderSize = 0;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.FlatAppearance.BorderSize = 0;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCompleted.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnCompleted.Icon = global::Todoist.WinForms.Properties.Resources.done;
            this.btnCompleted.IconPadding = 25;
            this.btnCompleted.IconSize = new System.Drawing.Size(24, 24);
            this.btnCompleted.IconTextSpacing = 0;
            this.btnCompleted.Location = new System.Drawing.Point(0, 215);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(200, 40);
            this.btnCompleted.TabIndex = 0;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.BtnCompleted_Click);
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
            this.btnPlanned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btnPlanned.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlanned.UseVisualStyleBackColor = false;
            this.btnPlanned.Click += new System.EventHandler(this.BtnPlanned_Click);
            // 
            // btnArchived
            // 
            this.btnArchived.BackColor = System.Drawing.Color.White;
            this.btnArchived.BackgroundColor = System.Drawing.Color.White;
            this.btnArchived.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnArchived.BorderRadius = 0;
            this.btnArchived.BorderSize = 0;
            this.btnArchived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchived.FlatAppearance.BorderSize = 0;
            this.btnArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnArchived.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnArchived.Icon = global::Todoist.WinForms.Properties.Resources.star;
            this.btnArchived.IconPadding = 25;
            this.btnArchived.IconSize = new System.Drawing.Size(24, 24);
            this.btnArchived.IconTextSpacing = 0;
            this.btnArchived.Location = new System.Drawing.Point(0, 135);
            this.btnArchived.Margin = new System.Windows.Forms.Padding(0);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(200, 40);
            this.btnArchived.TabIndex = 0;
            this.btnArchived.Text = "Archived";
            this.btnArchived.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnArchived.UseVisualStyleBackColor = false;
            this.btnArchived.Click += new System.EventHandler(this.BtnArchived_Click);
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
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnHome.Icon = global::Todoist.WinForms.Properties.Resources.home_2;
            this.btnHome.IconPadding = 25;
            this.btnHome.IconSize = new System.Drawing.Size(24, 24);
            this.btnHome.IconTextSpacing = 0;
            this.btnHome.Location = new System.Drawing.Point(0, 55);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLogo.Location = new System.Drawing.Point(74, 14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(103, 37);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "Todoist";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Todoist.WinForms.Properties.Resources.to_do_list;
            this.picLogo.Location = new System.Drawing.Point(28, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(40, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTodoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAddTodoList;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.TextBox txtAddTodoList;
        private Views.Components.CustomButton btnCompleted;
        private Views.Components.CustomButton btnPlanned;
        private Views.Components.CustomButton btnArchived;
        private Views.Components.CustomButton btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowListNames;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Views.Components.CustomButton btnActive;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
    }
}
