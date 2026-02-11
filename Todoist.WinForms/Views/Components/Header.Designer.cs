namespace Todoist.WinForms.Views.Components
{
    partial class Header
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
            this.pnlHeader = new BorderPanel();
            this.lblHome = new Todoist.WinForms.Views.Components.IconLabel();
            this.btnSort = new Todoist.WinForms.Views.Components.CustomButton();
            this.lblDate = new Todoist.WinForms.Views.Components.IconLabel();
            this.btnGroup = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnGrid = new Todoist.WinForms.Views.Components.CustomButton();
            this.btnList = new Todoist.WinForms.Views.Components.CustomButton();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.BorderColor = System.Drawing.Color.Black;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.BottomLeftRadius = 0;
            this.pnlHeader.BottomRightRadius = 0;
            this.pnlHeader.Controls.Add(this.lblHome);
            this.pnlHeader.Controls.Add(this.btnSort);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.btnGroup);
            this.pnlHeader.Controls.Add(this.btnGrid);
            this.pnlHeader.Controls.Add(this.btnList);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(744, 75);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.TopLeftRadius = 0;
            this.pnlHeader.TopRightRadius = 0;
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Icon = global::Todoist.WinForms.Properties.Resources.home_2;
            this.lblHome.IconPadding = 4;
            this.lblHome.IconSize = new System.Drawing.Size(24, 24);
            this.lblHome.IconTextSpacing = 6;
            this.lblHome.Location = new System.Drawing.Point(22, 10);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(120, 57);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.Control;
            this.btnSort.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSort.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSort.BorderRadius = 10;
            this.btnSort.BorderSize = 0;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSort.Icon = global::Todoist.WinForms.Properties.Resources.swap;
            this.btnSort.IconPadding = 10;
            this.btnSort.IconSize = new System.Drawing.Size(24, 24);
            this.btnSort.IconTextSpacing = 30;
            this.btnSort.Location = new System.Drawing.Point(531, 20);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 40);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.TextColor = System.Drawing.Color.Black;
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Icon = null;
            this.lblDate.IconPadding = 4;
            this.lblDate.IconSize = new System.Drawing.Size(16, 16);
            this.lblDate.IconTextSpacing = 6;
            this.lblDate.Location = new System.Drawing.Point(148, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Sunday, January 11";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.SystemColors.Control;
            this.btnGroup.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGroup.BorderRadius = 10;
            this.btnGroup.BorderSize = 0;
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.Black;
            this.btnGroup.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGroup.Icon = global::Todoist.WinForms.Properties.Resources.group;
            this.btnGroup.IconPadding = 6;
            this.btnGroup.IconSize = new System.Drawing.Size(24, 24);
            this.btnGroup.IconTextSpacing = 30;
            this.btnGroup.Location = new System.Drawing.Point(642, 20);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(85, 40);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Group";
            this.btnGroup.TextColor = System.Drawing.Color.Black;
            this.btnGroup.UseVisualStyleBackColor = false;
            // 
            // btnGrid
            // 
            this.btnGrid.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnGrid.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGrid.BorderRadius = 10;
            this.btnGrid.BorderSize = 0;
            this.btnGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrid.FlatAppearance.BorderSize = 0;
            this.btnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrid.ForeColor = System.Drawing.Color.Black;
            this.btnGrid.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnGrid.Icon = global::Todoist.WinForms.Properties.Resources.grid;
            this.btnGrid.IconPadding = 10;
            this.btnGrid.IconSize = new System.Drawing.Size(24, 24);
            this.btnGrid.IconTextSpacing = 30;
            this.btnGrid.Location = new System.Drawing.Point(290, 20);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(85, 40);
            this.btnGrid.TabIndex = 8;
            this.btnGrid.Text = "Grid";
            this.btnGrid.TextColor = System.Drawing.Color.Black;
            this.btnGrid.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.Control;
            this.btnList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnList.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnList.BorderRadius = 10;
            this.btnList.BorderSize = 0;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.Black;
            this.btnList.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnList.Icon = global::Todoist.WinForms.Properties.Resources.list;
            this.btnList.IconPadding = 10;
            this.btnList.IconSize = new System.Drawing.Size(24, 24);
            this.btnList.IconTextSpacing = 30;
            this.btnList.Location = new System.Drawing.Point(396, 20);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(85, 40);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "List";
            this.btnList.TextColor = System.Drawing.Color.Black;
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(744, 75);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnSort;
        private CustomButton btnGroup;
        private CustomButton btnList;
        private CustomButton btnGrid;
        private IconLabel lblDate;
        private IconLabel lblHome;
        private BorderPanel pnlHeader;
    }
}
