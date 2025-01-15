namespace ToDoList
{
    partial class menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ToDoListBtn = new Button();
            GameBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(27, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 55);
            label1.TabIndex = 0;
            label1.Text = "ToDoList";
            // 
            // ToDoListBtn
            // 
            ToDoListBtn.AllowDrop = true;
            ToDoListBtn.BackColor = Color.LightCoral;
            ToDoListBtn.Font = new Font("Times New Roman", 28.125F, FontStyle.Bold);
            ToDoListBtn.Location = new Point(8, 117);
            ToDoListBtn.Margin = new Padding(2, 1, 2, 1);
            ToDoListBtn.Name = "ToDoListBtn";
            ToDoListBtn.Size = new Size(274, 82);
            ToDoListBtn.TabIndex = 1;
            ToDoListBtn.Text = "List";
            ToDoListBtn.UseVisualStyleBackColor = false;
            ToDoListBtn.Click += ToDoListBtn_Click;
            // 
            // GameBtn
            // 
            GameBtn.BackColor = Color.LightCoral;
            GameBtn.Font = new Font("Times New Roman", 28.125F, FontStyle.Bold);
            GameBtn.Location = new Point(8, 216);
            GameBtn.Margin = new Padding(2, 1, 2, 1);
            GameBtn.Name = "GameBtn";
            GameBtn.Size = new Size(274, 82);
            GameBtn.TabIndex = 2;
            GameBtn.Text = "Game";
            GameBtn.UseVisualStyleBackColor = false;
            GameBtn.Click += GameBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.LightCoral;
            ExitBtn.Font = new Font("Times New Roman", 28.125F, FontStyle.Bold);
            ExitBtn.Location = new Point(8, 315);
            ExitBtn.Margin = new Padding(2, 1, 2, 1);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(274, 82);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(289, 403);
            Controls.Add(ExitBtn);
            Controls.Add(GameBtn);
            Controls.Add(ToDoListBtn);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "menu";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ToDoListBtn;
        private Button GameBtn;
        private Button ExitBtn;
    }
}