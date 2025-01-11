namespace ToDoList
{
    partial class Form2
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
            label1.Location = new Point(50, 62);
            label1.Name = "label1";
            label1.Size = new Size(427, 109);
            label1.TabIndex = 0;
            label1.Text = "ToDoList";
            // 
            // ToDoListBtn
            // 
            ToDoListBtn.AllowDrop = true;
            ToDoListBtn.Font = new Font("Times New Roman", 28.125F, FontStyle.Bold);
            ToDoListBtn.Location = new Point(15, 249);
            ToDoListBtn.Name = "ToDoListBtn";
            ToDoListBtn.Size = new Size(509, 174);
            ToDoListBtn.TabIndex = 1;
            ToDoListBtn.Text = "List";
            ToDoListBtn.UseVisualStyleBackColor = true;
            ToDoListBtn.Click += ToDoListBtn_Click;
            // 
            // GameBtn
            // 
            GameBtn.Font = new Font("Times New Roman", 28.125F, FontStyle.Bold);
            GameBtn.Location = new Point(15, 460);
            GameBtn.Name = "GameBtn";
            GameBtn.Size = new Size(509, 174);
            GameBtn.TabIndex = 2;
            GameBtn.Text = "Game";
            GameBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Times New Roman", 28.125F, FontStyle.Bold);
            ExitBtn.Location = new Point(15, 671);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(509, 174);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 859);
            Controls.Add(ExitBtn);
            Controls.Add(GameBtn);
            Controls.Add(ToDoListBtn);
            Controls.Add(label1);
            Name = "Form2";
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