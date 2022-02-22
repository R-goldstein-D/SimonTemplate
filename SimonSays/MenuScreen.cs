using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //remove screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            //centre screen on the form
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

        }
        private void instructionsButton_Click(object sender, EventArgs e)
        {
            // remove screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Instructions ins = new Instructions();
            f.Controls.Add(ins);

            //centre screen on the form
            ins.Location = new Point((f.Width - ins.Width) / 2, (f.Height - ins.Height) / 2);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
