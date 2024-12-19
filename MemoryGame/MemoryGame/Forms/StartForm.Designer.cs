namespace MemoryGame.Forms
{
    partial class StartForm
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
            btnStart = new Button();
            lblGame = new Label();
            lblGithub = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.ForeColor = Color.Transparent;
            btnStart.Image = Properties.Resources.start_button;
            btnStart.Location = new Point(418, 21);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(136, 56);
            btnStart.TabIndex = 1;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Font = new Font("Comic Sans MS", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGame.ForeColor = Color.White;
            lblGame.Location = new Point(95, 17);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(317, 60);
            lblGame.TabIndex = 2;
            lblGame.Text = "Memory Game";
            // 
            // lblGithub
            // 
            lblGithub.AutoSize = true;
            lblGithub.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGithub.ForeColor = Color.Black;
            lblGithub.Location = new Point(162, 124);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(326, 34);
            lblGithub.TabIndex = 3;
            lblGithub.Text = "Creator GitHub: Wexis39";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.github_sign;
            pictureBox1.Location = new Point(90, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 66);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.brain;
            pictureBox2.Location = new Point(31, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 81);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 142, 225);
            ClientSize = new Size(578, 203);
            Controls.Add(lblGame);
            Controls.Add(btnStart);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblGithub);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label lblGame;
        private Label lblGithub;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}