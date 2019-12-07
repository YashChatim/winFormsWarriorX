using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarriorX
{
    public partial class GameForm : Form
    {
        ChangeForm changeForm = new ChangeForm();
        Player playerOne = new Player();
        Player playerTwo = new Player();

        private static string gameWinner;

        public static string GameWinner { get => gameWinner; set => gameWinner = value; }

        public GameForm()
        {
            InitializeComponent();
        }

        private void PlayerKeyDown(object sender, KeyEventArgs e)
        {
            KeyInput.playerPressingKeyOne(playerOne, e, pictureBoxPlayerOne, pictureBoxHealth);
            KeyInput.playerPressingKeyTwo(playerTwo, e, pictureBoxPlayerTwo, pictureBoxHealth);
        }

        private void PlayerKeyUp(object sender, KeyEventArgs e)
        {
            KeyInput.playerReleasingKeyOne(playerOne, e, pictureBoxPlayerOne);
            KeyInput.playerReleasingKeyTwo(playerTwo, e, pictureBoxPlayerTwo);
        }

        private void TimerOne(object sender, EventArgs e)
        {
            Timer.TimerTicking(pictureBoxPlayerOne, playerOne, progressBarHealthPlayerOne, panelScreen);
            Player.GetBoundsOfPlayer(pictureBoxPlayerOne, pictureBoxPlayerTwo);

            if ((Player.PlayerOneBounds >= pictureBoxPlayerTwo.Left) && (pictureBoxPlayerOne.Left <= Player.PlayerTwoBounds))
            {
                Collision.CollidingWithPlayer(playerOne, playerTwo);
                CheckForGameEnd();
            }
        }

        private void TimerTwo(object sender, EventArgs e)
        {
            Timer.TimerTicking(pictureBoxPlayerTwo, playerTwo, progressBarHealthPlayerTwo, panelScreen);
            Player.GetBoundsOfPlayer(pictureBoxPlayerOne, pictureBoxPlayerTwo);

            if ((pictureBoxPlayerTwo.Left <= Player.PlayerOneBounds) && (Player.PlayerTwoBounds >= pictureBoxPlayerOne.Left))
            {
                Collision.CollidingWithPlayer(playerTwo, playerOne);
                CheckForGameEnd();
            }
        }

        public void CheckForGameEnd()
        {
            if (progressBarHealthPlayerOne.Value <= 0 || progressBarHealthPlayerTwo.Value <= 0)
            {
                timerOne.Stop();
                timerTwo.Stop();
                CheckForWinner();
                changeForm.ChangeToEndForm();
                this.Hide();
            }
        }

        public void CheckForWinner()
        {
            Winner.WinnerOfTheGame(progressBarHealthPlayerOne, "PlayerTwo");
            Winner.WinnerOfTheGame(progressBarHealthPlayerTwo, "PlayerOne");
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            this.Hide();
            PauseForm pauseForm = new PauseForm();
            pauseForm.ShowDialog();
            this.Show();
        }
    }
}
