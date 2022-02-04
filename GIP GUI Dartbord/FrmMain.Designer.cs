
namespace GIP_GUI_Dartbord
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn501Game = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.pnlPorts = new System.Windows.Forms.Panel();
            this.lstPoort = new System.Windows.Forms.ListBox();
            this.btnZoekSerial = new System.Windows.Forms.Button();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.lblVerbinding = new System.Windows.Forms.Label();
            this.pnlPorts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn501Game
            // 
            this.btn501Game.Location = new System.Drawing.Point(607, 11);
            this.btn501Game.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn501Game.Name = "btn501Game";
            this.btn501Game.Size = new System.Drawing.Size(142, 85);
            this.btn501Game.TabIndex = 0;
            this.btn501Game.Text = "501";
            this.btn501Game.UseVisualStyleBackColor = true;
            this.btn501Game.Click += new System.EventHandler(this.btn501Game_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(44, 423);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(248, 90);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = " Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // pnlPorts
            // 
            this.pnlPorts.Controls.Add(this.lblVerbinding);
            this.pnlPorts.Controls.Add(this.lstPoort);
            this.pnlPorts.Controls.Add(this.btnZoekSerial);
            this.pnlPorts.Location = new System.Drawing.Point(33, 84);
            this.pnlPorts.Name = "pnlPorts";
            this.pnlPorts.Size = new System.Drawing.Size(162, 308);
            this.pnlPorts.TabIndex = 2;
            // 
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.Location = new System.Drawing.Point(0, 41);
            this.lstPoort.Margin = new System.Windows.Forms.Padding(2);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(162, 267);
            this.lstPoort.TabIndex = 4;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // btnZoekSerial
            // 
            this.btnZoekSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoekSerial.Location = new System.Drawing.Point(0, 0);
            this.btnZoekSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoekSerial.MinimumSize = new System.Drawing.Size(0, 41);
            this.btnZoekSerial.Name = "btnZoekSerial";
            this.btnZoekSerial.Size = new System.Drawing.Size(162, 41);
            this.btnZoekSerial.TabIndex = 3;
            this.btnZoekSerial.Text = "Zoek alle seriële poorten";
            this.btnZoekSerial.UseVisualStyleBackColor = true;
            this.btnZoekSerial.Click += new System.EventHandler(this.btnZoekSerial_Click);
            // 
            // lblVerbinding
            // 
            this.lblVerbinding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVerbinding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbinding.ForeColor = System.Drawing.Color.Red;
            this.lblVerbinding.Location = new System.Drawing.Point(0, 278);
            this.lblVerbinding.Name = "lblVerbinding";
            this.lblVerbinding.Size = new System.Drawing.Size(162, 30);
            this.lblVerbinding.TabIndex = 5;
            this.lblVerbinding.Text = "Er is geen verbinding!";
            this.lblVerbinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(760, 588);
            this.Controls.Add(this.pnlPorts);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btn501Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DartsMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlPorts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn501Game;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Panel pnlPorts;
        private System.Windows.Forms.ListBox lstPoort;
        private System.Windows.Forms.Button btnZoekSerial;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Label lblVerbinding;
    }
}

