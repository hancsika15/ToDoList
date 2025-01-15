namespace ToDoList
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
            textBoxTodo.Location = new Point(12, 133);
            textBoxTodo.Name = "textBoxTodo";
            textBoxTodo.Size = new Size(912, 38);
            textBoxTodo.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightCoral;
            buttonAdd.Font = new Font("Times New Roman", 19.875F);
            buttonAdd.Location = new Point(12, 185);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(206, 229);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // checkedListBoxTodos
            // 
            checkedListBoxTodos.Font = new Font("Times New Roman", 19.875F);
            checkedListBoxTodos.FormattingEnabled = true;
            checkedListBoxTodos.Location = new Point(224, 185);
            checkedListBoxTodos.Name = "checkedListBoxTodos";
            checkedListBoxTodos.Size = new Size(700, 466);
            checkedListBoxTodos.TabIndex = 2;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.LightCoral;
            buttonRemove.Font = new Font("Times New Roman", 19.875F);
            buttonRemove.Location = new Point(12, 422);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(206, 229);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Collect\r\nrewards";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.LightCoral;
            buttonExit.Font = new Font("Times New Roman", 19.875F);
            buttonExit.Location = new Point(13, 657);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(1124, 75);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(478, 39);
            label1.Name = "label1";
            label1.Size = new Size(227, 55);
            label1.TabIndex = 4;
            label1.Text = "ToDo List";
            // 
            // points
            // 
            points.AutoSize = true;
            points.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 238);
            points.Location = new Point(979, 133);
            points.Name = "points";
            points.Size = new Size(70, 31);
            points.TabIndex = 5;
            points.Text = "####";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightCoral;
            buttonSave.Font = new Font("Times New Roman", 19.875F);
            buttonSave.Location = new Point(930, 185);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(206, 229);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.LightCoral;
            buttonLoad.Font = new Font("Times New Roman", 19.875F);
            buttonLoad.Location = new Point(930, 422);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(206, 229);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Loading";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // list
            // 
            BackColor = Color.MistyRose;
            ClientSize = new Size(1149, 753);
            Controls.Add(points);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonRemove);
            Controls.Add(checkedListBoxTodos);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTodo);
            MaximumSize = new Size(1165, 792);
            MinimumSize = new Size(1165, 792);
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
