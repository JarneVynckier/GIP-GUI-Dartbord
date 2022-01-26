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
        public Frm501Game()
        {
            InitializeComponent();
        }

        private void Frm501Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        string[] display = { null, null, null };
        int score;
        int count = 0;
        private void Click_NumPad(object sender, EventArgs e)
        {
            txtScore.BackColor = Color.White;
            Button btnNumber = sender as Button;
            if (count < 4&&btnNumber.Text!= "") count++;
            if (btnNumber != null)
            {
                switch (btnNumber.Text)
                {
                    case "0":
                        
                        if (count == 1) display[0] = "0";
                        if (count == 2) display[1] = "0";
                        if (count == 3) display[2] = "0";
                        break;
                    case "1":
                        
                        if (count == 1) display[0] = "1";
                        if (count == 2) display[1] = "1";
                        if (count == 3) display[2] = "1";
                        break;
                    case "2":
                        
                        if (count == 1) display[0] = "2";
                        if (count == 2) display[1] = "2";
                        if (count == 3) display[2] = "2";
                        break;
                    case "3":
                        
                        if (count == 1) display[0] = "3";
                        if (count == 2) display[1] = "3";
                        if (count == 3) display[2] = "3";
                        break;
                    case "4":
                        
                        if (count == 1) display[0] = "4";
                        if (count == 2) display[1] = "4";
                        if (count == 3) display[2] = "4";
                        break;
                    case "5":
                        
                        if (count == 1) display[0] = "5";
                        if (count == 2) display[1] = "5";
                        if (count == 3) display[2] = "5";
                        break;
                    case "6":
                        
                        if (count == 1) display[0] = "6";
                        if (count == 2) display[1] = "6";
                        if (count == 3) display[2] = "6";
                        break;
                    case "7":
                        
                        if (count == 1) display[0] = "7";
                        if (count == 2) display[1] = "7";
                        if (count == 3) display[2] = "7";
                        break;
                    case "8":
                        
                        if (count == 1) display[0] = "8";
                        if (count == 2) display[1] = "8";
                        if (count == 3) display[2] = "8";
                        break;
                    case "9":
                        
                        if (count == 1) display[0] = "9";
                        if (count == 2) display[1] = "9";
                        if (count == 3) display[2] = "9";
                        break;
                    case "":
                        if (count == 4) count--;
                        if (count == 1) display[0] = null;
                        if (count == 2) display[1] = null;
                        if (count == 3) display[2] = null;
                        if(count>0)count--;
                        break;
                    default:
                        break;
                }//display of numbers
            }
            string Score = display[0] + display[1] + display[2];
            txtScore.ForeColor = Color.Black;
            txtScore.Text = Score;
            if(Score=="")
            {
                score = 0;
            }
            else
            {
                score = Int32.Parse(Score);
            }          
        }
        int player = 1;
        int starterPlayer = 1;
        int legsplayer1=0, legsplayer2=0;
        int player1_score = 501, player2_score = 501;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(score<181)
            {
                if (player == 1)
                {
                    if(score==player1_score)
                    {
                        player1_score = 501;
                        player2_score = 501;
                        lblPlayer1Legs.Text = "legs: " + legsplayer1++;
                        if(starterPlayer==1)
                        {
                            starterPlayer++;
                        }
                        else
                        {
                            starterPlayer--;
                        }
                    }
                    else
                    {
                        player1_score -= score;
                        player++;  
                    }
                    lblLastScore1.Text = "Last score: " + score.ToString();
                }
                else if (player == 2)
                {
                    if (score == player2_score)
                    {
                        player1_score = 501;
                        player2_score = 501;
                        lblPlayer2Legs.Text = "legs: " + legsplayer2++;
                        if (starterPlayer == 1)
                        {
                            starterPlayer++;
                        }
                        else
                        {
                            starterPlayer--;
                        }
                    }
                    else
                    {
                        player2_score -= score;
                        player--;
                    }
                    lblLastScore2.Text = "Last score: " + score.ToString();
                }
                lblPlayer1.Text = player1_score.ToString();
                lblPlayer2.Text = player2_score.ToString();
            }
            else
            {
                txtScore.BackColor = Color.Red;
                txtScore.Text = "";               
            }
            display[0] = null; display[1] = null; display[2] = null; count = 0;
        }
    }
}
