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
            this.lblSort = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblTitle = new Todoist.WinForms.Views.Components.IconLabel();
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
            this.pnlHeader.Controls.Add(this.lblSort);
            this.pnlHeader.Controls.Add(this.cbSort);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(744, 75);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.TopLeftRadius = 0;
            this.pnlHeader.TopRightRadius = 0;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(314, 30);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(67, 21);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sắp xếp:";
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Ngày tạo mới nhất",
            "Ngày tạo cũ nhất",
            "Tên (A → Z)",
            "Tên (Z → A)",
            "Deadline gần nhất",
            "Deadline xa nhất",
            "Ưu tiên thấp nhất",
            "Ưu tiên cao nhất"});
            this.cbSort.Location = new System.Drawing.Point(387, 27);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(165, 29);
            this.cbSort.TabIndex = 5;
            this.cbSort.Text = "Ngày tạo mới nhất";
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.CbSort_SelectedIndexChanged);
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
        private IconLabel lblDate;
        private IconLabel lblTitle;
        private BorderPanel pnlHeader;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblSort;
    }
}
