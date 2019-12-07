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
    public partial class EndForm : Form
    {
        ChangeForm changeForm = new ChangeForm();
        GameForm gameForm = new GameForm();

        public EndForm()
        {
            InitializeComponent();
            buttonRestart.FlatAppearance.BorderSize = 0;
            buttonMain.FlatAppearance.BorderSize = 0;
            labelDisplayWinner.Text = GameForm.GameWinner;
        }

        private void buttonRestart_MouseEnter(object sender, EventArgs e)
        {
            buttonRestart.BackgroundImage = Properties.Resources.restartHover;
            buttonRestart.FlatStyle = FlatStyle.Popup;
        }

        private void buttonRestart_MouseLeave(object sender, EventArgs e)
        {
            buttonRestart.BackgroundImage = Properties.Resources.restartButton;
            buttonRestart.FlatStyle = FlatStyle.Flat;
        }

        private void buttonRestart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRestart.BackgroundImage = Properties.Resources.restartClick;
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            changeForm.ChangeToStartForm();
            this.Hide();
        }

        private void buttonMain_MouseEnter(object sender, EventArgs e)
        {
            buttonMain.BackgroundImage = Properties.Resources.mainMenuHover;
            buttonMain.FlatStyle = FlatStyle.Popup;
        }

        private void buttonMain_MouseLeave(object sender, EventArgs e)
        {
            buttonMain.BackgroundImage = Properties.Resources.mainMenuButton;
            buttonMain.FlatStyle = FlatStyle.Flat;
        }

        private void buttonMain_MouseDown(object sender, MouseEventArgs e)
        {
            buttonMain.BackgroundImage = Properties.Resources.mainMenuClick;
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            changeForm.ChangeToMainForm();
            this.Hide();
        }
    }
}
