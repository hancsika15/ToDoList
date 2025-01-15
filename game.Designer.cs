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
            pictureBox1.Location = new Point(63, 106);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UpgradeBtn
            // 
            UpgradeBtn.BackColor = Color.LightCoral;
            UpgradeBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            UpgradeBtn.Location = new Point(9, 460);
            UpgradeBtn.Margin = new Padding(2);
            UpgradeBtn.Name = "UpgradeBtn";
            UpgradeBtn.Size = new Size(210, 61);
            UpgradeBtn.TabIndex = 1;
            UpgradeBtn.Text = "Upgrade";
            UpgradeBtn.UseVisualStyleBackColor = false;
            UpgradeBtn.Click += UpgradeBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.LightCoral;
            ExitBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            ExitBtn.Location = new Point(222, 460);
            ExitBtn.Margin = new Padding(2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(210, 61);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // pointsLbl
            // 
            pointsLbl.AutoSize = true;
            pointsLbl.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 238);
            pointsLbl.Location = new Point(180, 4);
            pointsLbl.Margin = new Padding(2, 0, 2, 0);
            pointsLbl.Name = "pointsLbl";
            pointsLbl.Size = new Size(56, 25);
            pointsLbl.TabIndex = 2;
            pointsLbl.Text = "####";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(46, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 72);
            label1.TabIndex = 3;
            label1.Text = "To develop your flower \r\nyou need 50 points!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(451, 532);
            Controls.Add(label1);
            Controls.Add(pointsLbl);
            Controls.Add(ExitBtn);
            Controls.Add(UpgradeBtn);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            MaximumSize = new Size(467, 571);
            MinimumSize = new Size(467, 571);
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