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
    public partial class frmPvC : Form
    {
        public delegate void delPassData1(TextBox text);
        public frmPlay PlayGame;
        public frmPvC()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbPlayerName.Text == "")
            {
                errNull.SetError(txbPlayerName, "You have not entered a player name yet!!");
            }
            else
            {
                delPassData1 player1 = new delPassData1(PlayGame.funData1);
                player1(this.txbPlayerName);

                this.Close();
                PlayGame.Show();
                txbPlayerName.Text = "";
            }
        }

        private void txbPlayerName_TextChanged(object sender, EventArgs e)
        {
            errNull.SetError(txbPlayerName, "");
        }

        private void PvC_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            PlayGame.Show();
        }

        
    }
}
