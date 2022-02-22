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
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //show the length of the pattern
            int patternLength = Form1.pattern.Count - 1;
            scoreLength.Text = $"{patternLength}";

            //add to highscores and sort
            Form1.highScores.Add(patternLength);
            Form1.highScores.Sort();
            Form1.highScores.Reverse();

            //remove lowest
            if (4 <= Form1.highScores.Count)
            {
                Form1.highScores.RemoveAt(3);
            }

            //show highscores
            highscoreLabel.Text = "High Scores";

            for (int i = 0; i < Form1.highScores.Count; i++)
            {
                highscoreLabel.Text += $"\n{Form1.highScores[i]}";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close this screen, open MenuScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen gs = new MenuScreen();
            f.Controls.Add(gs);

            //centre screen on the form
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
