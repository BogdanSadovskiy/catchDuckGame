using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace catchDuckGame.Resources
{
    public class ReloadPicturesAnimation
    {
        private List<Image> images = new List<Image>();
        private Timer timer= new Timer();
        private PictureBox pictureBox;
        private int currentIndex = 0;
        private int currentLoop = 0;
        int index = 1;
        private int p = 0; //nothing

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

            timer.Tick += Timer_Tick;
            timer.Interval = 50;
           

        }
        public int getP()
        {
            return this.p;
        }
        public void Timer_Tick(object sender, EventArgs e)
        {

            if (currentIndex < images.Count && currentLoop < 5)
            {
                Console.WriteLine(index++);
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
                p = 1;
                index = 1;
            }


        }

        public void animation(PictureBox gun)
        {

            p = 2;
            this.pictureBox = gun;

            
           
            timer.Start();
            Console.WriteLine(2);

        }


       
    }

}