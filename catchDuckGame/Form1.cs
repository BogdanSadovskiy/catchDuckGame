using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catchDuckGame
{
    public partial class menu : Form
    {
        Game game;
        Panel panel = new Panel();
        public menu()
        {
            InitializeComponent();
            panel.Dock = DockStyle.Fill;  
            Controls.Add(panel);
        }
        private void initializeGame()
        {
            game = new Game();
            game.TopLevel = false;
            game.FormBorderStyle = FormBorderStyle.None;
            game.Dock = DockStyle.Fill;
            game.FormClosed += Game_FormClosed;
            panel.Controls.Add(game);
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Hide();
            initializeGame();
            game.Show();
        }
    }
}
