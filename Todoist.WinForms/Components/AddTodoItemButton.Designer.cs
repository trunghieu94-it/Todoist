namespace Todoist.WinForms.Components
{
    partial class AddTodoItemButton
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
            this.AddItemBtn = new Todoist.WinForms.Views.Components.CustomButton();
            this.SuspendLayout();
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddItemBtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddItemBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddItemBtn.BorderRadius = 30;
            this.AddItemBtn.BorderSize = 1;
            this.AddItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemBtn.FlatAppearance.BorderSize = 0;
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemBtn.ForeColor = System.Drawing.Color.Black;
            this.AddItemBtn.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.AddItemBtn.Icon = null;
            this.AddItemBtn.IconPadding = 10;
            this.AddItemBtn.IconSize = new System.Drawing.Size(20, 20);
            this.AddItemBtn.IconTextSpacing = 30;
            this.AddItemBtn.Location = new System.Drawing.Point(0, 0);
            this.AddItemBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(135, 36);
            this.AddItemBtn.TabIndex = 0;
            this.AddItemBtn.Text = "Add a new subtask";
            this.AddItemBtn.TextColor = System.Drawing.Color.Black;
            this.AddItemBtn.UseVisualStyleBackColor = false;
            // 
            // AddTodoItemButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddItemBtn);
            this.Name = "AddTodoItemButton";
            this.Size = new System.Drawing.Size(135, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Components.CustomButton AddItemBtn;
    }
}
