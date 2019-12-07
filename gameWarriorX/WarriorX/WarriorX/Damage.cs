using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorX
{
    public static class Damage
    {
        public static int TakeBlockDamagePlayer(Player damage)
        {
            damage.HealthPlayer = damage.HealthPlayer - 0;
            return damage.HealthPlayer;
        }

        public static int TakeNormalDamagePlayer(Player damage)
        {
            damage.HealthPlayer = damage.HealthPlayer - 1;
            return damage.HealthPlayer;
        }

        public static int TakeStrongDamagePlayer(Player damage)
        {
            damage.HealthPlayer = damage.HealthPlayer - 2;
            return damage.HealthPlayer;
        }
    }
}
