using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //List to store the pattern. Must be accessable on other screens
        public static List<int> pattern = new List<int>();
        //highscore list
        public static List<int> highScores = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launch screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            //centre screen on the form
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
