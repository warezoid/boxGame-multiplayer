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
    public partial class SetUsers : Form
    {
        /***** VARIABLES *****/
        private string gameMode;
        private int gameTime;
        private List<string> usernames = new List<string>();
        private List<Color> userColors = new List<Color>();
        private List<TextBox> textboxList;
        private List<ComboBox> comboboxList;
        private List<Label> labelList;
        private List<PictureBox> pictureBoxList;
        private int countOfValidData = 0;
        private bool isCustomColorActive = false;

        public SetUsers(string mode, int time)
        {
            gameMode = mode;
            gameTime = time;

            InitializeComponent();

            ShowInputs(mode);
        }

        /***** ShowInputs *****/
        private void ShowInputs(string mode)
        {
            switch (mode[0])
            {
                case '1':
                    textboxList = new List<TextBox> { playerNameTextBox1 };
                    comboboxList = new List<ComboBox> { playerColorComboBox1 };
                    labelList = new List<Label> { playerOneNameLabel, playerOneColorLabel };
                    pictureBoxList = new List<PictureBox> { playerColorPictureBox1 };
                    SetStyles(182, 63, 95);
                    break;

                case '2':
                    textboxList = new List<TextBox> { playerNameTextBox1, playerNameTextBox2 };
                    comboboxList = new List<ComboBox> { playerColorComboBox1, playerColorComboBox2 };
                    labelList = new List<Label> { playerOneNameLabel, playerOneColorLabel, playerTwoNameLabel, playerTwoColorLabel };
                    pictureBoxList = new List<PictureBox> { playerColorPictureBox1, playerColorPictureBox2 };
                    SetStyles(230, 111, 143);
                    break;

                case '3':
                    textboxList = new List<TextBox> { playerNameTextBox1, playerNameTextBox2, playerNameTextBox3 };
                    comboboxList = new List<ComboBox> { playerColorComboBox1, playerColorComboBox2, playerColorComboBox3 };
                    labelList = new List<Label> { playerOneNameLabel, playerOneColorLabel, playerTwoNameLabel, playerTwoColorLabel, playerThreeNameLabel, playerThreeColorLabel };
                    pictureBoxList = new List<PictureBox> { playerColorPictureBox1, playerColorPictureBox2, playerColorPictureBox3 };
                    SetStyles(278, 159, 191);
                    break;

                case '4':
                    textboxList = new List<TextBox> { playerNameTextBox1, playerNameTextBox2, playerNameTextBox3, playerNameTextBox4 };
                    comboboxList = new List<ComboBox> { playerColorComboBox1, playerColorComboBox2, playerColorComboBox3, playerColorComboBox4 };
                    labelList = new List<Label> { playerOneNameLabel, playerOneColorLabel, playerTwoNameLabel, playerTwoColorLabel, playerThreeNameLabel, playerThreeColorLabel, playerFourNameLabel, playerFourColorLabel };
                    pictureBoxList = new List<PictureBox> { playerColorPictureBox1, playerColorPictureBox2, playerColorPictureBox3, playerColorPictureBox4 };
                    SetStyles(322, 207, 235);
                    break;
            }

            EnableAndVisibleInputs(true);
        }

        /***** SetStyles *****/
        private void SetStyles(int height, int CustomColorCheckBoxTop, int SubmitButtonTop)
        {
            this.Height = height;
            CustomeColorCheckBox.Top = CustomColorCheckBoxTop;
            SubmitButton.Top = SubmitButtonTop;
        }

        /***** EnableAndVisibleInputs *****/
        private void EnableAndVisibleInputs(bool isVisible)
        {
            foreach (TextBox tb in textboxList)
            {
                tb.Enabled = isVisible;
                tb.Visible = isVisible;
            }

            foreach (ComboBox cb in comboboxList)
            {
                cb.Enabled = false;
                cb.Visible = isVisible;
            }

            foreach (Label lb in labelList)
            {
                lb.Enabled = isVisible;
                lb.Visible = isVisible;
            }

            foreach (PictureBox pb in pictureBoxList)
            {
                pb.Enabled = isVisible;
                pb.Visible = isVisible;
            }
        }

        /***** SubmitButton_Click *****/
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        /***** SubmitForm *****/
        private void SubmitForm()
        {
            usernames.Clear();
            userColors.Clear();
            countOfValidData = 0;

            foreach (TextBox oneTextBox in textboxList)
            {
                string userInput = oneTextBox.Text;

                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    usernames.Add(userInput);
                    countOfValidData++;
                }
            }

            if (isCustomColorActive)
            {
                foreach (ComboBox oneComboBox in comboboxList)
                {
                    string userInput = oneComboBox.Text;

                    if (userInput != "")
                    {
                        userColors.Add(Color.FromName(userInput));
                        countOfValidData++;
                    }
                }
            }

            if (textboxList.Count > 1)
            {
                PreventingRepetetive();
            }
            else
            {
                StartGame();
            }
        }

        /***** PreventingRepetetive *****/
        private void PreventingRepetetive()
        {
            int numberOfSameTextBox = 0;

            foreach (TextBox oneTextBox in textboxList)
            {
                foreach (string oneName in usernames)
                {
                    if (oneName == oneTextBox.Text)
                    {
                        numberOfSameTextBox++;
                    }
                }
            }

            int numberOfSameComboBox = 0;

            foreach (ComboBox oneComboBox in comboboxList)
            {
                foreach (Color oneColor in userColors)
                {
                    if (oneColor.Name == oneComboBox.Text)
                    {
                        numberOfSameComboBox++;
                    }
                }
            }

            PreventingRepetetiveSwitchTree(numberOfSameTextBox, numberOfSameComboBox);
        }

        /***** PreventingRepetetiveSwitchTree *****/
        private void PreventingRepetetiveSwitchTree(int numberOfSameTextBox, int numberOfSameComboBox)
        {
            int textBoxCount = textboxList.Count;
            int comboBoxCount = comboboxList.Count;

            if (isCustomColorActive)
            {
                switch (textBoxCount)
                {
                    case 2:
                        if (numberOfSameTextBox == textBoxCount && numberOfSameComboBox == comboBoxCount)
                        {
                            StartGame();
                        }
                        else
                        {
                            if (numberOfSameTextBox == 0 || numberOfSameTextBox == 1 && numberOfSameComboBox == 0 || numberOfSameComboBox == 1)
                            {
                                MessageBox.Show("All fields must be filled in!");
                            }
                            else
                            {
                                MessageBox.Show("Inputs must not be the same!");
                            }
                        }
                        break;

                    case 3:
                        if (numberOfSameTextBox == textBoxCount && numberOfSameComboBox == comboBoxCount)
                        {
                            StartGame();
                        }
                        else
                        {
                            if (numberOfSameTextBox == 0 || numberOfSameTextBox == 1 || numberOfSameTextBox == 2 || numberOfSameTextBox == 4 && numberOfSameComboBox == 0 || numberOfSameComboBox == 1 || numberOfSameComboBox == 2 || numberOfSameComboBox == 4)
                            {
                                MessageBox.Show("All fields must be filled in!");
                            }
                            else
                            {
                                MessageBox.Show("Inputs must not be the same!");
                            }
                        }
                        break;

                    case 4:
                        if (numberOfSameTextBox == textBoxCount && numberOfSameComboBox == comboBoxCount)
                        {
                            StartGame();
                        }
                        else
                        {
                            if (numberOfSameTextBox == 0 || numberOfSameTextBox == 1 || numberOfSameTextBox == 2 || numberOfSameTextBox == 3 || numberOfSameTextBox == 5 || numberOfSameTextBox == 9 && numberOfSameComboBox == 0 || numberOfSameComboBox == 1 || numberOfSameComboBox == 2 || numberOfSameComboBox == 3 || numberOfSameComboBox == 5 || numberOfSameComboBox == 9)
                            {
                                MessageBox.Show("All fields must be filled in!");
                            }
                            else
                            {
                                MessageBox.Show("Inputs must not be the same!");
                            }
                        }
                        break;
                }
            }
            else
            {
                switch (textBoxCount)
                {
                    case 2:
                        if (numberOfSameTextBox == textBoxCount)
                        {
                            StartGame();
                        }
                        else
                        {
                            if (numberOfSameTextBox == 0 || numberOfSameTextBox == 1)
                            {
                                MessageBox.Show("All fields must be filled in!");
                            }
                            else
                            {
                                MessageBox.Show("Inputs must not be the same!");
                            }
                        }
                        break;

                    case 3:
                        if (numberOfSameTextBox == textBoxCount)
                        {
                            StartGame();
                        }
                        else
                        {
                            if (numberOfSameTextBox == 0 || numberOfSameTextBox == 1 || numberOfSameTextBox == 2 || numberOfSameTextBox == 4)
                            {
                                MessageBox.Show("All fields must be filled in!");
                            }
                            else
                            {
                                MessageBox.Show("Inputs must not be the same!");
                            }
                        }
                        break;

                    case 4:
                        if (numberOfSameTextBox == textBoxCount)
                        {
                            StartGame();
                        }
                        else
                        {
                            if (numberOfSameTextBox == 0 || numberOfSameTextBox == 1 || numberOfSameTextBox == 2 || numberOfSameTextBox == 3 || numberOfSameTextBox == 5 || numberOfSameTextBox == 9)
                            {
                                MessageBox.Show("All fields must be filled in!");
                            }
                            else
                            {
                                MessageBox.Show("Inputs must not be the same!");
                            }
                        }
                        break;
                }
            }
        }

        /***** StartGame *****/
        private void StartGame()
        {
            if (isCustomColorActive)
            {
                if (countOfValidData == (textboxList.Count * 2))
                {
                    Game g = new Game(gameMode, gameTime, usernames, userColors);

                    this.Hide();
                    g.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("All fields must be filled in!");
                }
            }
            else
            {
                if (countOfValidData == textboxList.Count)
                {
                    Game g = new Game(gameMode, gameTime, usernames, userColors);

                    this.Hide();
                    g.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("All fields must be filled in!");
                }
            }
        }

        /***** playerColorComboBox1_SelectedValueChanged *****/
        private void playerColorComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomColorPictureBox();
            SetPictureBoxColor(playerColorPictureBox1, Color.FromName(playerColorComboBox1.Text));
        }

        /***** playerColorComboBox2_SelectedValueChanged *****/
        private void playerColorComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomColorPictureBox();
            SetPictureBoxColor(playerColorPictureBox2, Color.FromName(playerColorComboBox2.Text));
        }

        /***** playerColorComboBox3_SelectedValueChanged *****/
        private void playerColorComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomColorPictureBox();
            SetPictureBoxColor(playerColorPictureBox3, Color.FromName(playerColorComboBox3.Text));
        }

        /***** playerColorComboBox4_SelectedValueChanged *****/
        private void playerColorComboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomColorPictureBox();
            SetPictureBoxColor(playerColorPictureBox4, Color.FromName(playerColorComboBox4.Text));
        }

        /***** CustomColorPictureBox *****/
        private void CustomColorPictureBox()
        {
            int countOfEmpty = 0;

            foreach (ComboBox cb in comboboxList)
            {
                if (cb.Text == "")
                {
                    countOfEmpty++;
                }
            }

            if (countOfEmpty != comboboxList.Count)
            {
                this.Width = 385;
                isCustomColorActive = true;
            }
            else
            {
                this.Width = 354;
                isCustomColorActive = false;
            }
        }

        /***** SetPictureBoxColor *****/
        private void SetPictureBoxColor(PictureBox pictureBox, Color color)
        {
            pictureBox.BackColor = color;
        }

        /***** CustomeColorCheckBox_CheckedChanged *****/
        private void CustomeColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomeColorCheckBox.Checked)
            {
                EnableDenableComboBox(true);
            }
            else
            {
                EnableDenableComboBox(false);
            }
        }

        /***** EnableDenableComboBox *****/
        private void EnableDenableComboBox(bool isActive)
        {
            foreach (ComboBox cb in comboboxList)
            {
                cb.Enabled = isActive;

                if (!isActive)
                {
                    cb.SelectedIndex = 0;
                }
            }

            foreach (PictureBox pb in pictureBoxList)
            {
                pb.Enabled = isActive;
                pb.Visible = isActive;
            }
        }
    }
}



/*
    -> CREATED BY @warezoid
*/ 