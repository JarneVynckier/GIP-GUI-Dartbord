using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIP_GUI_Dartbord
{
    public partial class FrmMain : Form
    {
        bool AroundTheClock = false;
        int AroundTheClockCounter = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnRotate.Width = pnlRotateOff.Width / 2;
            btnOff.Width = pnlRotateOff.Width / 2;
        }

        Frm501Game frm501Game = new Frm501Game();
        private void btn501Game_Click(object sender, EventArgs e)
        {
            //opens the form to play the standart gamemode in darts "501"
            //sends the data to the microcontroller to light up all the displays
            char[] data = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't' };
            try
            {
                serial.Write(data, 0, data.Length);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            frm501Game.ShowDialog();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            //sends signal to microcontroller to rotate the dartboard
            char[] data = new char[] { 'u' };
            try
            {
                serial.Write(data, 0, data.Length);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Kan niet roteren.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnZoekSerial_Click(object sender, EventArgs e)
        {
            //Search for every port that is available in this device
            lstPoort.Items.Clear();
            //request every serial port on this device
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void lstPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select the port in the listbox to connect with the microcontroller
            if (lstPoort.SelectedIndex == -1) return;
            string poort = lstPoort.SelectedItem.ToString();
            if (poort == serial.PortName) return; //same port selected
            serial.Close();
            try
            {
                serial.PortName = poort;
                serial.Open();
                if (serial.IsOpen == true)
                {
                    //if there is a connection the label will be green and say that there is a connection
                    lblVerbinding.Text = "Er is verbinding!";
                    lblVerbinding.ForeColor = Color.Green;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn501Game_Paint(object sender, PaintEventArgs e)
        {
            //Creating a button as an oval.
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle newRectangle = btn501Game.ClientRectangle;
            newRectangle.Inflate(-1, -1);
            e.Graphics.DrawEllipse(Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            btn501Game.Region = new Region(buttonPath);
        }

        private void BtnLights_Click(object sender, EventArgs e)
        {
            //If the number on the numpad is clicked , the wright number 
            //is put in een switch and send to the microcontroler to light up the wright number
            char[] data = new char[] { '0' };
            Button btnNumber = sender as Button;
            switch (btnNumber.Text)
            {
                case "1":
                    data[0] = 'a';
                    break;
                case "2":
                    data[0] = 'b';
                    break;
                case "3":
                    data[0] = 'c';
                    break;
                case "4":
                    data[0] = 'd';
                    break;
                case "5":
                    data[0] = 'e';
                    break;
                case "6":
                    data[0] = 'f';
                    break;
                case "7":
                    data[0] = 'g';
                    break;
                case "8":
                    data[0] = 'h';
                    break;
                case "9":
                    data[0] = 'i';
                    break;
                case "10":
                    data[0] = 'j';
                    break;
                case "11":
                    data[0] = 'k';
                    break;
                case "12":
                    data[0] = 'l';
                    break;
                case "13":
                    data[0] = 'm';
                    break;
                case "14":
                    data[0] = 'n';
                    break;
                case "15":
                    data[0] = 'o';
                    break;
                case "16":
                    data[0] = 'p';
                    break;
                case "17":
                    data[0] = 'q';
                    break;
                case "18":
                    data[0] = 'r';
                    break;
                case "19":
                    data[0] = 's';
                    break;
                case "20":
                    data[0] = 't';
                    break;
            }
            try
            {
                serial.Write(data, 0, data.Length);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            DisplaysOff();
        }

        private void DisplaysOff()
        {
            //sends a signal to the microcontroller to shut down all the displays
            char[] data = new char[] { 'v' };
            try
            {
                serial.Write(data, 0, data.Length);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAtc_Click(object sender, EventArgs e)
        {
            //If the button is Clicked then the gamemode will start
            //If the gamemode is started, then are the other controls unavailable 
            //By clicking the button again, then will the gamemode be closed and the other controls available again
            AroundTheClock = AroundTheClock == true ? false : true;
            if (AroundTheClock == true)
            {
                btnHit.Enabled = true;
                btnAtc.FlatAppearance.BorderColor = Color.DarkOrange;
                tlpnlDisplays.Enabled = false;
                pnlRotateOff.Enabled = false;
                btn501Game.Enabled = false;
                AroundTheClockCounter = 1;
            }
            else
            {
                btnHit.Enabled = false;
                btnAtc.FlatAppearance.BorderColor = default;
                tlpnlDisplays.Enabled = true;
                pnlRotateOff.Enabled = true;
                btn501Game.Enabled = true;
                AroundTheClockCounter = 0;
            }
            lblATC.Text = AroundTheClockCounter.ToString();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //If hit is clicked then the player has hit the wriht target and can move on to the next
            //The switch sens the data to the microcontroller where the wright display will light up
            char[] data = new char[] { '0' };
            AroundTheClockCounter++;
            lblATC.Text = AroundTheClockCounter.ToString();
            switch (lblATC.Text)
            {
                case "1":
                    data[0] = 'a';
                    break;
                case "2":
                    data[0] = 'b';
                    break;
                case "3":
                    data[0] = 'c';
                    break;
                case "4":
                    data[0] = 'd';
                    break;
                case "5":
                    data[0] = 'e';
                    break;
                case "6":
                    data[0] = 'f';
                    break;
                case "7":
                    data[0] = 'g';
                    break;
                case "8":
                    data[0] = 'h';
                    break;
                case "9":
                    data[0] = 'i';
                    break;
                case "10":
                    data[0] = 'j';
                    break;
                case "11":
                    data[0] = 'k';
                    break;
                case "12":
                    data[0] = 'l';
                    break;
                case "13":
                    data[0] = 'm';
                    break;
                case "14":
                    data[0] = 'n';
                    break;
                case "15":
                    data[0] = 'o';
                    break;
                case "16":
                    data[0] = 'p';
                    break;
                case "17":
                    data[0] = 'q';
                    break;
                case "18":
                    data[0] = 'r';
                    break;
                case "19":
                    data[0] = 's';
                    break;
                case "20":
                    data[0] = 't';
                    break;
            }
            try
            {
                serial.Write(data, 0, data.Length);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
