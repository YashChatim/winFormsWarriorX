namespace WarriorX
{
    partial class GameForm
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
            this.timerOne = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarHealthPlayerOne = new System.Windows.Forms.ProgressBar();
            this.timerTwo = new System.Windows.Forms.Timer(this.components);
            this.progressBarHealthPlayerTwo = new System.Windows.Forms.ProgressBar();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.pictureBoxHealth = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerOne = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerTwo = new System.Windows.Forms.PictureBox();
            this.panelScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerOne
            // 
            this.timerOne.Enabled = true;
            this.timerOne.Interval = 1;
            this.timerOne.Tick += new System.EventHandler(this.TimerOne);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(383, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "II";
            this.label1.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // progressBarHealthPlayerOne
            // 
            this.progressBarHealthPlayerOne.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarHealthPlayerOne.Location = new System.Drawing.Point(80, 27);
            this.progressBarHealthPlayerOne.Maximum = 265;
            this.progressBarHealthPlayerOne.Name = "progressBarHealthPlayerOne";
            this.progressBarHealthPlayerOne.Size = new System.Drawing.Size(265, 10);
            this.progressBarHealthPlayerOne.TabIndex = 6;
            this.progressBarHealthPlayerOne.Tag = "progressBarHealthPlayerOne";
            // 
            // timerTwo
            // 
            this.timerTwo.Enabled = true;
            this.timerTwo.Interval = 1;
            this.timerTwo.Tick += new System.EventHandler(this.TimerTwo);
            // 
            // progressBarHealthPlayerTwo
            // 
            this.progressBarHealthPlayerTwo.Location = new System.Drawing.Point(451, 28);
            this.progressBarHealthPlayerTwo.Maximum = 265;
            this.progressBarHealthPlayerTwo.Name = "progressBarHealthPlayerTwo";
            this.progressBarHealthPlayerTwo.Size = new System.Drawing.Size(265, 10);
            this.progressBarHealthPlayerTwo.TabIndex = 9;
            this.progressBarHealthPlayerTwo.Tag = "progressBarHealthPlayerTwo";
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.Color.Pink;
            this.panelScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelScreen.Controls.Add(this.pictureBoxHealth);
            this.panelScreen.Controls.Add(this.pictureBoxPlayerOne);
            this.panelScreen.Controls.Add(this.pictureBoxPlayerTwo);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(0, 0);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(800, 450);
            this.panelScreen.TabIndex = 11;
            this.panelScreen.Tag = "panelScreen";
            // 
            // pictureBoxHealth
            // 
            this.pictureBoxHealth.BackgroundImage = global::WarriorX.Properties.Resources.mainHealthBackground;
            this.pictureBoxHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHealth.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHealth.Name = "pictureBoxHealth";
            this.pictureBoxHealth.Size = new System.Drawing.Size(800, 110);
            this.pictureBoxHealth.TabIndex = 8;
            this.pictureBoxHealth.TabStop = false;
            // 
            // pictureBoxPlayerOne
            // 
            this.pictureBoxPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayerOne.BackgroundImage = global::WarriorX.Properties.Resources.redIdle;
            this.pictureBoxPlayerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayerOne.Location = new System.Drawing.Point(176, 162);
            this.pictureBoxPlayerOne.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPlayerOne.Name = "pictureBoxPlayerOne";
            this.pictureBoxPlayerOne.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPlayerOne.TabIndex = 1;
            this.pictureBoxPlayerOne.TabStop = false;
            this.pictureBoxPlayerOne.Tag = "pictureBoxPlayerOne";
            // 
            // pictureBoxPlayerTwo
            // 
            this.pictureBoxPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayerTwo.BackgroundImage = global::WarriorX.Properties.Resources.purpleIdle;
            this.pictureBoxPlayerTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayerTwo.Location = new System.Drawing.Point(431, 162);
            this.pictureBoxPlayerTwo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPlayerTwo.Name = "pictureBoxPlayerTwo";
            this.pictureBoxPlayerTwo.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPlayerTwo.TabIndex = 7;
            this.pictureBoxPlayerTwo.TabStop = false;
            this.pictureBoxPlayerTwo.Tag = "pictureBoxPlayerTwo";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarHealthPlayerTwo);
            this.Controls.Add(this.progressBarHealthPlayerOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelScreen);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "WarriorX";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayerKeyUp);
            this.panelScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarHealthPlayerOne;
        private System.Windows.Forms.Timer timerTwo;
        private System.Windows.Forms.ProgressBar progressBarHealthPlayerTwo;
        private System.Windows.Forms.PictureBox pictureBoxPlayerTwo;
        private System.Windows.Forms.PictureBox pictureBoxPlayerOne;
        private System.Windows.Forms.PictureBox pictureBoxHealth;
        private System.Windows.Forms.Panel panelScreen;
    }
}