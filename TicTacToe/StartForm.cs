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
    public partial class StartForm : Form
    {
        bool side;
        Form gameForm = new GameForm();

        public StartForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setSide(true);
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setSide(false);
        }

        private void setSide(bool side)
        {
            GameForm.playerSide(side);
            gameForm.Show();
            this.Hide();
        }
    }
}
