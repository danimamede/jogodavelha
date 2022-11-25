using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frmTwoPlayers : Form
    {
        Button btn = new Button();
        // true = X e false = O
        bool turno = true;

        public frmTwoPlayers()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            btn = (Button)sender;

            if (btn.Text == "")
            {

                if (turno)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Crimson;
                    lblTurno.Text = "O";
                    lblTurno.ForeColor = Color.RoyalBlue;
                    turno = !turno;
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.DeepSkyBlue;
                    lblTurno.Text = "X";
                    lblTurno.ForeColor = Color.Firebrick;
                    turno = !turno;
                }

                CheckWinner();
            }
        }

        public void CheckWinner()
        {
            if (CheckHorizontal() || CheckVertical() || CheckDiagonal())
            {
                HasWinner();
            }
            else
            {
                NoWinner();
            }
        }

        public bool CheckHorizontal()
        {
            if (btnA0.Text != "" && btnA0.Text == btnB0.Text && btnB0.Text == btnC0.Text ||
                btnA1.Text != "" && btnA1.Text == btnB1.Text && btnB1.Text == btnC1.Text ||
                btnA2.Text != "" && btnA2.Text == btnB2.Text && btnB2.Text == btnC2.Text)
            {
                return true;
            }
            return false;
        }

        public bool CheckVertical()
        {
            if (btnA0.Text != "" && btnA0.Text == btnA1.Text && btnA1.Text == btnA2.Text ||
                btnB0.Text != "" && btnB0.Text == btnB1.Text && btnB1.Text == btnB2.Text ||
                btnC0.Text != "" && btnC0.Text == btnC1.Text && btnC1.Text == btnC2.Text)
            {
                return true;
            }
            return false;
        }

        public bool CheckDiagonal()
        {
            if (btnA0.Text != "" && btnA0.Text == btnB1.Text && btnB1.Text == btnC2.Text ||
                btnC0.Text != "" && btnC0.Text == btnB1.Text && btnB1.Text == btnA2.Text)
            {
                return true;
            }
            return false;
        }

        public void HasWinner()
        {
            MessageBox.Show($"VITÓRIA!\nParabéns jogador {btn.Text}!");
            ResetGame();
        }

        public void NoWinner()
        {
            if (btnA0.Text != "" && btnA1.Text != "" && btnA2.Text != "" &&
                btnB0.Text != "" && btnB1.Text != "" && btnB2.Text != "" &&
                btnC0.Text != "" && btnC1.Text != "" && btnC2.Text != "")
            {
                MessageBox.Show($"VELHA!\nO jogo empatou.");
                ResetGame();
            }
        }

        public void ResetGame()
        {
            turno = true;
            lblTurno.Text = "X";
            lblTurno.ForeColor = Color.Firebrick;
            btnA0.Text = "";
            btnA1.Text = "";
            btnA2.Text = "";
            btnB0.Text = "";
            btnB1.Text = "";
            btnB2.Text = "";
            btnC0.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
