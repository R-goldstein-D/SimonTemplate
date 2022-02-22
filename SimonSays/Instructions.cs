using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    //instructions screen but i forgot to add "screen" when naming the screen
    public partial class Instructions : UserControl
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            //close this screen, open MenuScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen gs = new MenuScreen();
            f.Controls.Add(gs);

            //centre screen on the form
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }
    }
}
