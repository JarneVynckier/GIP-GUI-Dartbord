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
        int loserScore = 0;
        const int maxScorePerThrow = 180;
        bool breakLeg = false;

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

                }

            }//display of numbers

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

        private void Frm501Game_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (playerOne.ScoresIndex >= 0 || playerTwo.ScoresIndex >= 0)
            {
                currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
            }

            if (currentPlayer.ScoresIndex != -1)
            {
                if (playerOne.RemainingScore == 501 && playerTwo.RemainingScore == 501)
                {
                    currentPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    startPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    if (breakLeg == true)
                    {
                        currentPlayer.RemainingScore = loserScore;
                        currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                        currentPlayer.RemainingScore = currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);
                    }
                    else
                    {
                        currentPlayer.RemainingScore = currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);
                        currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                        currentPlayer.RemainingScore = loserScore;
                        currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                    }
                    currentPlayer.Legs -= 1;
                }
                else
                {
                    //currentPlayer.DartsThrown -= 3;
                    currentPlayer.RemainingScore += currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);
                }
                currentPlayer.Scores.RemoveAt(currentPlayer.ScoresIndex);
                currentPlayer.ScoresIndex--;
            }
            UpdateScore();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (score <= maxScorePerThrow && currentPlayer.RemainingScore >= score)
            {
                currentPlayer.Scores.Add(score);
                currentPlayer.ScoresIndex++;
                if (currentPlayer.RemainingScore == score)
                {
                    Winner();
                    if (startPlayer != currentPlayer)
                    {
                        breakLeg = true;
                    }
                    currentPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    startPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    if (breakLeg == true)
                    {
                        currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                        loserScore = currentPlayer.RemainingScore;
                        currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                    }
                    else
                    {
                        loserScore = currentPlayer.RemainingScore;
                    }
                    ResetScore();
                }
                else
                {
                    currentPlayer.RemainingScore -= score;
                    //currentPlayer.DartsThrown += 3;
                    currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                    
                }
            }
            else
            {
                txtScore.BackColor = Color.Red;
                txtScore.Text = "";
            }

            UpdateScore();
            ResetDisplay();
        }

        public void Winner()
        {
            currentPlayer.Legs += 1;
        }

        private void UpdateScore()
        {
            lblPlayer1.Text = playerOne.RemainingScore.ToString();
            lblPlayer2.Text = playerTwo.RemainingScore.ToString();
            lblPlayer1Legs.Text = "legs: " + playerOne.Legs.ToString();
            lblPlayer2Legs.Text = "legs: " + playerTwo.Legs.ToString();
            lblDartsThrown1.Text = "Darts thrown: " + playerOne.DartsThrown.ToString();
            lblDartsThrown2.Text = "Darts thrown: " + playerTwo.DartsThrown.ToString();
        }

        private void ResetScore()
        {
            playerOne.RemainingScore = 501;
            playerTwo.RemainingScore = 501;
            playerOne.DartsThrown = 0;
            playerTwo.DartsThrown = 0;
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

        private void ResetScores()
        {
            playerOne.Scores.Clear();
            playerTwo.Scores.Clear();
            playerOne.RemainingScore = 501;
            playerTwo.RemainingScore = 501;
            playerOne.ScoresIndex = -1;
            playerTwo.ScoresIndex = -1;
            playerOne.Legs = 0;
            playerTwo.Legs = 0;
        }

        private void ResetGame()
        {
            ResetDisplay();
            ResetScores();

            score = 0;

            lblPlayer1.Text = "501";
            lblPlayer1Legs.Text = "legs: 0";
            lblLastScore1.Text = "Last score: -";
            lblDartsThrown1.Text = "Darts thrown: 0";
            lblAvg1.Text = "3-dart avg.: 0.00";


            lblPlayer2.Text = "501";
            lblPlayer2Legs.Text = "legs: 0";
            lblLastScore2.Text = "Last score: -";
            lblDartsThrown2.Text = "Darts thrown: 0";
            lblAvg2.Text = "3-dart avg.: 0.00";


        }
    }
}
