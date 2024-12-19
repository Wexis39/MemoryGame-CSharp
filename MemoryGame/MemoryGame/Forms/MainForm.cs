using MemoryGame.Forms;
using MemoryGame.Levels;
using System.Security.Policy;

namespace MemoryGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        LevelOne levelOne = new LevelOne();
        LevelTwo levelTwo = new LevelTwo();
        LevelThree levelThree = new LevelThree();
        LevelFour levelFour = new LevelFour();

        GameOverForm gameOverForm = new GameOverForm();

        int level = 1;
        int heart = 3;
        int levelButtonNumber = 2;
        int tmrStartTimeSecond = 3;

        BaseLevel ManageCurrentLevel;

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStartTime(level);
        }

        private void ManageGameLevels()
        {
            ResetLevelButtonNumber();

            if (isNextLevel <= 2)
            {
                ManageCurrentLevel = levelOne;
                lblLevel.Text = "1";
            }
            else if (isNextLevel > 2 && isNextLevel <= 6)
            {
                ManageCurrentLevel = levelTwo;
                lblLevel.Text = "2";
            }
            else if (isNextLevel > 6 && isNextLevel <= 10)
            {
                ManageCurrentLevel = levelThree;
                lblLevel.Text = "3";
            }
            else if (isNextLevel > 10 && isNextLevel <= 15)
            {
                ManageCurrentLevel = levelFour;
                lblLevel.Text = "4";
            }

            levelButtonNumber++;

            StartCurrentLevel();

            if (isNextLevel == 16)
            {
                WonTheGame();
            }
        }

        private void ResetLevelButtonNumber()
        {
            if (isNextLevel == 3)
            {
                levelButtonNumber = 3;
            }
            else if (isNextLevel == 7)
            {
                levelButtonNumber = 4;
            }
            else if (isNextLevel == 11)
            {
                levelButtonNumber = 3;
            }
        }

        private void WonTheGame()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];
                this.Controls.Remove(control);
                control.Dispose();
            }

            Label lblWonGame = new Label();
            lblWonGame.Text = "You Won The Game";
            lblWonGame.Font = new Font("Calibri", 54.75f, FontStyle.Bold);
            lblWonGame.Size = new Size(631, 90);
            lblWonGame.Location = new System.Drawing.Point(47, 179);
            lblWonGame.ForeColor = Color.Lime;
            lblWonGame.BackColor = Color.FromArgb(43, 142, 225);

            this.Controls.Add(lblWonGame);
        }

        int tmrGameSeconds = 2;

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            tmrGameSeconds--;
            if (tmrGameSeconds == 0)
            {
                tmrGame.Stop();
                tmrGameSeconds = 2;
                SetButtonsHide();
                SetButtonsClickEvent(ManageCurrentLevel);
            }
        }

        private void StartCurrentLevel()
        {
            RemoveExistingButtons();
            SetButtonsRandom(ManageCurrentLevel, levelButtonNumber);
            SetButtonsPosition(ManageCurrentLevel);
            SetHeart();
            tmrGame.Start();
        }
        private void RemoveExistingButtons()
        {
            List<Button> buttonsToRemove = new List<Button>();

            foreach (var item in this.Controls)
            {
                if (item is Button button)
                {
                    buttonsToRemove.Add(button);
                }
            }

            foreach (var button in buttonsToRemove)
            {
                this.Controls.Remove(button);
            }
        }

        private void SetButtonsClickEvent(BaseLevel lvl)
        {
            Button button;

            for (int i = 0; i < lvl.LevelDesign.GetLength(0); i++)
            {
                for (int j = 0; j < lvl.LevelDesign.GetLength(1); j++)
                {
                    string btnName = $"btn{i}{j}";
                    button = this.Controls[btnName] as Button;

                    if (lvl.LevelDesign[i, j] == "X")
                    {
                        button.Click += CorrectButtonClick;
                        lvl.LevelDesign[i, j] = $"{i}{j}";
                    }
                    else
                    {
                        button.Click += WrongButtonClick;
                        lvl.LevelDesign[i, j] = $"{i}{j}";
                    }
                }
            }
        }


        private void SetButtonsHide()
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;
                    btn.BackColor = Color.FromArgb(38, 118, 220);
                }
            }
        }

        private void SetStartTime(int lvl)
        {
            tmrStartTime.Start();
            lblLevelStarting.Location = new Point(185, 146);
            lblStartTime.Location = new System.Drawing.Point(259, 220);
        }
        private void tmrStartTime_Tick(object sender, EventArgs e)
        {
            lblStartTime.Text = $" {tmrStartTimeSecond} ";
            tmrStartTimeSecond--;

            if (tmrStartTimeSecond == -2)
            {
                lblLevelStarting.Hide();
                lblStartTime.Hide();
                tmrStartTime.Stop();
                ManageGameLevels();
                tmrStartTimeSecond = 3;
            }
        }
        private void SetButtonsRandom(BaseLevel lvl, int howMuchRandom)
        {
            Random random = new Random();

            for (int i = 0; i < howMuchRandom; i++)
            {
                int randomRow;
                int randomColumn;

                do
                {
                    randomRow = random.Next(0, lvl.LevelDesign.GetLength(0));
                    randomColumn = random.Next(0, lvl.LevelDesign.GetLength(1));

                } while (lvl.LevelDesign[randomRow, randomColumn] == "X");

                lvl.LevelDesign[randomRow, randomColumn] = "X";
            }
        }

        private void SetButtonsPosition(BaseLevel lvl)
        {

            int PosX = lvl.PosX;
            int PosY = lvl.PosY;

            Button button = new Button();

            for (int i = 0; i < lvl.LevelDesign.GetLength(0); i++)
            {
                PosX = lvl.PosX;
                for (int j = 0; j < lvl.LevelDesign.GetLength(1); j++)
                {
                    button = new Button();
                    if (lvl.LevelDesign[i, j] == "X")
                    {
                        button.BackColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(38, 118, 220);
                    }
                    button.Name = $"btn{i}{j}";
                    button.Size = new System.Drawing.Size(lvl.btnSize, lvl.btnSize);
                    button.Location = new System.Drawing.Point(PosX, PosY);
                    this.Controls.Add(button);

                    PosX += button.Width;
                }
                PosY += button.Height;
            }
        }

        private void WrongButtonClick(object? sender, EventArgs e)
        {
            heart--;
            SetHeart();
        }

        private void CorrectButtonClick(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            CorrectScore++;
            GameWinCheck();
            button.Click -= CorrectButtonClick;
        }

        PictureBox pictureBoxWin;
        Label lblWellDone;

        int CorrectScore = 0;
        int isNextLevel = 0;
        private void GameWinCheck()
        {
            if (CorrectScore == levelButtonNumber)
            {
                lblWellDone = new Label();
                lblWellDone.Text = "Well Done!";
                lblWellDone.Font = new Font("Sitka Small", 51.75f, FontStyle.Bold);
                lblWellDone.Size = new Size(440, 102);
                lblWellDone.Location = new System.Drawing.Point(142, 193);
                lblWellDone.ForeColor = Color.GreenYellow;
                lblWellDone.BackColor = Color.Transparent;
                this.Controls.Add(lblWellDone);
                CorrectScore = 0;
                RemoveExistingButtons();
                tmrConfetti.Start();
                pictureBoxWin = new PictureBox();
                pictureBoxWin.Image = Properties.Resources.win;
                pictureBoxWin.Size = new Size(700, 560);
                pictureBoxWin.Location = new Point(106, 12);
                this.Controls.Add(pictureBoxWin);
                isNextLevel++;
            }
        }

        int tmrConfettiSecond = 2;
        private void tmrConfetti_Tick(object sender, EventArgs e)
        {
            tmrConfettiSecond--;
            if (tmrConfettiSecond == 0)
            {
                tmrConfetti.Stop();
                pictureBoxWin.Hide();
                lblWellDone.Hide();
                tmrConfettiSecond = 2;
                heart = 3;
                ManageGameLevels();
            }
        }

        private void SetHeart()
        {
            if (heart == 3)
            {
                pictureHearth1.Show();
                pictureHearth2.Show();
                pictureHearth3.Show();
            }
            else if (heart == 2)
            {
                pictureHearth1.Show();
                pictureHearth2.Show();
                pictureHearth3.Hide();
            }
            else if (heart == 1)
            {
                pictureHearth1.Show();
                pictureHearth2.Hide();
                pictureHearth3.Hide();
            }
            else
            {
                this.Hide();
                gameOverForm.Show();
                pictureHearth1.Hide();
                pictureHearth2.Hide();
                pictureHearth3.Hide();
            }
        }
    }
}