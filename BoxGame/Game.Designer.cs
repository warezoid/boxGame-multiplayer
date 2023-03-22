namespace BoxGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerOneScoreValueLabel = new System.Windows.Forms.Label();
            this.playerTwoInfoLabel = new System.Windows.Forms.Label();
            this.playerOneInfoLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.playerFourScoreValueLabel = new System.Windows.Forms.Label();
            this.playerFourScoreLabel = new System.Windows.Forms.Label();
            this.playerThreeScoreValueLabel = new System.Windows.Forms.Label();
            this.playerThreeScoreLabel = new System.Windows.Forms.Label();
            this.playerTwoScoreValueLabel = new System.Windows.Forms.Label();
            this.playerTwoScoreLabel = new System.Windows.Forms.Label();
            this.playerThreeInfoLabel = new System.Windows.Forms.Label();
            this.playerFourInfoLabel = new System.Windows.Forms.Label();
            this.infoForAllUsersLabel = new System.Windows.Forms.Label();
            this.playerOneScoreLabel = new System.Windows.Forms.Label();
            this.allInfoLabelPanel = new System.Windows.Forms.Panel();
            this.playerThreeObject = new System.Windows.Forms.PictureBox();
            this.playerTwoObject = new System.Windows.Forms.PictureBox();
            this.playerFourObject = new System.Windows.Forms.PictureBox();
            this.randomObject = new System.Windows.Forms.PictureBox();
            this.playerOneObject = new System.Windows.Forms.PictureBox();
            this.allInfoLabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerThreeObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFourObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneObject)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerOneScoreValueLabel
            // 
            this.playerOneScoreValueLabel.AutoSize = true;
            this.playerOneScoreValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerOneScoreValueLabel.Enabled = false;
            this.playerOneScoreValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerOneScoreValueLabel.Location = new System.Drawing.Point(129, 12);
            this.playerOneScoreValueLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerOneScoreValueLabel.Name = "playerOneScoreValueLabel";
            this.playerOneScoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.playerOneScoreValueLabel.TabIndex = 23;
            this.playerOneScoreValueLabel.Text = "0";
            this.playerOneScoreValueLabel.Visible = false;
            // 
            // playerTwoInfoLabel
            // 
            this.playerTwoInfoLabel.AutoSize = true;
            this.playerTwoInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerTwoInfoLabel.Enabled = false;
            this.playerTwoInfoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerTwoInfoLabel.Location = new System.Drawing.Point(223, 10);
            this.playerTwoInfoLabel.Margin = new System.Windows.Forms.Padding(60, 10, 60, 0);
            this.playerTwoInfoLabel.Name = "playerTwoInfoLabel";
            this.playerTwoInfoLabel.Size = new System.Drawing.Size(43, 13);
            this.playerTwoInfoLabel.TabIndex = 17;
            this.playerTwoInfoLabel.Text = "******";
            this.playerTwoInfoLabel.Visible = false;
            // 
            // playerOneInfoLabel
            // 
            this.playerOneInfoLabel.AutoSize = true;
            this.playerOneInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerOneInfoLabel.Enabled = false;
            this.playerOneInfoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerOneInfoLabel.Location = new System.Drawing.Point(60, 10);
            this.playerOneInfoLabel.Margin = new System.Windows.Forms.Padding(60, 10, 60, 0);
            this.playerOneInfoLabel.Name = "playerOneInfoLabel";
            this.playerOneInfoLabel.Size = new System.Drawing.Size(43, 13);
            this.playerOneInfoLabel.TabIndex = 16;
            this.playerOneInfoLabel.Text = "******";
            this.playerOneInfoLabel.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Consolas", 15F);
            this.timeLabel.Location = new System.Drawing.Point(602, 13);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 23);
            this.timeLabel.TabIndex = 37;
            this.timeLabel.Text = "00:00";
            // 
            // playerFourScoreValueLabel
            // 
            this.playerFourScoreValueLabel.AutoSize = true;
            this.playerFourScoreValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerFourScoreValueLabel.Enabled = false;
            this.playerFourScoreValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerFourScoreValueLabel.Location = new System.Drawing.Point(129, 88);
            this.playerFourScoreValueLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerFourScoreValueLabel.Name = "playerFourScoreValueLabel";
            this.playerFourScoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.playerFourScoreValueLabel.TabIndex = 31;
            this.playerFourScoreValueLabel.Text = "0";
            this.playerFourScoreValueLabel.Visible = false;
            // 
            // playerFourScoreLabel
            // 
            this.playerFourScoreLabel.AutoSize = true;
            this.playerFourScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerFourScoreLabel.Enabled = false;
            this.playerFourScoreLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerFourScoreLabel.Location = new System.Drawing.Point(15, 88);
            this.playerFourScoreLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerFourScoreLabel.Name = "playerFourScoreLabel";
            this.playerFourScoreLabel.Size = new System.Drawing.Size(77, 15);
            this.playerFourScoreLabel.TabIndex = 30;
            this.playerFourScoreLabel.Text = "Player 4: ";
            this.playerFourScoreLabel.Visible = false;
            // 
            // playerThreeScoreValueLabel
            // 
            this.playerThreeScoreValueLabel.AutoSize = true;
            this.playerThreeScoreValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerThreeScoreValueLabel.Enabled = false;
            this.playerThreeScoreValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerThreeScoreValueLabel.Location = new System.Drawing.Point(129, 63);
            this.playerThreeScoreValueLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerThreeScoreValueLabel.Name = "playerThreeScoreValueLabel";
            this.playerThreeScoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.playerThreeScoreValueLabel.TabIndex = 29;
            this.playerThreeScoreValueLabel.Text = "0";
            this.playerThreeScoreValueLabel.Visible = false;
            // 
            // playerThreeScoreLabel
            // 
            this.playerThreeScoreLabel.AutoSize = true;
            this.playerThreeScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerThreeScoreLabel.Enabled = false;
            this.playerThreeScoreLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerThreeScoreLabel.Location = new System.Drawing.Point(15, 63);
            this.playerThreeScoreLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerThreeScoreLabel.Name = "playerThreeScoreLabel";
            this.playerThreeScoreLabel.Size = new System.Drawing.Size(77, 15);
            this.playerThreeScoreLabel.TabIndex = 28;
            this.playerThreeScoreLabel.Text = "Player 3: ";
            this.playerThreeScoreLabel.Visible = false;
            // 
            // playerTwoScoreValueLabel
            // 
            this.playerTwoScoreValueLabel.AutoSize = true;
            this.playerTwoScoreValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerTwoScoreValueLabel.Enabled = false;
            this.playerTwoScoreValueLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerTwoScoreValueLabel.Location = new System.Drawing.Point(129, 38);
            this.playerTwoScoreValueLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerTwoScoreValueLabel.Name = "playerTwoScoreValueLabel";
            this.playerTwoScoreValueLabel.Size = new System.Drawing.Size(14, 15);
            this.playerTwoScoreValueLabel.TabIndex = 27;
            this.playerTwoScoreValueLabel.Text = "0";
            this.playerTwoScoreValueLabel.Visible = false;
            // 
            // playerTwoScoreLabel
            // 
            this.playerTwoScoreLabel.AutoSize = true;
            this.playerTwoScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerTwoScoreLabel.Enabled = false;
            this.playerTwoScoreLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerTwoScoreLabel.Location = new System.Drawing.Point(15, 38);
            this.playerTwoScoreLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            this.playerTwoScoreLabel.Size = new System.Drawing.Size(77, 15);
            this.playerTwoScoreLabel.TabIndex = 26;
            this.playerTwoScoreLabel.Text = "Player 2: ";
            this.playerTwoScoreLabel.Visible = false;
            // 
            // playerThreeInfoLabel
            // 
            this.playerThreeInfoLabel.AutoSize = true;
            this.playerThreeInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerThreeInfoLabel.Enabled = false;
            this.playerThreeInfoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerThreeInfoLabel.Location = new System.Drawing.Point(386, 10);
            this.playerThreeInfoLabel.Margin = new System.Windows.Forms.Padding(60, 10, 60, 0);
            this.playerThreeInfoLabel.Name = "playerThreeInfoLabel";
            this.playerThreeInfoLabel.Size = new System.Drawing.Size(43, 13);
            this.playerThreeInfoLabel.TabIndex = 18;
            this.playerThreeInfoLabel.Text = "******";
            this.playerThreeInfoLabel.Visible = false;
            // 
            // playerFourInfoLabel
            // 
            this.playerFourInfoLabel.AutoSize = true;
            this.playerFourInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerFourInfoLabel.Enabled = false;
            this.playerFourInfoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerFourInfoLabel.Location = new System.Drawing.Point(549, 10);
            this.playerFourInfoLabel.Margin = new System.Windows.Forms.Padding(60, 10, 60, 0);
            this.playerFourInfoLabel.Name = "playerFourInfoLabel";
            this.playerFourInfoLabel.Size = new System.Drawing.Size(43, 13);
            this.playerFourInfoLabel.TabIndex = 19;
            this.playerFourInfoLabel.Text = "******";
            this.playerFourInfoLabel.Visible = false;
            // 
            // infoForAllUsersLabel
            // 
            this.infoForAllUsersLabel.AutoSize = true;
            this.infoForAllUsersLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoForAllUsersLabel.Enabled = false;
            this.infoForAllUsersLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoForAllUsersLabel.Location = new System.Drawing.Point(163, 167);
            this.infoForAllUsersLabel.Margin = new System.Windows.Forms.Padding(146, 50, 146, 0);
            this.infoForAllUsersLabel.Name = "infoForAllUsersLabel";
            this.infoForAllUsersLabel.Size = new System.Drawing.Size(280, 17);
            this.infoForAllUsersLabel.TabIndex = 35;
            this.infoForAllUsersLabel.Text = "For start and restar press \'Enter\'";
            this.infoForAllUsersLabel.Visible = false;
            // 
            // playerOneScoreLabel
            // 
            this.playerOneScoreLabel.AutoSize = true;
            this.playerOneScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerOneScoreLabel.Enabled = false;
            this.playerOneScoreLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerOneScoreLabel.Location = new System.Drawing.Point(15, 13);
            this.playerOneScoreLabel.Margin = new System.Windows.Forms.Padding(5);
            this.playerOneScoreLabel.Name = "playerOneScoreLabel";
            this.playerOneScoreLabel.Size = new System.Drawing.Size(70, 15);
            this.playerOneScoreLabel.TabIndex = 22;
            this.playerOneScoreLabel.Text = "Player 1:";
            this.playerOneScoreLabel.Visible = false;
            // 
            // allInfoLabelPanel
            // 
            this.allInfoLabelPanel.Controls.Add(this.playerThreeInfoLabel);
            this.allInfoLabelPanel.Controls.Add(this.playerTwoInfoLabel);
            this.allInfoLabelPanel.Controls.Add(this.playerOneInfoLabel);
            this.allInfoLabelPanel.Controls.Add(this.playerFourInfoLabel);
            this.allInfoLabelPanel.Location = new System.Drawing.Point(15, 187);
            this.allInfoLabelPanel.Name = "allInfoLabelPanel";
            this.allInfoLabelPanel.Size = new System.Drawing.Size(652, 132);
            this.allInfoLabelPanel.TabIndex = 36;
            // 
            // playerThreeObject
            // 
            this.playerThreeObject.BackColor = System.Drawing.Color.Blue;
            this.playerThreeObject.Enabled = false;
            this.playerThreeObject.Location = new System.Drawing.Point(3, 4);
            this.playerThreeObject.Margin = new System.Windows.Forms.Padding(0);
            this.playerThreeObject.Name = "playerThreeObject";
            this.playerThreeObject.Size = new System.Drawing.Size(50, 50);
            this.playerThreeObject.TabIndex = 34;
            this.playerThreeObject.TabStop = false;
            this.playerThreeObject.Visible = false;
            // 
            // playerTwoObject
            // 
            this.playerTwoObject.BackColor = System.Drawing.Color.Gold;
            this.playerTwoObject.Enabled = false;
            this.playerTwoObject.Location = new System.Drawing.Point(3, 4);
            this.playerTwoObject.Margin = new System.Windows.Forms.Padding(0);
            this.playerTwoObject.Name = "playerTwoObject";
            this.playerTwoObject.Size = new System.Drawing.Size(50, 50);
            this.playerTwoObject.TabIndex = 33;
            this.playerTwoObject.TabStop = false;
            this.playerTwoObject.Visible = false;
            // 
            // playerFourObject
            // 
            this.playerFourObject.BackColor = System.Drawing.Color.Green;
            this.playerFourObject.Enabled = false;
            this.playerFourObject.Location = new System.Drawing.Point(3, 4);
            this.playerFourObject.Margin = new System.Windows.Forms.Padding(0);
            this.playerFourObject.Name = "playerFourObject";
            this.playerFourObject.Size = new System.Drawing.Size(50, 50);
            this.playerFourObject.TabIndex = 32;
            this.playerFourObject.TabStop = false;
            this.playerFourObject.Visible = false;
            // 
            // randomObject
            // 
            this.randomObject.BackColor = System.Drawing.Color.Black;
            this.randomObject.Location = new System.Drawing.Point(3, 4);
            this.randomObject.Margin = new System.Windows.Forms.Padding(0);
            this.randomObject.Name = "randomObject";
            this.randomObject.Size = new System.Drawing.Size(50, 50);
            this.randomObject.TabIndex = 25;
            this.randomObject.TabStop = false;
            // 
            // playerOneObject
            // 
            this.playerOneObject.BackColor = System.Drawing.Color.Red;
            this.playerOneObject.Enabled = false;
            this.playerOneObject.Location = new System.Drawing.Point(3, 4);
            this.playerOneObject.Margin = new System.Windows.Forms.Padding(0);
            this.playerOneObject.Name = "playerOneObject";
            this.playerOneObject.Size = new System.Drawing.Size(50, 50);
            this.playerOneObject.TabIndex = 24;
            this.playerOneObject.TabStop = false;
            this.playerOneObject.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 322);
            this.Controls.Add(this.playerOneScoreValueLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.playerFourScoreValueLabel);
            this.Controls.Add(this.playerFourScoreLabel);
            this.Controls.Add(this.playerThreeScoreValueLabel);
            this.Controls.Add(this.playerThreeScoreLabel);
            this.Controls.Add(this.playerTwoScoreValueLabel);
            this.Controls.Add(this.playerTwoScoreLabel);
            this.Controls.Add(this.infoForAllUsersLabel);
            this.Controls.Add(this.playerOneScoreLabel);
            this.Controls.Add(this.allInfoLabelPanel);
            this.Controls.Add(this.playerThreeObject);
            this.Controls.Add(this.playerTwoObject);
            this.Controls.Add(this.playerFourObject);
            this.Controls.Add(this.randomObject);
            this.Controls.Add(this.playerOneObject);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.allInfoLabelPanel.ResumeLayout(false);
            this.allInfoLabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerThreeObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFourObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOneObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerOneScoreValueLabel;
        private System.Windows.Forms.Label playerTwoInfoLabel;
        private System.Windows.Forms.Label playerOneInfoLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label playerFourScoreValueLabel;
        private System.Windows.Forms.Label playerFourScoreLabel;
        private System.Windows.Forms.Label playerThreeScoreValueLabel;
        private System.Windows.Forms.Label playerThreeScoreLabel;
        private System.Windows.Forms.Label playerTwoScoreValueLabel;
        private System.Windows.Forms.Label playerTwoScoreLabel;
        private System.Windows.Forms.Label playerThreeInfoLabel;
        private System.Windows.Forms.Label playerFourInfoLabel;
        private System.Windows.Forms.Label infoForAllUsersLabel;
        private System.Windows.Forms.Label playerOneScoreLabel;
        private System.Windows.Forms.Panel allInfoLabelPanel;
        private System.Windows.Forms.PictureBox playerThreeObject;
        private System.Windows.Forms.PictureBox playerTwoObject;
        private System.Windows.Forms.PictureBox playerFourObject;
        private System.Windows.Forms.PictureBox randomObject;
        private System.Windows.Forms.PictureBox playerOneObject;
    }
}

