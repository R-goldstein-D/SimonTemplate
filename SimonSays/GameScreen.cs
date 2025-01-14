﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //create random
        Random rand = new Random();
        //transform squares to 1/4 in shapebutton function
        Matrix transformMatrix = new Matrix();
        //create guess variable to track what part of the pattern the user is at
        int guessIndex;
        //timer counter
        int counter = 100;
        int pause = 500;

        //buttons
        List<Color> baseColours = new List<Color>(new Color[] { Color.DarkSlateGray, Color.SandyBrown, Color.Indigo, Color.SteelBlue });
        List<Color> lightColours = new List<Color>(new Color[] { Color.Teal, Color.BurlyWood, Color.BlueViolet, Color.LightSteelBlue });
        Button[] buttons = new Button[4];

        //sounds
        List<SoundPlayer> gameSounds = new List<SoundPlayer>(new SoundPlayer[] {
            new SoundPlayer(Properties.Resources.darkgreen), new SoundPlayer(Properties.Resources.purple),
            new SoundPlayer(Properties.Resources.yellow), new SoundPlayer(Properties.Resources.blue),
            new SoundPlayer(Properties.Resources.gameover),});


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Enable the timer 
            Timer.Enabled = true;

            //shape them buttons baby
            ShapeButtons();

            //add buttons to list girlboss
            buttons[0] = darktourButton;
            buttons[1] = lightoranButton;
            buttons[2] = indigoButton;
            buttons[3] = blueButton;

            //set pattern completed label to 0
            patternlengthLabel.Text = "0";
            patternlengthLabel.Refresh();

            //clear pattern list, refresh, pause
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(1000);

            //begin game with computerturn()
            ComputerTurn();
        }

        //shaping button to 1/4 pie shape
        public void ShapeButtons()
        {
            //add ouside and inside circle to shape edges
            GraphicsPath circlePath = new GraphicsPath(); //create curved edge and centre hole
            circlePath.AddEllipse(5, 5, 220, 220);
            circlePath.AddEllipse(70, 70, 80, 80);

            Region buttonRegion = new Region(circlePath);

            //exclude edges from region
            buttonRegion.Exclude(new Rectangle(0, 105, 110, 5)); //remove outside edges
            buttonRegion.Exclude(new Rectangle(0, 0, 5, 110));
            buttonRegion.Exclude(new Rectangle(0, 0, 110, 5));
            buttonRegion.Exclude(new Rectangle(105, 0, 5, 110));

            //apply to buttons and rotate as necessary 
            darktourButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55));
            buttonRegion.Transform(transformMatrix);
            lightoranButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55));
            buttonRegion.Transform(transformMatrix);
            indigoButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55));
            buttonRegion.Transform(transformMatrix);
            blueButton.Region = buttonRegion;
        }

        private void ComputerTurn()
        {
            //get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            Form1.pattern.Add(rand.Next(0, 4));

            //create a for loop that shows each value in the pattern by lighting up approriate button for (int i = 0; i < Form1.pattern.Count; i++)
            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                buttons[Form1.pattern[i]].BackColor = lightColours[Form1.pattern[i]];
                gameSounds[Form1.pattern[i]].Play();
                buttons[Form1.pattern[i]].Refresh();
                Thread.Sleep(pause);
                buttons[Form1.pattern[i]].BackColor = baseColours[Form1.pattern[i]];
                buttons[Form1.pattern[i]].Refresh();
                Thread.Sleep(pause);
            }

            //get guess index value back to 0
            guessIndex = 0;
        }

        public void GameOver()
        {
            //disable timer
            Timer.Enabled = false;

            //play game over sound
            gameSounds[4].Play();

            //close this screen, open GameOverScreen
            Form f = FindForm();
            f.Controls.Remove(this);

            GameOverScreen go = new GameOverScreen();
            f.Controls.Add(go);

            //centre screen on the form
            go.Location = new Point((f.Width - go.Width) / 2, (f.Height - go.Height) / 2);
        }

        //event methods for each button
        private void darktourButton_Click_1(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 0)
            {
                ButtonClick();
            }
            else
            {
                GameOver();
            }
        }
        private void lightoranButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 1)
            {
                ButtonClick();
            }
            else
            {
                GameOver();
            }
        }

        private void indigoButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 2)
            {
                ButtonClick();
            }
            else
            {
                GameOver();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 3)
            {
                ButtonClick();
            }
            else
            {
                GameOver();
            }
        }
        public void ButtonClick()
        {
            //for button pressed, light up button, play sound, and pause
            buttons[Form1.pattern[guessIndex]].BackColor = lightColours[Form1.pattern[guessIndex]];
            gameSounds[Form1.pattern[guessIndex]].Play();
            buttons[Form1.pattern[guessIndex]].Refresh();
            Thread.Sleep(pause);
            //set button colour back to original
            buttons[Form1.pattern[guessIndex]].BackColor = baseColours[Form1.pattern[guessIndex]];
            buttons[Form1.pattern[guessIndex]].Refresh();
            Thread.Sleep(pause);

            //add one to guess index
            guessIndex++;

            //this allowes the timer to refesh with every button click
            counter = 100;

            //check for end of pattern
            if (guessIndex == Form1.pattern.Count)
            {
                patternlengthLabel.Text = guessIndex.ToString();
                patternlengthLabel.Refresh();

                ComputerTurn();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //counter goes down
            counter--;

            //once counter hits zero and no button is pressed, game over
            if (counter <= 0)
            {
                GameOver();
            }

            //add countdown to label
            timerLabel.Text = $"{counter}";
        }
    }
}
