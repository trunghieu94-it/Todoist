namespace Todoist.WinForms.Views.Components
{
    partial class HeaderControl
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
            this.lblTitle = new Todoist.WinForms.Views.Components.IconLabel();
            this.btnSort = new Todoist.WinForms.Views.Components.CustomButton();
            this.lblDate = new Todoist.WinForms.Views.Components.IconLabel();
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
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnSort);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(744, 75);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.TopLeftRadius = 0;
            this.pnlHeader.TopRightRadius = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Icon = global::Todoist.WinForms.Properties.Resources.home_2;
            this.lblTitle.IconPadding = 4;
            this.lblTitle.IconSize = new System.Drawing.Size(24, 24);
            this.lblTitle.IconTextSpacing = 6;
            this.lblTitle.Location = new System.Drawing.Point(22, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 57);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSort.Location = new System.Drawing.Point(316, 20);
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
            this.lblDate.Location = new System.Drawing.Point(178, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Sunday, January 11";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(744, 75);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnSort;
        private IconLabel lblDate;
        private IconLabel lblTitle;
        private BorderPanel pnlHeader;
    }
}
