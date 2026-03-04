namespace Todoist.WinForms.Components
{
    partial class TodoLists
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
            this.todoListHeader1 = new Todoist.WinForms.Views.Components.TodoListHeader();
            this.todoList1 = new Todoist.WinForms.Views.Components.TodoList();
            this.SuspendLayout();
            // 
            // todoListHeader1
            // 
            this.todoListHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.todoListHeader1.Location = new System.Drawing.Point(0, 0);
            this.todoListHeader1.Name = "todoListHeader1";
            this.todoListHeader1.Size = new System.Drawing.Size(700, 35);
            this.todoListHeader1.TabIndex = 0;
            // 
            // todoList1
            // 
            this.todoList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.todoList1.Location = new System.Drawing.Point(0, 35);
            this.todoList1.Name = "todoList1";
            this.todoList1.Size = new System.Drawing.Size(700, 35);
            this.todoList1.TabIndex = 1;
            // 
            // TodoLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.todoList1);
            this.Controls.Add(this.todoListHeader1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TodoLists";
            this.Size = new System.Drawing.Size(700, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Components.TodoListHeader todoListHeader1;
        private Views.Components.TodoList todoList1;
    }
}
