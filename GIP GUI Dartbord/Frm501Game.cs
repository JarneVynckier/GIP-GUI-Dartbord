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
    }
}
