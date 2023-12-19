using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    
    public partial class Gameplay : Form
    {
        string player1 = "";
        string player2 = "";
        int player1score = 0;
        int player2score = 0;
        int Round = 0;
        int turn = 0;
        Form1 Form1 = new Form1();

        void Wincheck()
        {
            if(Round == 10)
            {
                if(player1score == player2score)
                {
                    MessageBox.Show($"DRAW", "DRAW GAME!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Form1.Show();
                    this.Hide();
                }
                else if(player1score > player2score)
                {
                    MessageBox.Show($"Player 1 Wins! = {player1score} ", "Player 1 Wins");
                    Form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Player 2 Wins! = {player2score} ", "Player 2 Wins");
                    Form1.Show();
                    this.Hide();
                }
            }
            else
            {
                if(player1 == player2)
                {
                    MessageBox.Show($"Player 1 = {player1} VS Player 2 = {player2}", "DRAW!\nPlayer 1 Wins!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P1s.Text = player1score.ToString();
                    P2s.Text = player2score.ToString();
                    RoundNumber.Text = Round.ToString();
                }
                else if (player1 == "ROCK" & player2 == "SCISSORS")
                {
                    player1score++;
                    MessageBox.Show($"Player 1 = {player1} VS Player 2 = {player2}", "Player 1 Wins!\nPlayer 1 Wins!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P1s.Text = player1score.ToString();
                    P2s.Text = player2score.ToString();
                    RoundNumber.Text = Round.ToString();
                }
                else if (player1 == "PAPER" & player2 == "ROCK")
                {
                    player1score++;
                    MessageBox.Show($"Player 1 = {player1} VS Player 2 = {player2}", "Player 1 Wins!\nPlayer 1 Wins!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P1s.Text = player1score.ToString();
                    P2s.Text = player2score.ToString();
                    RoundNumber.Text = Round.ToString();

                }
                else if (player1 == "SCISSORS" & player2 == "PAPPER")
                {
                    player1score++;
                    MessageBox.Show($"Player 1 = {player1} VS Player 2 = {player2}", "Player 1 Wins!\nPlayer 1 Wins!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P1s.Text = player1score.ToString();
                    P2s.Text = player2score.ToString();
                    RoundNumber.Text = Round.ToString();
                }
                else
                {
                    player2score++;
                    MessageBox.Show($"Player 1 = {player1} VS Player 2 = {player2}\nPlayer 2 Wins!", "Player 2 Wins!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    P1s.Text = player1score.ToString();
                    P2s.Text = player2score.ToString();
                    RoundNumber.Text = Round.ToString();
                }
            }
            
        }

        public Gameplay()
        {
            InitializeComponent();
        }

        private void Gameplay_Load(object sender, EventArgs e)
        {
            player1 = "";
            player2 = "";
            player1score = 0;
            player2score = 0;
            PlayerTurn.Text = "PLAYER 1";
            P1s.Text = player1score.ToString(); 
            P2s.Text = player2score.ToString();
            RoundNumber.Text = Round.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Papper = "PAPPER";
            if(turn == 0)
            {
                player1 = Papper;
                turn++;
                PlayerTurn.Text = "PLAYER 2";

            }
            else
            {
                player2 = Papper;
                turn--;
                PlayerTurn.Text = "PLAYER 1";
                Wincheck();
                Round++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Scissor = "SCISSORS";
            if (turn == 0)
            {
                player1 = Scissor;
                turn++;
                PlayerTurn.Text = "PLAYER 2";
            }
            else
            {
                player2 = Scissor;
                turn--;
                PlayerTurn.Text = "PLAYER 1";
                Wincheck();
                Round++;
            }
        }

        private void Rockbtn_Click(object sender, EventArgs e)
        {
            string Rock = "ROCK";
            if (turn == 0)
            {
                player1 = Rock;
                turn++;
                PlayerTurn.Text = "PLAYER 2";
            }
            else
            {
                player2 = Rock;
                turn--;
                PlayerTurn.Text = "PLAYER 2";
                Wincheck();
                Round++;
            }
        }
    }
}
