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
            createDuck();

            score = 0;
            patrons = 5;

            checkIfReloaded.Tick += CheckIfReloaded_Tick;

        }
        
        private void ScoreCheck()
        {
            this.scoreLabel.Text = "Score: " + score;
            if (score < 60)
            {
                if (GameDifficulty.isLvlUp(score, gameLVL))
                {
                    speedOfDuck++;
                    createDuck();
                    gameLVL++;
                    setSpeedOfDuck();
                }
            }
        }
        private void setSpeedOfDuck()
        {
            foreach (Duck duck in ducks)
            {
                duck.setGameLVL(gameLVL);
                duck.initialspeedOfDuck = speedOfDuck;
            }
        }
        private void createDuck()
        {
            PictureBox image = new PictureBox();
            image.BackColor = System.Drawing.Color.Transparent;
            image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            image.Image = global::catchDuckGame.Properties.Resources.duck;
            image.InitialImage = null;
            image.Location = new System.Drawing.Point(1, 112);
            image.Margin = new System.Windows.Forms.Padding(0);
            image.Name = "duckGif";
            image.Size = new System.Drawing.Size(42, 28);
            image.TabIndex = 0;
            image.TabStop = false;
            image.Click += new System.EventHandler(this.duckGif_Click);
            Controls.Add(image);
            Duck newDuck = new Duck(image, ClientSize, speedOfDuck);

            ducks.Add(newDuck);

        }
        private void reloadGun()
        {

            checkIfReloaded.Interval = 100;
            checkIfReloaded.Start();
            ReloadPicturesAnimation.animation(this.reloadPicture);


        }

        private void CheckIfReloaded_Tick(object sender, EventArgs e)
        {
            if (ReloadPicturesAnimation.getP() == 1)
            {
                patrons = 5;
                patronsCheck();
                checkIfReloaded.Stop();
            }

        }


        private void patronsCheck()
        {
            allPatronsCheck();
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
            if (allPatrons == 0)
            {
                this.scoreLabel.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                this.scoreLabel.Size = new Size(scoreLabel.Size.Width * 2, scoreLabel.Size.Height * 2);
                this.scoreLabel.Text = "GAME OVER\n" + scoreLabel.Text;
            }
        }

        private bool shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                allPatrons--;
                patronsCheck();
                return true;
            }
            return false;
        }


        public void duckGif_Click(object sender, EventArgs e)
        {
            PictureBox duck_ = (PictureBox)sender;
            if (shoot())
            {
                score += 1 * gameLVL;
                ScoreCheck();

                duck_.Visible = false;
                Duck tmp = ducks.Find((duck__) => duck__.getDuck().Equals(duck_));
                tmp.newDuckLocation(duck_);
            }
        }

        private void Game_Click(object sender, EventArgs e)
        {
          shoot();
            Console.WriteLine(ducks.Count);
        }


    }
}
