using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{

    public partial class Form1 : Form
    {
        bool jumping = false; // boolean to check if player is jumping or not
        int jumpSpeed = 10; // integer to set jump speed
        int force = 12; // force of the jump in an integer
        int score = 0; // default score integer set to 0
        int obstacleSpeed = 10; // the default speed for the obstacles
        Random rnd = new Random(); // create a new random class
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            scoreText.Text = "Score: " + score;

            if (jumping && force < 0)
                jumping = false;

            if (jumping)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else
                jumpSpeed = 15;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed; 

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score++;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        //trex.Image = Properties.Resources.dead;
                        scoreText.Text += "  Press R to restart";
                    }
                }
            }

            if (trex.Top >= 380 && !jumping)
            {
                force = 12;
                trex.Top = floor.Top - trex.Height;
                jumpSpeed = 0;
            }

            if (score >= 10)
                obstacleSpeed = 15;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
                jumping = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                resetGame();

            if (jumping)
                jumping = false;
        }
        public void resetGame()
        {
            force = 12;
            trex.Top = floor.Top - trex.Height;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            scoreText.Text = "Score: " + score;
            //trex.Image = Properties.Resources.running;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    int position = rnd.Next(600, 1000);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }

            gameTimer.Start();
        }
    }

}
