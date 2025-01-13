namespace ToDoList
{
    partial class game
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
            pictureBox1 = new PictureBox();
            UpgradeBtn = new Button();
            ExitBtn = new Button();
            pointsLbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(117, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 750);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UpgradeBtn
            // 
            UpgradeBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            UpgradeBtn.Location = new Point(17, 982);
            UpgradeBtn.Name = "UpgradeBtn";
            UpgradeBtn.Size = new Size(390, 207);
            UpgradeBtn.TabIndex = 1;
            UpgradeBtn.Text = "Upgrade";
            UpgradeBtn.UseVisualStyleBackColor = true;
            UpgradeBtn.Click += UpgradeBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            ExitBtn.Location = new Point(413, 982);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(390, 207);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // pointsLbl
            // 
            pointsLbl.AutoSize = true;
            pointsLbl.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 238);
            pointsLbl.Location = new Point(335, 9);
            pointsLbl.Name = "pointsLbl";
            pointsLbl.Size = new Size(110, 49);
            pointsLbl.TabIndex = 2;
            pointsLbl.Text = "####";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(85, 77);
            label1.Name = "label1";
            label1.Size = new Size(678, 146);
            label1.TabIndex = 3;
            label1.Text = "To develop your flower \r\nyou need 50 points!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 1204);
            Controls.Add(label1);
            Controls.Add(pointsLbl);
            Controls.Add(ExitBtn);
            Controls.Add(UpgradeBtn);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(851, 1122);
            Name = "game";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button UpgradeBtn;
        private Button ExitBtn;
        private Label pointsLbl;
        private Label label1;
    }
}