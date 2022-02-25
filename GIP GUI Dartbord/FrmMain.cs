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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        Frm501Game frm501Game = new Frm501Game();
        private void btn501Game_Click(object sender, EventArgs e)
        {
            frm501Game.ShowDialog();
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            char[] data = new char[] { '1' };
            try
            {
                serial.Write(data, 0,data.Length);               
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
    }
}
