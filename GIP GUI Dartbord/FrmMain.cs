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
            lstPoort.Items.Clear();
            //alle seriële poorten voor dit toestel opvragen
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void lstPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPoort.SelectedIndex == -1) return;
            string poort = lstPoort.SelectedItem.ToString();
            if (poort == serial.PortName) return; //zelfde poort geselecteerd
            serial.Close();
            try
            {
                serial.PortName = poort;
                serial.Open();
                if (serial.IsOpen == true)
                {
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
    }
}
