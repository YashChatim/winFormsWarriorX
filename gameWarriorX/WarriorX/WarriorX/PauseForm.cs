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
    public partial class PauseForm : Form
    {
        ChangeForm changeForm = new ChangeForm();

        public PauseForm()
        {
            InitializeComponent();
            buttonResume.FlatAppearance.BorderSize = 0;
        }

        private void buttonResume_MouseEnter(object sender, EventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.resumeHover;
            buttonResume.FlatStyle = FlatStyle.Popup;
        }

        private void buttonResume_MouseLeave(object sender, EventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.resumeButton;
            buttonResume.FlatStyle = FlatStyle.Flat;
        }

        private void buttonResume_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.resumeClick;
        }

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
