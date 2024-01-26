using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroChessProject1
{
    public partial class frmPvP : Form
    {
        public delegate void delPassData1(TextBox text);

        public delegate void delPassData2(TextBox text);

        public frmPlay PlayGame;


        public frmPvP()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbPlayerName1.Text == "")
            {
                errNull.SetError(txbPlayerName1, "You have not entered a player name yet!!");
            }
            else if (txbPlayerName2.Text == "")
            {
                errNull.SetError(txbPlayerName2, "You have not entered a player name yet!!");
            }
            else
            {
                delPassData1 player1 = new delPassData1(PlayGame.funData1);
                player1(this.txbPlayerName1);

                delPassData1 player2 = new delPassData1(PlayGame.funData2);
                player2(this.txbPlayerName2);

                this.Close();
                PlayGame.Show();
                txbPlayerName1.Text = "";
                txbPlayerName2.Text = "";
            }

        }

        private void txbPlayerName1_TextChanged(object sender, EventArgs e)
        {
            errNull.SetError(txbPlayerName1, "");
        }

        private void txbPlayerName2_TextChanged(object sender, EventArgs e)
        {
            errNull.SetError(txbPlayerName2, "");
        }

        private void PvP_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            PlayGame.Show();
        }

      
    }
}
