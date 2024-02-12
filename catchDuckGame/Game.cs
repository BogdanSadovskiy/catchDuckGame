using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catchDuckGame
{
    public partial class Game : Form
    {
        int score;
        int round;
        int patrons;
      
        public Game()
        {
            InitializeComponent();
            bullet5.BackColor = Color.Transparent;
            bullet4.BackColor = Color.Transparent;
            bullet3.BackColor = Color.Transparent;
            bullet2.BackColor = Color.Transparent;
            bullet1.BackColor = Color.Transparent;
            duckGif.BackColor = Color.Transparent;
            flyTimer.Interval = 15;
            flyTimer.Start();
            score = 0;
            round = 1;
            patrons = 5;
            
        }
       // private PictureBox randomizeDuckStartFly()
       // {

        //}
        private void round_1(PictureBox duck) {
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duckGif.Location.X < ClientSize.Width )
            {
                duckGif.Location = new Point(duckGif.Location.X + 2, duckGif.Location.Y);
            }
            else
            {
                duckGif.Location = new Point(0, duckGif.Location.Y);
               //flyTimer.Stop();
               // duckGif.Hide();

            }
        }
    }
}
