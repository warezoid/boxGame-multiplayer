namespace BoxGame
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.secondsLabel = new System.Windows.Forms.Label();
            this.secondsUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.minutesUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CustomTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Enabled = false;
            this.secondsLabel.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.secondsLabel.Location = new System.Drawing.Point(100, 138);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(56, 14);
            this.secondsLabel.TabIndex = 20;
            this.secondsLabel.Text = "Seconds";
            this.secondsLabel.Visible = false;
            // 
            // secondsUpAndDown
            // 
            this.secondsUpAndDown.Enabled = false;
            this.secondsUpAndDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsUpAndDown.Location = new System.Drawing.Point(103, 155);
            this.secondsUpAndDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsUpAndDown.Name = "secondsUpAndDown";
            this.secondsUpAndDown.Size = new System.Drawing.Size(71, 23);
            this.secondsUpAndDown.TabIndex = 19;
            this.secondsUpAndDown.Visible = false;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Enabled = false;
            this.minutesLabel.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.minutesLabel.Location = new System.Drawing.Point(12, 138);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(56, 14);
            this.minutesLabel.TabIndex = 18;
            this.minutesLabel.Text = "Minutes";
            this.minutesLabel.Visible = false;
            // 
            // minutesUpAndDown
            // 
            this.minutesUpAndDown.Enabled = false;
            this.minutesUpAndDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesUpAndDown.Location = new System.Drawing.Point(15, 155);
            this.minutesUpAndDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpAndDown.Name = "minutesUpAndDown";
            this.minutesUpAndDown.Size = new System.Drawing.Size(71, 23);
            this.minutesUpAndDown.TabIndex = 17;
            this.minutesUpAndDown.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(14, 191);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(160, 28);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomTimeCheckBox
            // 
            this.CustomTimeCheckBox.AutoSize = true;
            this.CustomTimeCheckBox.Location = new System.Drawing.Point(15, 108);
            this.CustomTimeCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.CustomTimeCheckBox.Name = "CustomTimeCheckBox";
            this.CustomTimeCheckBox.Size = new System.Drawing.Size(92, 17);
            this.CustomTimeCheckBox.TabIndex = 15;
            this.CustomTimeCheckBox.Text = "Custom time";
            this.CustomTimeCheckBox.UseVisualStyleBackColor = true;
            this.CustomTimeCheckBox.CheckedChanged += new System.EventHandler(this.CustomTimeCheckBox_CheckedChanged);
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Items.AddRange(new object[] {
            "",
            "1 minutes",
            "2 minutes",
            "3 minutes",
            "4 minutes",
            "5 minutes"});
            this.TimeComboBox.Location = new System.Drawing.Point(14, 77);
            this.TimeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(160, 21);
            this.TimeComboBox.TabIndex = 14;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.TimeLabel.Location = new System.Drawing.Point(12, 59);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 14);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "Time";
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Items.AddRange(new object[] {
            "",
            "1 player",
            "2 players",
            "3 players",
            "4 players"});
            this.ModeComboBox.Location = new System.Drawing.Point(14, 29);
            this.ModeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(160, 21);
            this.ModeComboBox.TabIndex = 12;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.ModeLabel.Location = new System.Drawing.Point(12, 13);
            this.ModeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(35, 14);
            this.ModeLabel.TabIndex = 11;
            this.ModeLabel.Text = "Mode";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 232);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.secondsUpAndDown);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.minutesUpAndDown);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CustomTimeCheckBox);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ModeComboBox);
            this.Controls.Add(this.ModeLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.NumericUpDown secondsUpAndDown;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.NumericUpDown minutesUpAndDown;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.CheckBox CustomTimeCheckBox;
        private System.Windows.Forms.ComboBox TimeComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Label ModeLabel;
    }
}