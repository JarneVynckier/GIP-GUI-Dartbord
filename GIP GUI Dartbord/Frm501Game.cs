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
        readonly string[] display = { null, null, null };
        int score;
        int displayIndex = 0;
        readonly List<int> loserScores = new List<int>();
        readonly List<bool> breakLeg = new List<bool>();
        int breakLegIndex = -1;
        int loserScoresIndex = 0;
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
                SwitchCurrentPlayer();
            }

            if (currentPlayer.ScoresIndex != -1)
            {
                if (playerOne.RemainingScore == 501 && playerTwo.RemainingScore == 501)
                {
                    loserScoresIndex--;
                    currentPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    SwitchStarterPlayer();
                    if (breakLeg.ElementAt(breakLegIndex) == true)
                    {
                        currentPlayer.RemainingScore = loserScores.ElementAt(loserScoresIndex);
                        SwitchCurrentPlayer();
                        currentPlayer.RemainingScore = currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);

                    }
                    else
                    {
                        currentPlayer.RemainingScore = currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);
                        SwitchCurrentPlayer();
                        currentPlayer.RemainingScore = loserScores.ElementAt(loserScoresIndex);
                        SwitchCurrentPlayer();

                    }
                    loserScores.RemoveAt(loserScoresIndex);
                    breakLeg.RemoveAt(breakLegIndex);
                    breakLegIndex--;
                    currentPlayer.Legs -= 1;
                    EndOfLegDartsThrownPrevious();
                }
                else
                {
                    currentPlayer.DartsThrown -= 3;
                    currentPlayer.RemainingScore += currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);
                }
                currentPlayer.Scores.RemoveAt(currentPlayer.ScoresIndex);
                currentPlayer.ScoresIndex--;
                CalculateAvrages();
            }
            UpdateScore();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (score <= maxScorePerThrow && currentPlayer.RemainingScore >= score)
            {
                currentPlayer.Scores.Add(score);
                currentPlayer.ScoresIndex++;
                CalculateAvrages();
                if (currentPlayer.RemainingScore == score)
                {
                    Winner();
                    if (startPlayer != currentPlayer)
                    {
                        breakLeg.Add(true);
                    }
                    else
                    {
                        breakLeg.Add(false);
                    }
                    breakLegIndex++;
                    currentPlayer = startPlayer == playerOne ? playerTwo : playerOne;
                    SwitchStarterPlayer();
                    if (breakLeg.ElementAt(breakLegIndex) == true)
                    {
                        SwitchCurrentPlayer();
                        loserScores.Add(currentPlayer.RemainingScore);
                        SwitchCurrentPlayer();
                    }
                    else
                    {
                        loserScores.Add(currentPlayer.RemainingScore);
                    }
                    loserScoresIndex++;
                    EndOfLegDartsThrownEnter();
                    ResetScore();
                }
                else
                {
                    currentPlayer.RemainingScore -= score;
                    currentPlayer.DartsThrown += 3;
                    SwitchCurrentPlayer();

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

        public void SwitchCurrentPlayer()
        {
            currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
        }

        public void SwitchStarterPlayer()
        {
            startPlayer = startPlayer == playerOne ? playerTwo : playerOne;
        }

        private void UpdateScore()
        {
            lblPlayer1.Text = playerOne.RemainingScore.ToString();
            lblPlayer2.Text = playerTwo.RemainingScore.ToString();
            lblPlayer1Legs.Text = "legs: " + playerOne.Legs.ToString();
            lblPlayer2Legs.Text = "legs: " + playerTwo.Legs.ToString();
            lblDartsThrown1.Text = "Darts thrown: " + playerOne.DartsThrown.ToString();
            lblDartsThrown2.Text = "Darts thrown: " + playerTwo.DartsThrown.ToString();
            lblAvg1.Text = "3-dart avg.: " + playerOne.Avrage.ToString();
            lblAvg2.Text = "3-dart avg.: " + playerTwo.Avrage.ToString();
        }

        private void ResetScore()
        {
            playerOne.RemainingScore = 501;
            playerTwo.RemainingScore = 501;
            playerOne.DartsThrown = 0;
            playerTwo.DartsThrown = 0;
            playerOne.LastScore = 0;
            playerTwo.LastScore = 0;
        }

        private void CalculateAvrages()
        {
            int totalScoredPoints = 0;
            if(currentPlayer.Scores.Count!=0) 
            {
                for (int i = 0; i < currentPlayer.Scores.Count; i++)
                {
                    totalScoredPoints += currentPlayer.Scores.ElementAt(i);
                }
                currentPlayer.Avrage = Math.Round((double)totalScoredPoints / currentPlayer.Scores.Count, 2);
            }
            else
            {
                currentPlayer.Avrage = 0;
            }
        }

        private void EndOfLegDartsThrownEnter()
        {
            playerOne.DartsThrownInLeg.Add(playerOne.DartsThrown);
            playerTwo.DartsThrownInLeg.Add(playerTwo.DartsThrown);
            playerOne.DartsThrownInLegIndex++;
            playerTwo.DartsThrownInLegIndex++;
            playerOne.DartsThrown = 0;
            playerTwo.DartsThrown = 0;
        }

        private void EndOfLegDartsThrownPrevious()
        {
            playerOne.DartsThrownInLegIndex--;
            playerTwo.DartsThrownInLegIndex--;
            playerOne.DartsThrown = playerOne.DartsThrownInLeg.ElementAt(playerOne.DartsThrownInLegIndex);
            playerOne.DartsThrownInLeg.RemoveAt(playerOne.DartsThrownInLegIndex);
            playerTwo.DartsThrown = playerTwo.DartsThrownInLeg.ElementAt(playerTwo.DartsThrownInLegIndex);
            playerTwo.DartsThrownInLeg.RemoveAt(playerOne.DartsThrownInLegIndex);
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
