using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIP_GUI_Dartbord
{
    public partial class Frm501Game : Form
    {
        string[] display = { null, null, null };
        int score;
        int displayIndex = 0;
        const int maxScorePerThrow = 180;

        private readonly Player playerOne;
        private readonly Player playerTwo;
        private Player currentPlayer;
        private Player startPlayer;

        public Frm501Game()
        {
            InitializeComponent();
            playerOne = new Player();
            playerTwo = new Player();
            currentPlayer = playerOne;
            startPlayer = playerOne;

        }

        private void Frm501Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            ResetGame();

        }

        private void Click_NumPad(object sender, EventArgs e)
        {
            txtScore.BackColor = Color.White;
            Button btnNumber = sender as Button;
            if (displayIndex < 4 && btnNumber.Text != "") displayIndex++;
            if (btnNumber != null)
            {
                switch (btnNumber.Text)
                {
                    default:
                        if (displayIndex >= 1 && displayIndex <= 3)
                        {
                            display[displayIndex - 1] = btnNumber.Text;
                        }
                        break;

                    case "":
                        if (displayIndex == 4) displayIndex--;

                        if (displayIndex >= 1 && displayIndex <= 3)
                        {
                            display[displayIndex - 1] = null;
                        }

                        if (displayIndex > 0) displayIndex--;
                        break;

                }//display of numbers
            }

            string Score = display[0] + display[1] + display[2];
            txtScore.ForeColor = Color.Black;
            txtScore.Text = Score;
            if (Score == "")
            {
                score = 0;
            }
            else
            {
                score = Int32.Parse(Score);
            }
        }

        int player = 1; int starterplayer = 1; int legwinner = 0; bool Break = false;
        int legsplayer1 = 0, legsplayer2 = 0;
        int player1_score = 501, player2_score = 501;
        List<int> player1_scores = new List<int>();
        List<int> player2_scores = new List<int>();
        List<int> player1_lastDarts = new List<int>();
        List<int> player2_lastDarts = new List<int>();
        int i1 = 0; int i2 = 0;

        private void Frm501Game_Load(object sender, EventArgs e)
        {
            player1_scores.Add(501);
            player2_scores.Add(501);
            player1_lastDarts.Add(0);
            player2_lastDarts.Add(0);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (player == 2)
            {
                if (i1 != 0)
                {
                    if (player1_score == 501 && legwinner == 1)
                    {

                        i1--; i2--;
                        player1_score = player1_scores.ElementAt(i1);
                        player2_score = player2_scores.ElementAt(i2);
                        if (Break == true) i1--; Break = false;
                        if (starterplayer == 1) starterplayer = 2; else starterplayer = 1;
                        player = 1;
                        legsplayer1--;
                        lblPlayer1Legs.Text = "legs: " + legsplayer1.ToString();
                    }
                    else
                    {
                        i1--;
                        player1_score = player1_scores.ElementAt(i1);
                        player--;
                    }
                }
            }
            else
            {
                if (i2 != 0)
                {
                    if (player2_score == 501 && legwinner == 2)
                    {

                        i2--; i1--;
                        player1_score = player1_scores.ElementAt(i1);
                        player2_score = player2_scores.ElementAt(i2);
                        if (Break == true) i2--; Break = false;
                        if (starterplayer == 1) starterplayer = 2; else starterplayer = 1;
                        player = 2;
                        legsplayer2--;
                        lblPlayer2Legs.Text = "legs: " + legsplayer2.ToString();
                    }
                    else
                    {
                        i2--;
                        player2_score = player2_scores.ElementAt(i2);
                        player++;
                    }
                }
            }
            lblPlayer1.Text = player1_score.ToString();
            lblPlayer2.Text = player2_score.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (score <= maxScorePerThrow)
            {
                if (currentPlayer.RemainingScore == score)
                {
                    ResetScore();
                    currentPlayer.Legs += 1;
                    currentPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    startPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                }
                else
                {
                    currentPlayer.RemainingScore -= score;

                    currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                }



                //    if (player == 1)
                //    {
                //        if (score == player1_score)
                //        {
                //            player1_score = 501;
                //            player1_scores.Add(player1_score);
                //            i1++;
                //            player2_score = 501;
                //            player2_scores.Add(player2_score);
                //            i2++;
                //            legwinner = 1;
                //            legsplayer1++;
                //            lblPlayer1Legs.Text = "legs: " + legsplayer1.ToString();
                //            if (starterplayer == 1)
                //            {
                //                player = 2;
                //                starterplayer = 2;
                //            }
                //            else
                //            {
                //                player = 1;
                //                starterplayer = 1;
                //                Break = true;
                //            }

                //        }
                //        else
                //        {
                //            player1_score -= score;
                //            player++;
                //            player1_scores.Add(player1_score);
                //            i1++;
                //        }
                //        lblLastScore1.Text = "Last score: " + score.ToString();
                //        player1_lastDarts.Add(score);


                //    }
                //    else
                //    {
                //        if (score == player2_score)
                //        {
                //            player1_score = 501;
                //            player1_scores.Add(player1_score);
                //            i1++;
                //            player2_score = 501;
                //            player2_scores.Add(player2_score);
                //            i2++;
                //            legwinner = 2;
                //            legsplayer2++;
                //            lblPlayer2Legs.Text = "legs: " + legsplayer2.ToString();
                //            if (starterplayer == 1)
                //            {
                //                player = 2;
                //                starterplayer = 2;
                //                Break = true;
                //            }
                //            else
                //            {
                //                player = 1;
                //                starterplayer = 1;
                //            }
                //        }
                //        else
                //        {
                //            player2_score -= score;
                //            player--;
                //            player2_scores.Add(player2_score);
                //            i2++;
                //        }
                //        lblLastScore2.Text = "Last score: " + score.ToString();
                //        player2_lastDarts.Add(score);
                //    }
                //    lblPlayer1.Text = player1_score.ToString();
                //    lblPlayer2.Text = player2_score.ToString();
                //    txtScore.Text = "Score"; txtScore.ForeColor = Color.Gray;
                //    score = 0;
            }
            else
            {
                txtScore.BackColor = Color.Red;
                txtScore.Text = "";
            }
            UpdateScore();
            ResetDisplay();
        }
        public void LegWinner()
        {

        }
        private void UpdateScore()
        {
            lblPlayer1.Text = playerOne.RemainingScore.ToString();
            lblPlayer2.Text = playerTwo.RemainingScore.ToString();
            lblPlayer1Legs.Text = "legs: " + playerOne.Legs.ToString();
            lblPlayer2Legs.Text = "legs: " + playerTwo.Legs.ToString();

        }
        private void ResetScore()
        {
            playerOne.RemainingScore = 501;
            playerTwo.RemainingScore = 501;
        }
        private void ResetDisplay()
        {
            display[0] = null;
            display[1] = null;
            display[2] = null;
            displayIndex = 0;
            score = 0;
            txtScore.Text = "Score"; 
            txtScore.ForeColor = Color.Gray;
        }
        private void ResetGame()
        {
            ResetDisplay();

            score = 0;
            player = 1;
            starterplayer = 1;
            legwinner = 0;

            i1 = 0;
            legsplayer1 = 0;
            player1_score = 501;
            player1_scores.Clear();
            player1_lastDarts.Clear();
            lblPlayer1.Text = "501";
            lblPlayer1Legs.Text = "legs: 0";
            lblLastScore1.Text = "Last score: -";
            lblDartsThrown1.Text = "Darts thrown: 0";
            lblAvg1.Text = "3-dart avg.: 0.00";

            i2 = 0;
            legsplayer2 = 0;
            player2_score = 501;
            player2_scores.Clear();
            player2_lastDarts.Clear();
            lblPlayer2.Text = "501";
            lblPlayer2Legs.Text = "legs: 0";
            lblLastScore2.Text = "Last score: -";
            lblDartsThrown2.Text = "Darts thrown: 0";
            lblAvg2.Text = "3-dart avg.: 0.00";

            
        }

    }
}
