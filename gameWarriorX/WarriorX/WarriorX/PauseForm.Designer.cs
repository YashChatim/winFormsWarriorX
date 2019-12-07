namespace WarriorX
{
    partial class PauseForm
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
            this.pictureBoxGamePaused = new System.Windows.Forms.PictureBox();
            this.buttonResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamePaused)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGamePaused
            // 
            this.pictureBoxGamePaused.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGamePaused.BackgroundImage = global::WarriorX.Properties.Resources.gamePausedTitle;
            this.pictureBoxGamePaused.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGamePaused.Location = new System.Drawing.Point(153, 27);
            this.pictureBoxGamePaused.Name = "pictureBoxGamePaused";
            this.pictureBoxGamePaused.Size = new System.Drawing.Size(514, 165);
            this.pictureBoxGamePaused.TabIndex = 8;
            this.pictureBoxGamePaused.TabStop = false;
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.Transparent;
            this.buttonResume.BackgroundImage = global::WarriorX.Properties.Resources.resumeButton;
            this.buttonResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.Location = new System.Drawing.Point(296, 198);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(221, 105);
            this.buttonResume.TabIndex = 7;
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.ButtonResume_Click);
            this.buttonResume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResume_MouseDown);
            this.buttonResume.MouseEnter += new System.EventHandler(this.buttonResume_MouseEnter);
            this.buttonResume.MouseLeave += new System.EventHandler(this.buttonResume_MouseLeave);
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarriorX.Properties.Resources.startBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGamePaused);
            this.Controls.Add(this.buttonResume);
            this.Name = "PauseForm";
            this.Text = "PauseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamePaused)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.PictureBox pictureBoxGamePaused;
    }
}