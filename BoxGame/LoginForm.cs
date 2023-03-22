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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /***** CustomTimeCheckBox_CheckedChanged *****/
        private void CustomTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomTimeCheckBox.Checked)
            {
                minutesLabel.Enabled = true;
                minutesLabel.Visible = true;
                minutesUpAndDown.Enabled = true;
                minutesUpAndDown.Visible = true;

                secondsLabel.Enabled = true;
                secondsLabel.Visible = true;
                secondsUpAndDown.Enabled = true;
                secondsUpAndDown.Visible = true;

                TimeComboBox.Enabled = false;
                TimeComboBox.SelectedIndex = 0;
            }
            else
            {
                minutesLabel.Enabled = false;
                minutesLabel.Visible = false;
                minutesUpAndDown.Enabled = false;
                minutesUpAndDown.Visible = false;
                minutesUpAndDown.Value = 0;

                secondsLabel.Enabled = false;
                secondsLabel.Visible = false;
                secondsUpAndDown.Enabled = false;
                secondsUpAndDown.Visible = false;
                secondsUpAndDown.Value = 0;

                TimeComboBox.Enabled = true;
            }
        }

        /***** SubmitButton_Click *****/
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string mode = ModeComboBox.Text;
            int time = 0;

            if (CustomTimeCheckBox.Checked)
            {
                if (minutesUpAndDown.Value != 0 || secondsUpAndDown.Value != 0)
                {
                    time = ((int)minutesUpAndDown.Value * 60) + (int)secondsUpAndDown.Value;
                }
            }
            else
            {
                if (TimeComboBox.Text != "")
                {
                    time = (int.Parse(TimeComboBox.Text[0].ToString()) * 60);
                }
            }

            if (mode != "" && time != 0)
            {
                if (time >= 30)
                {
                    SetUsers s = new SetUsers(mode, time);

                    this.Hide();
                    s.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Minimum value for seconds is 30!");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled in!");
            }

            ModeComboBox.SelectedIndex = 0;
            TimeComboBox.SelectedIndex = 0;
            CustomTimeCheckBox.Checked = false;
        }
    }
}



/*
    -> CREATED BY @warezoid
*/ 