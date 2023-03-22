using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxGame
{
    public partial class Game : Form
    {
        /***** VARIABLES *****/
        private int windowWidth = 1900;
        private int windowHeight = 900;
        private string mode;
        private bool isGameStarted = false;
        private int mainTime;
        private int time;
        private int playerOnePoints = 0;
        private int playerTwoPoints = 0;
        private int playerThreePoints = 0;
        private int playerFourPoints = 0;
        private Random rnd = new Random();
        private int maxTopRandom;
        private int maxLeftRandom;
        private List<string> usernames = new List<string>();
        private List<Color> colors = new List<Color>();
        private List<PictureBox> playerObjects;
        private List<Label> listOfLabels;

        public Game(string gameMode, int gameTime, List<string> names, List<Color> userColors)
        {
            mode = gameMode;
            mainTime = gameTime;
            time = gameTime;
            usernames = names;
            colors = userColors;

            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            SetResolution();
            SetGameMode(mode);
            DefaultValuesFunction();
        }

        private void SetResolution()
        {
            int userScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int userScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            int remainderWidth = userScreenWidth % 100;
            if (remainderWidth >= 20)
            {
                windowWidth = userScreenWidth - remainderWidth;
            }
            else
            {
                windowWidth = (userScreenWidth - 100) - remainderWidth;
            }

            int remainderHeight = userScreenHeight % 100;
            if (remainderHeight >= 43)
            {
                windowHeight = userScreenHeight - remainderHeight;
            }
            else
            {
                windowHeight = (userScreenHeight - 100) - remainderHeight;
            }
        }

        private void SetGameMode(string gameMode)
        {
            switch (gameMode[0])
            {
                case '1':
                    playerObjects = new List<PictureBox> { playerOneObject };
                    listOfLabels = new List<Label> { playerOneScoreLabel, playerOneScoreValueLabel, playerOneInfoLabel, infoForAllUsersLabel };
                    break;

                case '2':
                    playerObjects = new List<PictureBox> { playerOneObject, playerTwoObject };
                    listOfLabels = new List<Label> { playerOneScoreLabel, playerOneScoreValueLabel, playerOneInfoLabel, playerTwoScoreLabel, playerTwoScoreValueLabel, playerTwoInfoLabel, infoForAllUsersLabel };
                    break;

                case '3':
                    playerObjects = new List<PictureBox> { playerOneObject, playerTwoObject, playerThreeObject };
                    listOfLabels = new List<Label> { playerOneScoreLabel, playerOneScoreValueLabel, playerOneInfoLabel, playerTwoScoreLabel, playerTwoScoreValueLabel, playerTwoInfoLabel, playerThreeScoreLabel, playerThreeScoreValueLabel, playerThreeInfoLabel, infoForAllUsersLabel };
                    break;

                case '4':
                    playerObjects = new List<PictureBox> { playerOneObject, playerTwoObject, playerThreeObject, playerFourObject };
                    listOfLabels = new List<Label> { playerOneScoreLabel, playerOneScoreValueLabel, playerOneInfoLabel, playerTwoScoreLabel, playerTwoScoreValueLabel, playerTwoInfoLabel, playerThreeScoreLabel, playerThreeScoreValueLabel, playerThreeInfoLabel, playerFourScoreLabel, playerFourScoreValueLabel, playerFourScoreValueLabel, playerFourInfoLabel, infoForAllUsersLabel };
                    break;
            }

            if (colors.Count != 0)
            {
                SetColors();
            }

            SetLabels();
            EnableAndVisiblePictureBoxes(true);
        }

        private void SetColors()
        {
            for (int i = 0; i < playerObjects.Count; i++)
            {
                playerObjects[i].BackColor = colors[i];
            }
        }

        private void SetLabels()
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < listOfLabels.Count; i++)
            {
                if (listOfLabels[i].Name.Contains("ScoreLabel"))
                {
                    listOfLabels[i].Text = $"{usernames[a]}:";
                    a++;
                }

                if (listOfLabels[i].Name.Contains("InfoLabel"))
                {
                    listOfLabels[i].Text = SetInfoLabelValues(b, usernames[b]);
                    b++;
                }
            }

            switch (b)
            {
                case 1:
                    allInfoLabelPanel.Width = 163;
                    break;

                case 2:
                    allInfoLabelPanel.Width = 326;
                    break;

                case 3:
                    allInfoLabelPanel.Width = 489;
                    break;
            }
        }

        private string SetInfoLabelValues(int number, string name)
        {
            string returnedValue = "";

            switch (number)
            {
                case 0:
                    returnedValue = $"{name}\nUP\t-\t'w'\nDOWN\t-\t's'\nLEFT\t-\t'a'\nRIGHT\t-\t'd'";
                    break;

                case 1:
                    returnedValue = $"{name}\nUP\t-\t'ArrowUp'\nDOWN\t-\t'ArrowDown'\nLEFT\t-\t'ArrowLeft'\nRIGHT\t-\t'ArrowRight'";
                    break;

                case 2:
                    returnedValue = $"{name}\nUP\t-\t'Num8'\nDOWN\t-\t'Num5'\nLEFT\t-\t'Num4'\nRIGHT\t-\t'Num6'";
                    break;

                case 3:
                    returnedValue = $"{name}\nUP\t-\t'i'\nDOWN\t-\t'k'\nLEFT\t-\t'j'\nRIGHT\t-\t'l'";
                    break;
            }

            return returnedValue;
        }

        private void EnableAndVisiblePictureBoxes(bool isActive)
        {
            foreach (PictureBox pictureBox in playerObjects)
            {
                pictureBox.Enabled = isActive;
                pictureBox.Visible = isActive;
            }

            foreach (Label label in listOfLabels)
            {
                label.Enabled = isActive;
                label.Visible = isActive;
            }
        }

        private void DefaultValuesFunction()
        {
            this.Width = windowWidth + 20;
            this.Height = windowHeight + 43;
            this.Top = 0;
            this.Left = 0;

            maxTopRandom = (windowHeight / 50);
            maxLeftRandom = (windowWidth / 50);

            timeLabel.Left = (this.ClientSize.Width / 2) - (timeLabel.Width / 2);

            SetPanelToCenter();
            SetPlayerObjectPosition();
            GeneratingRandomObjectPosition();
        }

        private void SetPanelToCenter()
        {
            allInfoLabelPanel.Top = (this.ClientSize.Height / 2) + 10;
            allInfoLabelPanel.Left = (this.ClientSize.Width / 2) - (allInfoLabelPanel.Width / 2);

            infoForAllUsersLabel.Top = (this.ClientSize.Height / 2) - (infoForAllUsersLabel.Height / 2);
            infoForAllUsersLabel.Left = (this.ClientSize.Width / 2) - (infoForAllUsersLabel.Width / 2);
        }

        private void SetPlayerObjectPosition()
        {
            playerOneObject.Top = 0;
            playerOneObject.Left = 0;

            playerTwoObject.Top = this.ClientSize.Height - playerTwoObject.Height;
            playerTwoObject.Left = this.ClientSize.Width - playerTwoObject.Width;

            playerThreeObject.Top = 0;
            playerThreeObject.Left = this.ClientSize.Width - playerThreeObject.Width;

            playerFourObject.Top = this.ClientSize.Height - playerFourObject.Height;
            playerFourObject.Left = 0;
        }

        private void GeneratingRandomObjectPosition()
        {
            int randomTop = rnd.Next(0, maxTopRandom);
            int randomLeft = rnd.Next(0, maxLeftRandom);

            randomObject.Top = (randomTop * 50);
            randomObject.Left = (randomLeft * 50);

            foreach (PictureBox pb in playerObjects)
            {
                CheckWin(pb);
            }
        }

        private void CheckWin(PictureBox playerObject)
        {
            if (playerObject.Top == randomObject.Top && playerObject.Left == randomObject.Left)
            {
                SetLabelPoints(playerObject.Name.ToString());
                GeneratingRandomObjectPosition();
            }
        }

        private void SetLabelPoints(string player)
        {
            switch (player)
            {
                case "playerOneObject":
                    playerOnePoints++;
                    SetLabelValue(playerOneScoreValueLabel, playerOnePoints.ToString());
                    break;

                case "playerTwoObject":
                    playerTwoPoints++;
                    SetLabelValue(playerTwoScoreValueLabel, playerTwoPoints.ToString());
                    break;

                case "playerThreeObject":
                    playerThreePoints++;
                    SetLabelValue(playerThreeScoreValueLabel, playerThreePoints.ToString());
                    break;

                case "playerFourObject":
                    playerFourPoints++;
                    SetLabelValue(playerFourScoreValueLabel, playerFourPoints.ToString());
                    break;
            }
        }

        private void SetLabelValue(Label label, string value)
        {
            label.Text = value;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString().ToLower();

            if (isGameStarted == true)
            {
                if (key == "w" || key == "s" || key == "a" || key == "d")
                {
                    PlayerObjectMovement(playerOneObject, key);
                }

                else if (key == "up" || key == "down" || key == "left" || key == "right")
                {
                    PlayerObjectMovement(playerTwoObject, key);
                }

                else if (key == "numpad8" || key == "numpad5" || key == "numpad4" || key == "numpad6")
                {
                    PlayerObjectMovement(playerThreeObject, key);
                }

                else if (key == "i" || key == "k" || key == "j" || key == "l")
                {
                    PlayerObjectMovement(playerFourObject, key);
                }
            }

            else if (key == "return")
            {
                GameStarted();
            }
        }

        private void PlayerObjectMovement(PictureBox playerObject, string key)
        {
            string objectName = playerObject.Name.ToString();

            if (objectName == "playerOneObject")
            {
                switch (key)
                {
                    case "w":
                        playerObject.Top -= 50;
                        break;

                    case "s":
                        playerObject.Top += 50;
                        break;

                    case "a":
                        playerObject.Left -= 50;
                        break;

                    case "d":
                        playerObject.Left += 50;
                        break;
                }
            }

            else if (objectName == "playerTwoObject")
            {
                switch (key)
                {
                    case "up":
                        playerObject.Top -= 50;
                        break;

                    case "down":
                        playerObject.Top += 50;
                        break;

                    case "left":
                        playerObject.Left -= 50;
                        break;

                    case "right":
                        playerObject.Left += 50;
                        break;
                }
            }

            else if (objectName == "playerThreeObject")
            {
                switch (key)
                {
                    case "numpad8":
                        playerObject.Top -= 50;
                        break;

                    case "numpad5":
                        playerObject.Top += 50;
                        break;

                    case "numpad4":
                        playerObject.Left -= 50;
                        break;

                    case "numpad6":
                        playerObject.Left += 50;
                        break;
                }
            }

            else if (objectName == "playerFourObject")
            {
                switch (key)
                {
                    case "i":
                        playerObject.Top -= 50;
                        break;

                    case "k":
                        playerObject.Top += 50;
                        break;

                    case "j":
                        playerObject.Left -= 50;
                        break;

                    case "l":
                        playerObject.Left += 50;
                        break;
                }
            }

            BorderVerificationFunction(playerObject);
            CheckWin(playerObject);
        }

        private void BorderVerificationFunction(PictureBox playerObject)
        {
            if (playerObject.Top >= this.ClientSize.Height)
            {
                playerObject.Top = 0;
            }
            else if (playerObject.Top < 0)
            {
                playerObject.Top = this.ClientSize.Height - playerObject.Height;
            }

            if (playerObject.Left >= this.ClientSize.Width)
            {
                playerObject.Left = 0;
            }
            else if (playerObject.Left < 0)
            {
                playerObject.Left = this.ClientSize.Width - playerObject.Width;
            }
        }

        private void GameStarted()
        {
            infoForAllUsersLabel.Enabled = false;
            infoForAllUsersLabel.Visible = false;

            allInfoLabelPanel.Enabled = false;
            allInfoLabelPanel.Visible = false;

            isGameStarted = true;

            gameTimer.Enabled = true;
        }

        private void GameEnd()
        {
            gameTimer.Enabled = false;
            isGameStarted = false;

            infoForAllUsersLabel.Enabled = true;
            infoForAllUsersLabel.Visible = true;

            allInfoLabelPanel.Enabled = true;
            allInfoLabelPanel.Visible = true;

            time = mainTime;

            if (usernames.Count > 1)
            {

                FindWinner();
            }

            ClearValueLabels();
            SetPlayerObjectPosition();
            GeneratingRandomObjectPosition();
        }

        private void ClearValueLabels()
        {
            for (int i = 0; i < listOfLabels.Count; i++)
            {
                if (listOfLabels[i].Name.Contains("ScoreValueLabel"))
                {
                    SetLabelValue(listOfLabels[i], "0");
                }
            }
        }

        private void FindWinner()
        {
            List<int> listOfScore = new List<int>();

            for (int i = 0; i < listOfLabels.Count; i++)
            {
                if (listOfLabels[i].Name.Contains("ScoreValueLabel"))
                {
                    listOfScore.Add(int.Parse(listOfLabels[i].Text));
                }
            }

            listOfScore.Sort();
            listOfScore.Reverse();

            if (listOfScore[0] != 0)
            {
                if (listOfScore[0] != listOfScore[1])
                {
                    string winnerName = FindWinnerName(listOfScore[0])[0];

                    MessageBox.Show($"Winner is: {winnerName.Substring(0, (winnerName.Length - 1))}");
                }
                else if (listOfScore[0] == listOfScore[1])
                {
                    string winnerName = "";

                    foreach (string oneWinner in FindWinnerName(listOfScore[0]))
                    {
                        winnerName += $"\n{oneWinner.Substring(0, (oneWinner.Length - 1))}";
                    }

                    MessageBox.Show($"Winners are: {winnerName}");
                }
            }
        }

        private List<string> FindWinnerName(int findingNumber)
        {
            List<string> listOfWinners = new List<string>();

            for (int i = 0; i < listOfLabels.Count; i++)
            {
                if (listOfLabels[i].Name.Contains("ScoreValueLabel"))
                {
                    if (listOfLabels[i].Text == findingNumber.ToString())
                    {
                        listOfWinners.Add(listOfLabels[i - 1].Text);
                    }
                }
            }

            return listOfWinners;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int min = time / 60;
            int sec = time - (min * 60);


            if (time >= 0)
            {
                if (min < 10)
                {
                    if (sec < 10)
                    {
                        timeLabel.Text = $"0{min}:0{sec}";
                    }
                    else
                    {
                        timeLabel.Text = $"0{min}:{sec}";
                    }
                }
                else if (sec < 10)
                {
                    timeLabel.Text = $"{min}:0{sec}";
                }
                else
                {
                    timeLabel.Text = $"{min}:{sec}";
                }
            }
            else
            {
                GameEnd();
            }

            time--;
        }
    }
}



/*
    -> CREATED BY @warezoid
*/ 