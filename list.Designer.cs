﻿namespace ToDoList
{
    partial class list
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTodo = new TextBox();
            buttonAdd = new Button();
            checkedListBoxTodos = new CheckedListBox();
            buttonRemove = new Button();
            buttonExit = new Button();
            label1 = new Label();
            points = new Label();
            buttonSave = new Button();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // textBoxTodo
            // 
            textBoxTodo.Font = new Font("Times New Roman", 19.875F);
            textBoxTodo.Location = new Point(18, 202);
            textBoxTodo.Name = "textBoxTodo";
            textBoxTodo.Size = new Size(1240, 68);
            textBoxTodo.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Times New Roman", 19.875F);
            buttonAdd.Location = new Point(18, 290);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(296, 355);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // checkedListBoxTodos
            // 
            checkedListBoxTodos.Font = new Font("Times New Roman", 19.875F);
            checkedListBoxTodos.FormattingEnabled = true;
            checkedListBoxTodos.Location = new Point(320, 290);
            checkedListBoxTodos.Name = "checkedListBoxTodos";
            checkedListBoxTodos.Size = new Size(938, 719);
            checkedListBoxTodos.TabIndex = 2;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Times New Roman", 19.875F);
            buttonRemove.Location = new Point(18, 654);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(296, 355);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Collect\r\nrewards";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Times New Roman", 19.875F);
            buttonExit.Location = new Point(12, 1015);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(1548, 109);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(508, 41);
            label1.Name = "label1";
            label1.Size = new Size(451, 109);
            label1.TabIndex = 4;
            label1.Text = "ToDo List";
            // 
            // points
            // 
            points.AutoSize = true;
            points.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 238);
            points.Location = new Point(1342, 209);
            points.Name = "points";
            points.Size = new Size(135, 61);
            points.TabIndex = 5;
            points.Text = "####";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Times New Roman", 19.875F);
            buttonSave.Location = new Point(1264, 290);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(296, 355);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += this.buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Font = new Font("Times New Roman", 19.875F);
            buttonLoad.Location = new Point(1264, 651);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(296, 355);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Loading";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // list
            // 
            ClientSize = new Size(1579, 1136);
            Controls.Add(points);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonRemove);
            Controls.Add(checkedListBoxTodos);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTodo);
            Name = "list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxTodo;
        private Button buttonAdd;
        private CheckedListBox checkedListBoxTodos;
        private Button buttonRemove;
        private Button buttonSave;
        private Button buttonExit;
        private Label label1;
        private Label points;
        private Button buttonLoad;
    }
}
