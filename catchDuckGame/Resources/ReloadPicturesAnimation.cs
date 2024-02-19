using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace catchDuckGame.Resources
{
    public class ReloadPicturesAnimation
    {
        private List<Image> images = new List<Image>();
        private Timer timer;
        private PictureBox pictureBox;
        private int currentIndex = 0;
        private int currentLoop = 0;

        private bool b = true;

        public ReloadPicturesAnimation()
        {
            images.Add(global::catchDuckGame.Properties.Resources.cs1);
            images.Add(global::catchDuckGame.Properties.Resources.cs2);
            images.Add(global::catchDuckGame.Properties.Resources.cs3);
            images.Add(global::catchDuckGame.Properties.Resources.cs4);
            images.Add(global::catchDuckGame.Properties.Resources.cs5);
            images.Add(global::catchDuckGame.Properties.Resources.cs6);
            images.Add(global::catchDuckGame.Properties.Resources.cs7);
            images.Add(global::catchDuckGame.Properties.Resources.cs8);
            images.Add(global::catchDuckGame.Properties.Resources.cs9);
            images.Add(global::catchDuckGame.Properties.Resources.cs10);




        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (currentIndex < images.Count && currentLoop < 5)
            {
                b = true;
                timer.Start();
                pictureBox.Visible = true;
                pictureBox.Image = images[currentIndex++];
               
                if (currentIndex > 9)
                {
                    currentIndex = 0;
                    currentLoop++;
                }
            }
            else
            {
                timer.Stop();
                currentIndex = 0;
                currentLoop = 0;
                pictureBox.Visible = false;
                b = false;
            }


        }

        public int animation(PictureBox gun, Timer timer, ref bool isReload_)
        {


            this.pictureBox = gun;
            this.timer = timer;
            timer.Interval = 50;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            isReload_ = b;
            Console.WriteLine(isReload_);
            return 5;
        }


       
    }

}