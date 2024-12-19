namespace MemoryGame
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureHearth1 = new PictureBox();
            label2 = new Label();
            lblLevel = new Label();
            tmrStartTime = new System.Windows.Forms.Timer(components);
            lblStartTime = new Label();
            lblLevelStarting = new Label();
            pictureHearth2 = new PictureBox();
            pictureHearth3 = new PictureBox();
            tmrGame = new System.Windows.Forms.Timer(components);
            tmrConfetti = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureHearth1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHearth2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHearth3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 63);
            label1.TabIndex = 0;
            label1.Text = "Level";
            // 
            // pictureHearth1
            // 
            pictureHearth1.Image = Properties.Resources.like;
            pictureHearth1.Location = new Point(450, 12);
            pictureHearth1.Name = "pictureHearth1";
            pictureHearth1.Size = new Size(66, 63);
            pictureHearth1.TabIndex = 1;
            pictureHearth1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(321, 12);
            label2.Name = "label2";
            label2.Size = new Size(132, 63);
            label2.TabIndex = 0;
            label2.Text = "Lives";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Cambria", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevel.ForeColor = Color.DarkSlateBlue;
            lblLevel.Location = new Point(198, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(74, 79);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "1";
            // 
            // tmrStartTime
            // 
            tmrStartTime.Interval = 850;
            tmrStartTime.Tick += tmrStartTime_Tick;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.BackColor = Color.FromArgb(255, 171, 86);
            lblStartTime.Font = new Font("Comic Sans MS", 75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTime.ForeColor = Color.White;
            lblStartTime.Location = new Point(431, 432);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(206, 140);
            lblStartTime.TabIndex = 0;
            lblStartTime.Text = " 3 ";
            // 
            // lblLevelStarting
            // 
            lblLevelStarting.AutoSize = true;
            lblLevelStarting.BackColor = Color.FromArgb(43, 142, 225);
            lblLevelStarting.Font = new Font("Calibri", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevelStarting.ForeColor = Color.White;
            lblLevelStarting.Location = new Point(357, 358);
            lblLevelStarting.Name = "lblLevelStarting";
            lblLevelStarting.Size = new Size(375, 63);
            lblLevelStarting.TabIndex = 0;
            lblLevelStarting.Text = "Game is Starting";
            lblLevelStarting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureHearth2
            // 
            pictureHearth2.Image = Properties.Resources.like;
            pictureHearth2.Location = new Point(522, 12);
            pictureHearth2.Name = "pictureHearth2";
            pictureHearth2.Size = new Size(66, 63);
            pictureHearth2.TabIndex = 1;
            pictureHearth2.TabStop = false;
            // 
            // pictureHearth3
            // 
            pictureHearth3.Image = Properties.Resources.like;
            pictureHearth3.Location = new Point(594, 12);
            pictureHearth3.Name = "pictureHearth3";
            pictureHearth3.Size = new Size(66, 63);
            pictureHearth3.TabIndex = 1;
            pictureHearth3.TabStop = false;
            // 
            // tmrGame
            // 
            tmrGame.Interval = 1000;
            tmrGame.Tick += tmrGame_Tick;
            // 
            // tmrConfetti
            // 
            tmrConfetti.Interval = 1000;
            tmrConfetti.Tick += tmrConfetti_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 142, 225);
            ClientSize = new Size(724, 581);
            Controls.Add(pictureHearth3);
            Controls.Add(pictureHearth2);
            Controls.Add(pictureHearth1);
            Controls.Add(label2);
            Controls.Add(lblLevel);
            Controls.Add(lblStartTime);
            Controls.Add(lblLevelStarting);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureHearth1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHearth2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHearth3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureHearth1;
        private Label label2;
        private Label lblLevel;
        private System.Windows.Forms.Timer tmrStartTime;
        private Label lblStartTime;
        private Label lblLevelStarting;
        private PictureBox pictureHearth2;
        private PictureBox pictureHearth3;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer tmrConfetti;
    }
}
