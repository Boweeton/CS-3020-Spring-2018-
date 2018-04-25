﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS3020HW3Classes;
using MinesweeperGameClasses;

namespace CS3020HW2
{
    public partial class MainForm : Form
    {
        #region ClassLevelDeclarations

        string statsFilePath = "Data/lifetimeStats.bin";
        bool hasLostGame;
        bool hasWonGame;
        int mineCount;
        int clickedMineCount;
        int clickedCellCount;
        int gameTime;
        int shim = 18;
        int currentBoardWidth;
        const int ButtonSize = 32;
        const int BufferSize = 0;
        const int TopOffset = 50;
        public MinesweeperGame msGame = new MinesweeperGame(MinesweeperDifficulty.Easy);
        readonly Dictionary<GameImage, Bitmap> images = new Dictionary<GameImage, Bitmap>();
        Bitmap flagImage;
        MinesweeperButton[,] gameButtons;
        List<PictureBox> pictureBoxs;
        MinesweeperLifetimeStats lifetimeStats = new MinesweeperLifetimeStats();

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region EventMethods

        void OnMainForm_Load(object sender, EventArgs e)
        {
            // Load up the images
            images.Add(GameImage.Non, new Bitmap("Images/non.png"));
            images.Add(GameImage.Adj1, new Bitmap("Images/adj1.png"));
            images.Add(GameImage.Adj2, new Bitmap("Images/adj2.png"));
            images.Add(GameImage.Adj3, new Bitmap("Images/adj3.png"));
            images.Add(GameImage.Adj4, new Bitmap("Images/adj4.png"));
            images.Add(GameImage.Adj5, new Bitmap("Images/adj5.png"));
            images.Add(GameImage.Adj6, new Bitmap("Images/adj6.png"));
            images.Add(GameImage.Adj7, new Bitmap("Images/adj7.png"));
            images.Add(GameImage.Adj8, new Bitmap("Images/adj8.png"));
            images.Add(GameImage.Mine, new Bitmap("Images/mine.png"));
            flagImage = new Bitmap("Images/flag.png");

            // Load in lifetimeStats
            lifetimeStats = File.Exists(statsFilePath) ? Util.DeserializeIn(lifetimeStats, statsFilePath) : new MinesweeperLifetimeStats();

            ResetGame(lifetimeStats.LastDifficulty);
            SetUpTheForm(msGame);
        }

        void OnGameTimer_Tick(object sender, EventArgs e)
        {
            timerTextBox.Text = CreateSecondsString(gameTime);
            gameTime++;
        }

        void OnRestartGameButton_Click(object sender, EventArgs e)
        {
            OpenNewGameDialog();
        }

        void OnAboutButton_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            DialogResult dialog = MessageBox.Show(CalculateAbout(), "About");

            if (dialog == DialogResult.OK)
            {
                gameTimer.Enabled = true;
            }
        }

        void OnMainFormClosed(object sender, FormClosedEventArgs e)
        {
            // Store state
            Util.SerializeOut(lifetimeStats, statsFilePath);
        }

        #endregion

        #region HelperMethods

        void SetUpTheForm(MinesweeperGame mg)
        {
            currentBoardWidth = mg.CurrentGridSize;
            hasLostGame = false;
            hasWonGame = false;

            // Reset clicked bombs
            mineCount = 0;
            clickedMineCount = 0;
            foreach (GridCell cell in mg.Cells)
            {
                if (cell.HasMine)
                {
                    mineCount++;
                }
            }

            // Flush pictures
            if (pictureBoxs != null)
            {
                foreach (PictureBox pictureBox in pictureBoxs)
                {
                    Controls.Remove(pictureBox);
                }
            }
            pictureBoxs = new List<PictureBox>();

            // Flush the buttons and set the window size
            if (gameButtons != null)
            {
                int tmp = gameButtons.GetLength(0);
                for (int i = 0; i < tmp; i++)
                {
                    for (int j = 0; j < tmp; j++)
                    {
                        Controls.Remove(gameButtons[i, j]);
                    }
                }
            }

            gameButtons = new MinesweeperButton[mg.CurrentGridSize, mg.CurrentGridSize];

            // Define the form size and locations
            Width = (currentBoardWidth * (ButtonSize + BufferSize)) + shim;
            Height = (TopOffset + (currentBoardWidth * (ButtonSize + BufferSize)) + (3 * shim)) - 10;
            timerTextBox.Location = new Point(((Width / 2) - timerTextBox.Width) + shim,13);
            aboutButton.Location = new Point(Width - aboutButton.Width - 13 - shim, 13);

            // Create the buttons
            for (int i = 0; i < currentBoardWidth; i++)
            {
                for (int j = 0; j < currentBoardWidth; j++)
                {
                    gameButtons[i, j] = new MinesweeperButton(msGame.Cells[i, j])
                    {
                        Size = new Size(ButtonSize, ButtonSize),
                        Left = i * (ButtonSize + BufferSize),
                        Top = (j * (ButtonSize + BufferSize)) + TopOffset,
                        Height = ButtonSize,
                        Width = ButtonSize,
                        BackColor = Color.AntiqueWhite
                    };
                    gameButtons[i, j].Click += ProcessClick;
                    gameButtons[i, j].MouseDown += ProcessFlagging;
                    gameButtons[i, j].Show();
                    Controls.Add(gameButtons[i, j]);
                    PutImageUnderButton(gameButtons[i, j], gameButtons[i, j].Cell.Image);
                }
            }

            // Start the timer
            gameTimer.Interval = 1000;
            gameTimer.Enabled = true;
            gameTime = 0;
        }

        void ProcessFlagging(object sender, EventArgs e)
        {
            MinesweeperButton currentButton = (MinesweeperButton)sender;

            if (!hasLostGame && ((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                if (currentButton.IsFlagged)
                {
                    currentButton.IsFlagged = false;
                    currentButton.Image = null;
                }
                else
                {
                    currentButton.IsFlagged = true;
                    currentButton.Image = flagImage;
                }
            }
        }

        void ProcessClick(object sender, EventArgs e)
        {
            restartGameButton.Select();

            MinesweeperButton currentButton = ((MinesweeperButton)sender);

            if (!currentButton.IsFlagged && !hasLostGame && !hasWonGame)
            {
                clickedCellCount++;

                currentButton.Cell.HasBeenClicked = true;
                currentButton.Visible = false;

                switch (currentButton.Cell.Image)
                {
                    case GameImage.Non:
                        int count = currentButton.Cell.Neighbors.Count;
                        for (int i = 0; i < count; i++)
                        {
                            GridCell cell = currentButton.Cell.Neighbors[i];
                            if (!cell.HasBeenClicked)
                            {
                                gameButtons[cell.I, cell.J].PerformClick();
                            }
                        }
                        break;

                    case GameImage.Mine:
                        gameTimer.Enabled = false;

                        foreach (MinesweeperButton button in gameButtons)
                        {
                            if (button.Cell.HasMine && !button.Cell.HasBeenClicked)
                            {
                                button.Visible = false;
                                clickedMineCount++;
                            }
                        }

                        if (clickedMineCount == mineCount - 1)
                        {
                            hasLostGame = true;
                            MessageBox.Show("You Lose!","Game Over");

                            // Store the loss
                            lifetimeStats.LifetimeLosses++;
                            Util.SerializeOut(lifetimeStats, statsFilePath);
                        }
                        break;
                }

                // Check for win
                if (!hasLostGame && clickedCellCount == gameButtons.Length - mineCount)
                {
                    hasWonGame = true;

                    // Store the game
                    gameTimer.Enabled = false;
                    StoreGameWinForm sg = new StoreGameWinForm(this, lifetimeStats, gameTime, msGame.Diffaculty, statsFilePath);
                    sg.ShowDialog();
                }
            }
        }

        void CoverWithImage(Control b, GameImage gi)
        {
            PictureBox pBox = new PictureBox { Top = b.Top, Left = b.Left, Width = b.Width, Height = b.Height, Image = images[gi] };

            if (gi == GameImage.Mine)
            {
                pBox.BackColor = Color.DarkRed;
            }

            Controls.Add(pBox);
            pictureBoxs.Add(pBox);
            Controls.Remove(b);
        }

        void PutImageUnderButton(Control b, GameImage gi)
        {
            PictureBox pBox = new PictureBox { Top = b.Top, Left = b.Left, Width = b.Width, Height = b.Height, Image = images[gi] };

            if (gi == GameImage.Mine)
            {
                pBox.BackColor = Color.DarkRed;
            }

            Controls.Add(pBox);
            pictureBoxs.Add(pBox);
            b.BringToFront();
        }

        string CreateSecondsString(int time)
        {
            int minutes = time / 60;
            int seconds = time % 60;
            return $"{minutes}:{seconds:00}";
        }

        string CalculateAbout()
        {
            // Sort lifetimeStats info
            lifetimeStats.HighScores = lifetimeStats.HighScores.OrderBy(highScoreRecord => highScoreRecord.time).ToList();
            lifetimeStats.HighScores = lifetimeStats.HighScores.OrderByDescending(highScoreRecord => highScoreRecord.difficulty).ToList();

            StringBuilder sb = new StringBuilder();

            // Add the controls info
            sb.AppendLine("--- How to Play ---");
            sb.AppendLine("Click on the cells in the game");
            sb.AppendLine("The numbers represent adjacent mines");
            sb.AppendLine("Don't click on mines");
            sb.AppendLine();
            sb.AppendLine("You may right click to place/remove flags from cells");
            sb.AppendLine("This will make them un-clickable");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("--- About ---");
            sb.AppendLine("Created by Luke Soderstrom");
            sb.AppendLine("For CS 3200");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("--- Lifetime Stats ---");
            sb.AppendLine("Rank\tName\t\tTime\t\tDifficulty");
            for (int i = 0; i < lifetimeStats.HighScores.Count; i++)
            {
                HighScoreRecord hs = lifetimeStats.HighScores[i];

                if (i <= 10)
                {
                    sb.AppendLine($"[{i+1}]\t{hs.name}\t\t{CreateSecondsString(hs.time)}\t\t{hs.difficulty}");
                }
            }
            sb.AppendLine();
            sb.AppendLine($"Lifetime win/loss:  {lifetimeStats.LifetimeWins}/{lifetimeStats.LifetimeLosses}");

            return sb.ToString();
        }

        public void ResetGame(MinesweeperDifficulty difficulty)
        {
            clickedCellCount = 0;
            lifetimeStats.LastDifficulty = difficulty;
            msGame.InitializeBoard(difficulty);
            SetUpTheForm(msGame);
        }

        public void OpenNewGameDialog()
        {
            SetUpNewGameForm newGameForm = new SetUpNewGameForm(this);
            newGameForm.ShowDialog();
        }

        #endregion
    }
}