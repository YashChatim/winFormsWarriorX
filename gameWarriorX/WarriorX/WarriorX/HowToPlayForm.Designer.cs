namespace WarriorX
{
    partial class HowToPlayForm
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
            this.buttonCloseHowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseHowToPlay
            // 
            this.buttonCloseHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseHowToPlay.Location = new System.Drawing.Point(723, 2);
            this.buttonCloseHowToPlay.Name = "buttonCloseHowToPlay";
            this.buttonCloseHowToPlay.Size = new System.Drawing.Size(59, 46);
            this.buttonCloseHowToPlay.TabIndex = 0;
            this.buttonCloseHowToPlay.UseVisualStyleBackColor = false;
            this.buttonCloseHowToPlay.Click += new System.EventHandler(this.buttonCloseHowToPlay_Click);
            this.buttonCloseHowToPlay.MouseEnter += new System.EventHandler(this.buttonCloseHowToPlay_MouseEnter);
            this.buttonCloseHowToPlay.MouseLeave += new System.EventHandler(this.buttonCloseHowToPlay_MouseLeave);
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarriorX.Properties.Resources.howToPlayBackgroundMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseHowToPlay);
            this.Name = "HowToPlayForm";
            this.Text = "WarriorX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseHowToPlay;
    }
}