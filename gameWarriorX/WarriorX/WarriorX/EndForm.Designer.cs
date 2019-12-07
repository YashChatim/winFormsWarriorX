namespace WarriorX
{
    partial class EndForm
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
            this.labelDisplayWinner = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDisplayWinner
            // 
            this.labelDisplayWinner.AutoSize = true;
            this.labelDisplayWinner.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDisplayWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelDisplayWinner.Location = new System.Drawing.Point(137, 74);
            this.labelDisplayWinner.Name = "labelDisplayWinner";
            this.labelDisplayWinner.Size = new System.Drawing.Size(0, 76);
            this.labelDisplayWinner.TabIndex = 0;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.BackgroundImage = global::WarriorX.Properties.Resources.restartButton;
            this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Location = new System.Drawing.Point(281, 221);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(244, 67);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            this.buttonRestart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRestart_MouseDown);
            this.buttonRestart.MouseEnter += new System.EventHandler(this.buttonRestart_MouseEnter);
            this.buttonRestart.MouseLeave += new System.EventHandler(this.buttonRestart_MouseLeave);
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.Transparent;
            this.buttonMain.BackgroundImage = global::WarriorX.Properties.Resources.mainMenuButton;
            this.buttonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Location = new System.Drawing.Point(281, 309);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(244, 67);
            this.buttonMain.TabIndex = 5;
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            this.buttonMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseDown);
            this.buttonMain.MouseEnter += new System.EventHandler(this.buttonMain_MouseEnter);
            this.buttonMain.MouseLeave += new System.EventHandler(this.buttonMain_MouseLeave);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarriorX.Properties.Resources.startBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelDisplayWinner);
            this.Name = "EndForm";
            this.Text = "WarriorX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisplayWinner;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonMain;
    }
}