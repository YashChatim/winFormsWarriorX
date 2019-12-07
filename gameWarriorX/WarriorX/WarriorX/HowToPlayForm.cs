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
    public partial class HowToPlayForm : Form
    {
        ChangeForm changeForm = new ChangeForm();

        public HowToPlayForm()
        {
            InitializeComponent();
            buttonCloseHowToPlay.FlatAppearance.BorderSize = 0;
        }

        private void buttonCloseHowToPlay_Click(object sender, EventArgs e)
        {
            
            changeForm.ChangeToMainForm();
            this.Hide();
        }

        private void buttonCloseHowToPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonCloseHowToPlay.FlatStyle = FlatStyle.Popup;
        }

        private void buttonCloseHowToPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseHowToPlay.FlatStyle = FlatStyle.Flat;
        }
    }
}
