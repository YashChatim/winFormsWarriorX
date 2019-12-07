namespace WarriorX
{
    partial class MainForm
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
            this.pictureBoxGameTitle = new System.Windows.Forms.PictureBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameTitle
            // 
            this.pictureBoxGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGameTitle.BackgroundImage = global::WarriorX.Properties.Resources.gameTitleX;
            this.pictureBoxGameTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGameTitle.Location = new System.Drawing.Point(199, 51);
            this.pictureBoxGameTitle.Name = "pictureBoxGameTitle";
            this.pictureBoxGameTitle.Size = new System.Drawing.Size(400, 150);
            this.pictureBoxGameTitle.TabIndex = 0;
            this.pictureBoxGameTitle.TabStop = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.BackgroundImage = global::WarriorX.Properties.Resources.quitButton;
            this.buttonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Location = new System.Drawing.Point(566, 248);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(113, 137);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            this.buttonQuit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonQuit_MouseDown);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.buttonQuit_MouseEnter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.buttonQuit_MouseLeave);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.BackgroundImage = global::WarriorX.Properties.Resources.howToPlayButton;
            this.buttonHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowToPlay.Location = new System.Drawing.Point(345, 248);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(113, 137);
            this.buttonHowToPlay.TabIndex = 4;
            this.buttonHowToPlay.UseVisualStyleBackColor = false;
            this.buttonHowToPlay.Click += new System.EventHandler(this.ButtonHowToPlay_Click);
            this.buttonHowToPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHowToPlay_MouseDown);
            this.buttonHowToPlay.MouseEnter += new System.EventHandler(this.buttonHowToPlay_MouseEnter);
            this.buttonHowToPlay.MouseLeave += new System.EventHandler(this.buttonHowToPlay_MouseLeave);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = global::WarriorX.Properties.Resources.startButton;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(115, 248);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 137);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseEnter += new System.EventHandler(this.buttonStart_MouseEnter);
            this.buttonStart.MouseLeave += new System.EventHandler(this.buttonStart_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WarriorX.Properties.Resources.startBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGameTitle);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "WarriorX";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.PictureBox pictureBoxGameTitle;
    }
}

