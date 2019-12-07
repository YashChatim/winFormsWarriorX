using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarriorX
{
    public static class Winner
    {
        public static string WinnerOfTheGame(ProgressBar progressBarHealth, String playerWinner)
        {
            if (progressBarHealth.Value == 0)
            {
                GameForm.GameWinner = playerWinner + " Wins";
            }
            return GameForm.GameWinner;
        }
    }
}
