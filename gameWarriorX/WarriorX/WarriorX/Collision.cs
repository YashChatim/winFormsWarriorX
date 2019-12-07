using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorX
{
    public static class Collision
    {
        public static void CollidingWithPlayer(Player playerColliding, Player playerCollidingWith)
        {
            if (playerColliding.IsNormalAttackingPlayer && !playerCollidingWith.IsCrouchingAndBlockingPlayer)
            {
                Damage.TakeNormalDamagePlayer(playerCollidingWith);
            }

            if (playerColliding.IsStrongAttackingPlayer && !playerCollidingWith.IsCrouchingAndBlockingPlayer)
            {
                Damage.TakeStrongDamagePlayer(playerCollidingWith);
            }

            if (playerColliding.IsNormalAttackingPlayer && playerCollidingWith.IsCrouchingAndBlockingPlayer)
            {
                Damage.TakeBlockDamagePlayer(playerCollidingWith);
            }

            if (playerColliding.IsStrongAttackingPlayer && playerCollidingWith.IsCrouchingAndBlockingPlayer)
            {
                Damage.TakeBlockDamagePlayer(playerCollidingWith);
            }
        }
    }
}
