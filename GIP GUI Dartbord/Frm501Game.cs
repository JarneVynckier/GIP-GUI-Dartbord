using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            //creating the two players with the basic constructor "player"
            playerOne = new Player();
            playerTwo = new Player();

            currentPlayer = playerOne;
            startPlayer = playerOne;
        }

        private void Frm501Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closing the form but still be able to open it again
            e.Cancel = true;
            this.Hide();
            ResetGame();
        }

        private void Click_NumPad(object sender, EventArgs e)
        {
            //If a number on the numpad is clicked then the number will show in the textbox
            //The return button is there for mistakes so you can remove numbers that are wrong
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
            }
            //the numbers in the textbox are saved in a variable to use in the game.
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Code for returning in the game, if you make a mistake then you can go back in the game
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
                UpdateLastScore();
            }
            UpdateScore();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //If enter is clicked, the scores will be updated
            if (score <= maxScorePerThrow && currentPlayer.RemainingScore >= score)
            {
                currentPlayer.Scores.Add(score);
                currentPlayer.ScoresIndex++;
                UpdateLastScore();
                CalculateAvrages();
                if (currentPlayer.RemainingScore == score)
                {
                    Winner();
                    BreakLeg();
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
            //the winner of the leg gets a point
            currentPlayer.Legs += 1;
        }

        public void SwitchCurrentPlayer()
        {
            //swithes the current player
            currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
        }

        public void SwitchStarterPlayer()
        {
            //switches the player who startes the leg
            startPlayer = startPlayer == playerOne ? playerTwo : playerOne;
        }

        public void UpdateLastScore()
        {
            //updates the information in the last score tab
            if (currentPlayer.ScoresIndex == -1)
            {
                currentPlayer.LastScore = 0;
            }
            else
            {
                currentPlayer.LastScore = currentPlayer.Scores.ElementAt(currentPlayer.ScoresIndex);
            }
        }

        public void BreakLeg()
        {
            //looks at the winners to see if the other player broke the oponents leg
            if (startPlayer != currentPlayer)
            {
                breakLeg.Add(true);
            }
            else
            {
                breakLeg.Add(false);
            }
            breakLegIndex++;
        }

        private void UpdateScore()
        {
            //Updates all the text tabs to show the score to the player
            lblPlayer1.Text = playerOne.RemainingScore.ToString();
            lblPlayer2.Text = playerTwo.RemainingScore.ToString();
            lblPlayer1Legs.Text = "legs: " + playerOne.Legs.ToString();
            lblPlayer2Legs.Text = "legs: " + playerTwo.Legs.ToString();
            lblDartsThrown1.Text = "Darts thrown: " + playerOne.DartsThrown.ToString();
            lblDartsThrown2.Text = "Darts thrown: " + playerTwo.DartsThrown.ToString();
            lblAvg1.Text = "3-dart avg.: " + playerOne.Avrage.ToString();
            lblAvg2.Text = "3-dart avg.: " + playerTwo.Avrage.ToString();
            lblLastScore1.Text = "Last score: " + playerOne.LastScore.ToString();
            lblLastScore2.Text = "Last score: " + playerTwo.LastScore.ToString();
        }

        private void ResetScore()
        {
            //Resets all the scores from the players to their begin values
            playerOne.RemainingScore = 501;
            playerTwo.RemainingScore = 501;
            playerOne.DartsThrown = 0;
            playerTwo.DartsThrown = 0;
            playerOne.LastScore = 0;
            playerTwo.LastScore = 0;
        }

        private void CalculateAvrages()
        {
            //this method is created to calculate the players average in each turn
            int totalScoredPoints = 0;
            if (currentPlayer.Scores.Count != 0)
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
            //if a player wins a leg then some of the info tabs need to be reseted 
            playerOne.DartsThrownInLeg.Add(playerOne.DartsThrown);
            playerTwo.DartsThrownInLeg.Add(playerTwo.DartsThrown);
            playerOne.DartsThrownInLegIndex++;
            playerTwo.DartsThrownInLegIndex++;
            playerOne.DartsThrown = 0;
            playerTwo.DartsThrown = 0;
        }

        private void EndOfLegDartsThrownPrevious()
        {
            //if the return button is clicked and you reach the beginning of the last leg then the score needs to be updated 
            //to the end of the last leg
            playerOne.DartsThrownInLegIndex--;
            playerTwo.DartsThrownInLegIndex--;
            playerOne.DartsThrown = playerOne.DartsThrownInLeg.ElementAt(playerOne.DartsThrownInLegIndex);
            playerOne.DartsThrownInLeg.RemoveAt(playerOne.DartsThrownInLegIndex);
            playerTwo.DartsThrown = playerTwo.DartsThrownInLeg.ElementAt(playerTwo.DartsThrownInLegIndex);
            playerTwo.DartsThrownInLeg.RemoveAt(playerOne.DartsThrownInLegIndex);
        }

        private void ResetDisplay()
        {
            //reset the display of the score to 0 again
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
            //clears the score to the beginning of the game
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
            //resets the game fully for another round
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
