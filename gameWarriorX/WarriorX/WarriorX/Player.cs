using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarriorX
{
    public class Player
    {
        public Player() { }

        private bool moveLeftPlayer = false;
        private bool moveRightPlayer = false;
        private bool isJumpingPlayer = false;
        private bool isCrouchingAndBlockingPlayer = false;
        private bool isNormalAttackingPlayer = false;
        private bool isStrongAttackingPlayer = false;


        // private int jumpSpeedPlayer;
        private static int playerOneBounds;
        private static int playerTwoBounds;
        private int forcePlayer;
        private int gravity = 30;
        private int healthPlayer = 265;

        public bool MoveLeftPlayer { get => moveLeftPlayer; set => moveLeftPlayer = value; }
        public bool MoveRightPlayer { get => moveRightPlayer; set => moveRightPlayer = value; }
        public bool IsJumpingPlayer { get => isJumpingPlayer; set => isJumpingPlayer = value; }
        public bool IsCrouchingAndBlockingPlayer { get => isCrouchingAndBlockingPlayer; set => isCrouchingAndBlockingPlayer = value; }
        public bool IsNormalAttackingPlayer { get => isNormalAttackingPlayer; set => isNormalAttackingPlayer = value; }
        public bool IsStrongAttackingPlayer { get => isStrongAttackingPlayer; set => isStrongAttackingPlayer = value; }
        // public int JumpSpeedPlayer { get => jumpSpeedPlayer; set => jumpSpeedPlayer = value; }
        public static int PlayerOneBounds { get => playerOneBounds; set => playerOneBounds = value; }
        public static int PlayerTwoBounds { get => playerTwoBounds; set => playerTwoBounds = value; }
        public int ForcePlayer { get => forcePlayer; set => forcePlayer = value; }
        public int Gravity { get => gravity; set => gravity = value; }
        public int HealthPlayer { get => healthPlayer; set => healthPlayer = value; }
        

        public static void GetBoundsOfPlayer(PictureBox pictureBoxPlayerOne, PictureBox pictureBoxPlayerTwo)
        {
            PlayerOneBounds = pictureBoxPlayerOne.Left + pictureBoxPlayerOne.Width;
            PlayerTwoBounds = pictureBoxPlayerTwo.Left + pictureBoxPlayerTwo.Width;
        }
    }
}
