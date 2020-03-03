using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Result : Form
    {
        public static bool winner;
        public Result(bool winnerSide)
        {
            winner = winnerSide;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if (winner)
            {
                label1.Text = "Shield won!";
                pictureBox1.Image = Properties.Resources.captain;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                player.SoundLocation = "shieldSound.wav";
            }
            else
            {
                label1.Text = "Hydra won!";
                pictureBox1.Image = Properties.Resources.hydra;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                player.SoundLocation = "hydraSound.wav";
            }
            player.Play();
        }
    }
}
