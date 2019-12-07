using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace WarriorX
{
    public static class KeyInput
    {
        public static void playerPressingKeyOne(Player movementStartOne, KeyEventArgs keys, PictureBox pictureBoxPlayerOne, PictureBox pictureBoxHealthBackground)
        {
            if (movementStartOne.IsJumpingPlayer != true && pictureBoxPlayerOne.Top > pictureBoxHealthBackground.Top + pictureBoxHealthBackground.Height + 50)
            {
                if (keys.KeyCode == Keys.W)
                {
                    movementStartOne.IsJumpingPlayer = true;
                    movementStartOne.ForcePlayer = movementStartOne.Gravity; 
                }
            }

            if (keys.KeyCode == Keys.S)
            {
                movementStartOne.IsCrouchingAndBlockingPlayer = true;
                pictureBoxPlayerOne.BackgroundImage = Properties.Resources.redBlocking;
            }

            if (keys.KeyCode == Keys.A)
            {
                movementStartOne.MoveLeftPlayer = true;
            }

            if (keys.KeyCode == Keys.D)
            {
                movementStartOne.MoveRightPlayer = true;
            }

            if (keys.KeyCode == Keys.Z)
            {
                movementStartOne.IsNormalAttackingPlayer = true;
                pictureBoxPlayerOne.BackgroundImage = Properties.Resources.redNormal;
            }

            if (keys.KeyCode == Keys.Space)
            {
                movementStartOne.IsStrongAttackingPlayer = true;
                pictureBoxPlayerOne.BackgroundImage = Properties.Resources.redStrong;
            }

            
        }

        public static void playerPressingKeyTwo(Player movementStartTwo, KeyEventArgs keys, PictureBox pictureBoxPlayerTwo, PictureBox pictureBoxHealthBackground)
        {
            #region
            /*
            if (keys.KeyCode == Keys.Up && !movementStartTwo.IsJumpingPlayer)
            {
                movementStartTwo.IsJumpingPlayer = true;
            }
            */
            #endregion

            if (movementStartTwo.IsJumpingPlayer != true && pictureBoxPlayerTwo.Top > pictureBoxHealthBackground.Top + pictureBoxHealthBackground.Height + 50)
            {
                if (keys.KeyCode == Keys.Up)
                {
                    movementStartTwo.IsJumpingPlayer = true;
                    movementStartTwo.ForcePlayer = movementStartTwo.Gravity;
                }
            }

            if (keys.KeyCode == Keys.Down)
            {
                movementStartTwo.IsCrouchingAndBlockingPlayer = true;
                pictureBoxPlayerTwo.BackgroundImage = Properties.Resources.purpleBlocking;
            }

            if (keys.KeyCode == Keys.Left)
            {
                movementStartTwo.MoveLeftPlayer = true;
            }

            if (keys.KeyCode == Keys.Right)
            {
                movementStartTwo.MoveRightPlayer = true;
            }

            if (keys.KeyCode == Keys.NumPad1)
            {
                movementStartTwo.IsNormalAttackingPlayer = true;
                pictureBoxPlayerTwo.BackgroundImage = Properties.Resources.purpleNormal;
            }

            if (keys.KeyCode == Keys.NumPad0)
            {
                movementStartTwo.IsStrongAttackingPlayer = true;
                pictureBoxPlayerTwo.BackgroundImage = Properties.Resources.purpleStrong;
            }
        }

        public static void playerReleasingKeyOne(Player movementStopOne, KeyEventArgs keys, PictureBox pictureBoxPlayerOne)
        {
            switch (keys.KeyCode)
            {
                case Keys.W:
                    movementStopOne.IsJumpingPlayer = false;
                    break;

                case Keys.S:
                    movementStopOne.IsCrouchingAndBlockingPlayer = false;
                    pictureBoxPlayerOne.BackgroundImage = Properties.Resources.redIdle;
                    break;

                case Keys.A:
                    movementStopOne.MoveLeftPlayer = false;
                    break;

                case Keys.D:
                    movementStopOne.MoveRightPlayer = false;
                    break;

                case Keys.Z:
                    movementStopOne.IsNormalAttackingPlayer = false;
                    pictureBoxPlayerOne.BackgroundImage = Properties.Resources.redIdle;
                    break;

                case Keys.Space:
                    movementStopOne.IsStrongAttackingPlayer = false;
                    pictureBoxPlayerOne.BackgroundImage = Properties.Resources.redIdle;
                    break;
            }
        }

        public static void playerReleasingKeyTwo(Player movementStopTwo, KeyEventArgs keys, PictureBox pictureBoxPlayerTwo)
        {
            switch (keys.KeyCode)
            {
                case Keys.Up:
                    movementStopTwo.IsJumpingPlayer = false;
                    break;

                case Keys.Down:
                    movementStopTwo.IsCrouchingAndBlockingPlayer = false;
                    pictureBoxPlayerTwo.BackgroundImage = Properties.Resources.purpleIdle;
                    break;

                case Keys.Left:
                    movementStopTwo.MoveLeftPlayer = false;
                    break;

                case Keys.Right:
                    movementStopTwo.MoveRightPlayer = false;
                    break;

                case Keys.NumPad1:
                    movementStopTwo.IsNormalAttackingPlayer = false;
                    pictureBoxPlayerTwo.BackgroundImage = Properties.Resources.purpleIdle;
                    break;

                case Keys.NumPad0:
                    movementStopTwo.IsStrongAttackingPlayer = false;
                    pictureBoxPlayerTwo.BackgroundImage = Properties.Resources.purpleIdle;
                    break;
            }
        }
    }
}
