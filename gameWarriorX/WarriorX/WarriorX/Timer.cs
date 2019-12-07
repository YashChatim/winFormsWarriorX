using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarriorX
{
    public static class Timer
    {
        public static void TimerTicking(PictureBox pictureBoxPlayer, Player player, ProgressBar progressBarHealth, Panel panelScreen)
        {
            if (player.MoveLeftPlayer && pictureBoxPlayer.Left > 5)
            {
                pictureBoxPlayer.Left -= 5;
            }

            if (player.MoveRightPlayer && pictureBoxPlayer.Left < 450)
            {
                pictureBoxPlayer.Left += 5;
            }

            #region
            // pictureBoxPlayer.Top += player.JumpSpeedPlayer;

            /*
            if (player.IsJumpingPlayer )
            {
                player.IsJumpingPlayer = false;
            }
            
            if (player.IsJumpingPlayer)
            {
                player.JumpSpeedPlayer = -10;
                player.ForcePlayer -= 1;
            }
            else
            {
                player.JumpSpeedPlayer = 10;
            }
            */
            #endregion

            if (player.IsJumpingPlayer == true && player.ForcePlayer > 0)
            {
                pictureBoxPlayer.Top -= player.ForcePlayer;
                player.ForcePlayer -= 3;
            }

            if (pictureBoxPlayer.Top + pictureBoxPlayer.Height >= panelScreen.Height)
            {
                pictureBoxPlayer.Top = panelScreen.Height - pictureBoxPlayer.Height;
                player.IsJumpingPlayer = false;
            }

            else
            {
                pictureBoxPlayer.Top += 5;
            }

            if (player.HealthPlayer > 1)
            {
                progressBarHealth.Value = player.HealthPlayer;
            }

            else
            {
                progressBarHealth.Value = 0;
            }
        }
    }
}
