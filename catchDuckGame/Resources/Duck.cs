using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace catchDuckGame.Resources
{
    public class Duck
    {
        Random r = new Random();
        PictureBox duckAnimatio { get; set; }
        Timer timer { get; set; }
        Size clientSize;
        Size initialDuckSize;
        int gameLVL;
        int propocion;
        int speedOfDuck;
        public Duck(PictureBox duck_, Timer timer_, Size clientSize_, int speedOfDuck_)
        {
            this.duckAnimatio = duck_;
            this.timer = timer_;
            this.clientSize = clientSize_;
            this.speedOfDuck = speedOfDuck_;
            this.initialDuckSize = duckAnimatio.Size;
            propocion = initialDuckSize.Width / initialDuckSize.Height;
            this.duckAnimatio.Visible = true;
            timer.Tick += timer_Tick;
            timer.Start();
        }


        private void DuckAnimatio_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
           return r.Next(100,clientSize.Height/2);
            
        }
        private int generateRandomIntervalForDuckAppearing()
        {
            return r.Next(1000, 3000);
        }
        private Size randomizeSizeOfDuck()
        {
            int x = 0, y = 0;
            if (duckAnimatio.Size.Width <= 20)
            {
                x = r.Next(duckAnimatio.Width, duckAnimatio.Width * 2);
            }
            else if (duckAnimatio.Size.Width >= 60)
            {
                x = r.Next( duckAnimatio.Width / 2, duckAnimatio.Width);
            }
            else
            {
                 x = r.Next(duckAnimatio.Width / 2, duckAnimatio.Width * 2);
                
            }
            y = (int)(x / 1.5);
            return new Size(x, y);
        }
        public void newDuckLocation(PictureBox picture)
        {
            timer.Interval = generateRandomIntervalForDuckAppearing();
            picture.Visible = false;
            picture.Location = new Point(0, randomizeLocation());
            picture.Size = randomizeSizeOfDuck();
          
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
