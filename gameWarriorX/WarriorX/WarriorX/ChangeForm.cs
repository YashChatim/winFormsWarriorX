using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WarriorX
{
    public class ChangeForm
    {
        public ChangeForm() { }

        public void ChangeToStartForm()
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        public void ChangeToHowToPlayForm()
        {
            HowToPlayForm howToPlayForm = new HowToPlayForm();
            howToPlayForm.Show();
        }

        public void ChangeToMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        public void ChangeToEndForm()
        {
            EndForm endForm = new EndForm();
            endForm.Show();
        }
    }
}
