using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WarriorX
{
    public partial class MainForm : Form
    {
        ChangeForm changeForm = new ChangeForm();

        public MainForm()
        {
            InitializeComponent();
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonHowToPlay.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatAppearance.BorderSize = 0;

            Music.PlayBackgroundMusic();
        }

        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.startOnHover;
            buttonStart.FlatStyle = FlatStyle.Popup;
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.startButton;
            buttonStart.FlatStyle = FlatStyle.Flat;
        }

        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.startClick;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            changeForm.ChangeToStartForm();
            this.Hide();
        }

        private void buttonHowToPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonHowToPlay.BackgroundImage = Properties.Resources.howToPlayHover;
            buttonHowToPlay.FlatStyle = FlatStyle.Popup;
        }

        private void buttonHowToPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonHowToPlay.BackgroundImage = Properties.Resources.howToPlayButton;
            buttonHowToPlay.FlatStyle = FlatStyle.Flat;
        }

        private void buttonHowToPlay_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHowToPlay.BackgroundImage = Properties.Resources.howToPlayClick;
        }

        private void ButtonHowToPlay_Click(object sender, EventArgs e)
        {
            changeForm.ChangeToHowToPlayForm();
            this.Hide();
        }


        private void buttonQuit_MouseEnter(object sender, EventArgs e)
        {
            buttonQuit.BackgroundImage = Properties.Resources.quitHover;
            buttonQuit.FlatStyle = FlatStyle.Popup;
        }

        private void buttonQuit_MouseLeave(object sender, EventArgs e)
        {
            buttonQuit.BackgroundImage = Properties.Resources.quitButton;
            buttonQuit.FlatStyle = FlatStyle.Flat;
        }

        private void buttonQuit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonQuit.BackgroundImage = Properties.Resources.quitClick;
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Music.StopBackgroundMusic();
        }
    }
}
