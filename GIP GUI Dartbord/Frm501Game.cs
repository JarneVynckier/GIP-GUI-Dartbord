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
        int count = 0;
        private void Click_NumPad(object sender, EventArgs e)
        {
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
            txtScore.ForeColor = Color.Black;
            txtScore.Text = display[0] + display[1] + display[2];
        }
    
    }
}
