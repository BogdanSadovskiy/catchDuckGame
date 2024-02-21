using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace catchDuckGame.Resources
{
    public class Duck
    {
        Random r = new Random();
        public PictureBox duckAnimatio { get; set; }
        Timer timer = new Timer();
        Image tmp;
        Size clientSize;
        Size initialDuckSize;
        int gameLVL;
        int propocion;
        public int speedOfDuck {  get; set; }   
        public int initialspeedOfDuck;
        public Duck(PictureBox duck_, Size clientSize_, int speedOfDuck_)
        {
  
            this.duckAnimatio = duck_;
            tmp = duck_.Image;
            this.clientSize = clientSize_;
            this.speedOfDuck = speedOfDuck_;
            this.initialspeedOfDuck = speedOfDuck;
            this.initialDuckSize = duckAnimatio.Size;
            propocion = initialDuckSize.Width / initialDuckSize.Height;
            this.duckAnimatio.Visible = true;
            timer.Tick += timer_Tick;
            timer.Start();
        }


     

        public PictureBox getDuck()
        {
            return this.duckAnimatio;
        }
        public void setGameLVL(int gamelvl)
        {
            this.gameLVL = gamelvl;
        }
        private int randomizeLocation()
        {
           return r.Next(50,clientSize.Height/2);
            
        }
        private int generateRandomIntervalForDuckAppearing()
        {
            return r.Next(500, 3000);
        }
   
      private void randomizeSpeedOfDuck()
        {
            int speed = 0;
            if(speedOfDuck - initialspeedOfDuck > 3)
            {
                speed = r.Next(-3, 0);
            }
            else if(speedOfDuck - speedOfDuck < 3) {

                speed = r.Next(0, 3);
            }
            else
            {
                if (r.Next(0, 1) == 0)
                {
                    speed++;
                }
                else speed--;
            }
            if ((speedOfDuck + speed) > 0)
            {
                this.speedOfDuck += speed;
            }
        }

        public void newDuckLocation(PictureBox picture)
        {
            timer.Interval = generateRandomIntervalForDuckAppearing();
            picture.Visible = false;
            picture.Location = new Point(0, randomizeLocation());
            randomizeSpeedOfDuck();
          
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (duckAnimatio.Location.X < clientSize.Width)
            {
                timer.Interval = 20;
                duckAnimatio.Visible = true;

                duckAnimatio.Location = new Point(duckAnimatio.Location.X + speedOfDuck, duckAnimatio.Location.Y);
            }
            else
            {
                newDuckLocation(duckAnimatio);
            }
        }
     
    }
}
