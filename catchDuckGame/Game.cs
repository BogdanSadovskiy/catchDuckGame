using catchDuckGame.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace catchDuckGame
{
    public partial class Game : Form
    {
        int speedOfDuck;
        int score;
        int patrons;
        int currentDucks;
        bool isReloading = false;
        Timer reloadGunTimer = new Timer();


        List<PictureBox> ducks = new List<PictureBox>();
        ReloadPicturesAnimation ReloadPicturesAnimation = new ReloadPicturesAnimation();
        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ducks.Add(duckGif);
            bullet5.BackColor = Color.Transparent;
            bullet4.BackColor = Color.Transparent;
            bullet3.BackColor = Color.Transparent;
            bullet2.BackColor = Color.Transparent;
            bullet1.BackColor = Color.Transparent;
            duckGif.BackColor = Color.Transparent;
            reloadPicture.Visible = false;


            flyTimer.Interval = 15;
            flyTimer.Start();

            speedOfDuck = 2;
            score = 0;
            patrons = 5;


        }

        private void ScoreCheck()
        {
            this.scoreLabel.Text = "Score: " + score;
        }

        private void createDuck()
        {

        }
        private void reloadGun()
        {
            patrons = ReloadPicturesAnimation.animation(this.reloadPicture, reloadGunTimer,ref isReloading);
            if(!isReloading)patronsCheck();
            Console.WriteLine(isReloading);
        }
        /* private void reloadGunTimer_Tick(object sender, EventArgs e)
         {
             reloadGunTimer.Stop();
             reloadPicture.Visible = false;
         }*/
        private void patronsCheck()
        {

            switch (patrons)
            {
                case 5:
                    {
                        bullet5.Visible = true;
                        bullet4.Visible = true;
                        bullet3.Visible = true;
                        bullet2.Visible = true;
                        bullet1.Visible = true;
                        break;
                    }
                case 4:
                    {
                        bullet1.Visible = false;
                        break;
                    }
                case 3:
                    {
                        bullet2.Visible = false;
                        break;
                    }
                case 2:
                    {
                        bullet3.Visible = false;
                        break;
                    }
                case 1:
                    {
                        bullet4.Visible = false;
                        break;
                    }

                default:
                    {
                        bullet5.Visible = false;
                        reloadGun();
                        break;
                    }
            }
        }

        private void newDuckLocation(PictureBox picture)
        {
            flyTimer.Interval = 3000;
            picture.Visible = false;
            picture.Location = new Point(0, picture.Location.Y);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duckGif.Location.X < ClientSize.Width)
            {
                flyTimer.Interval = 15;
                duckGif.Visible = true;

                duckGif.Location = new Point(duckGif.Location.X + speedOfDuck, duckGif.Location.Y);
            }
            else
            {
                newDuckLocation(duckGif);
            }
        }
        private void shotAnim()
        {

        }
        private void duckGif_Click(object sender, EventArgs e)
        {
            score++;
            patrons--;
            patronsCheck();
            ScoreCheck();

            duckGif.Visible = false;
            newDuckLocation(duckGif);
        }

        private void Game_Click(object sender, EventArgs e)
        {
            patrons--;
            patronsCheck();
        }

    }
}
