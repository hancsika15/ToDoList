﻿namespace ToDoList
{
    partial class Form1
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
            buttonSave = new Button();
            buttonLoad = new Button();
            label1 = new Label();
            points = new Label();
            SuspendLayout();
            // 
            // textBoxTodo
            // 
            textBoxTodo.Font = new Font("Times New Roman", 19.875F);
            textBoxTodo.Location = new Point(18, 202);
            textBoxTodo.Name = "textBoxTodo";
            textBoxTodo.Size = new Size(1132, 68);
            textBoxTodo.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Times New Roman", 19.875F);
            buttonAdd.Location = new Point(18, 290);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(296, 355);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Hozzáadás";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // checkedListBoxTodos
            // 
            checkedListBoxTodos.Font = new Font("Times New Roman", 19.875F);
            checkedListBoxTodos.FormattingEnabled = true;
            checkedListBoxTodos.Location = new Point(320, 290);
            checkedListBoxTodos.Name = "checkedListBoxTodos";
            checkedListBoxTodos.Size = new Size(830, 719);
            checkedListBoxTodos.TabIndex = 2;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Times New Roman", 19.875F);
            buttonRemove.Location = new Point(18, 654);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(296, 355);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Eltávolítás";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Times New Roman", 19.875F);
            buttonSave.Location = new Point(1156, 654);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(296, 355);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Font = new Font("Times New Roman", 19.875F);
            buttonLoad.Location = new Point(1156, 290);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(296, 355);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Betöltés";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
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
            points.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            points.Location = new Point(1212, 209);
            points.Name = "points";
            points.Size = new Size(0, 61);
            points.TabIndex = 5;
            // 
            // Form1
            // 
            ClientSize = new Size(1464, 1021);
            Controls.Add(points);
            Controls.Add(label1);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonRemove);
            Controls.Add(checkedListBoxTodos);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTodo);
            MaximumSize = new Size(1490, 1092);
            MinimumSize = new Size(1490, 1092);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxTodo;
        private Button buttonAdd;
        private CheckedListBox checkedListBoxTodos;
        private Button buttonRemove;
        private Button buttonSave;
        private Button buttonLoad;
        private Label label1;
        private Label points;
    }
}
