using catchDuckGame.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace catchDuckGame
{
    public partial class Game : Form
    {
        int speedOfDuck;
        int score;
        int patrons;
        int allPatrons = 60;
        int gameLVL = 1;
        Timer reloadGunTimer = new Timer();
        Timer checkIfReloaded = new Timer();

        List<Duck> ducks = new List<Duck>();
        ReloadPicturesAnimation ReloadPicturesAnimation = new ReloadPicturesAnimation();
        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
         
            bullet5.BackColor = Color.Transparent;
            bullet4.BackColor = Color.Transparent;
            bullet3.BackColor = Color.Transparent;
            bullet2.BackColor = Color.Transparent;
            bullet1.BackColor = Color.Transparent;
            duckGif.BackColor = Color.Transparent;
            reloadPicture.Visible = false;
            duckGif.Visible = false;

            flyTimer.Interval = 20;
            flyTimer.Start();
            speedOfDuck = 1;
            ducks.Add(new Duck(duckGif, flyTimer, ClientSize, speedOfDuck));
            addPictureToControls(ducks.Last().getDuck());

           
            score = 0;
            patrons = 5;
   


        }
        private void addPictureToControls(PictureBox picture)
        {
            Controls.Add(picture);
        }
        private void ScoreCheck()
        {
            this.scoreLabel.Text = "Score: " + score;
            if (score == 5 || score == 10 || score == 20 || score == 40 || score == 80)
            {
                speedOfDuck++;
                createDuck();
                gameLVL++;
            }
        }

        private void createDuck()
        {
            ducks.Add(ducks.Last());
            addPictureToControls(ducks.Last().getDuck());
        }
        private void reloadGun()
        {
            
            checkIfReloaded.Tick += CheckIfReloaded_Tick;
            checkIfReloaded.Interval = 100;
            checkIfReloaded.Start();
            patrons = ReloadPicturesAnimation.animation(this.reloadPicture, reloadGunTimer);


        }

        private void CheckIfReloaded_Tick(object sender, EventArgs e)
        {
            if (ReloadPicturesAnimation.getP() == 1) {
                patronsCheck();
                checkIfReloaded.Stop();
            }

        }


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

        private void allPatronsCheck()
        {
            if(allPatrons==0)
            {
                this.scoreLabel.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                this.scoreLabel.Size = new Size(scoreLabel.Size.Width * 2, scoreLabel.Size.Height * 2);
                this.scoreLabel.Text = "GAME OVER\n" + scoreLabel.Text;
            }
        }




        public void duckGif_Click(object sender, EventArgs e)
        {
            PictureBox duck_ = (PictureBox)sender;
            score += 1 * gameLVL;
            patrons--;
            allPatrons--;
            patronsCheck();
            ScoreCheck();

            duck_.Visible = false;
            Duck tmp = ducks.Find((duck__) => duck__.getDuck().Equals(duck_));
            tmp.newDuckLocation(duck_);
        }

        private void Game_Click(object sender, EventArgs e)
        {
            patrons--;
            allPatrons--;
            patronsCheck();
        }


    }
}
