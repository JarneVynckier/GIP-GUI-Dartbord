
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
            this.lblVerbinding = new System.Windows.Forms.Label();
            this.lstPoort = new System.Windows.Forms.ListBox();
            this.btnZoekSerial = new System.Windows.Forms.Button();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.tlpnlDisplays = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblGamemodes = new System.Windows.Forms.Label();
            this.pnlPorts.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn501Game
            // 
            this.btn501Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn501Game.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn501Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn501Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn501Game.Location = new System.Drawing.Point(41, 56);
            this.btn501Game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn501Game.Name = "btn501Game";
            this.btn501Game.Size = new System.Drawing.Size(189, 105);
            this.btn501Game.TabIndex = 0;
            this.btn501Game.Text = "501";
            this.btn501Game.UseVisualStyleBackColor = false;
            this.btn501Game.Click += new System.EventHandler(this.btn501Game_Click);
            this.btn501Game.Paint += new System.Windows.Forms.PaintEventHandler(this.btn501Game_Paint);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(287, 536);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(356, 116);
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
            this.pnlPorts.Location = new System.Drawing.Point(4, 56);
            this.pnlPorts.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPorts.Name = "pnlPorts";
            this.pnlPorts.Size = new System.Drawing.Size(216, 379);
            this.pnlPorts.TabIndex = 2;
            // 
            // lblVerbinding
            // 
            this.lblVerbinding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVerbinding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbinding.ForeColor = System.Drawing.Color.Red;
            this.lblVerbinding.Location = new System.Drawing.Point(0, 342);
            this.lblVerbinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerbinding.Name = "lblVerbinding";
            this.lblVerbinding.Size = new System.Drawing.Size(216, 37);
            this.lblVerbinding.TabIndex = 5;
            this.lblVerbinding.Text = "Er is geen verbinding!";
            this.lblVerbinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.ItemHeight = 16;
            this.lstPoort.Location = new System.Drawing.Point(0, 50);
            this.lstPoort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(216, 329);
            this.lstPoort.TabIndex = 4;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // btnZoekSerial
            // 
            this.btnZoekSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoekSerial.Location = new System.Drawing.Point(0, 0);
            this.btnZoekSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoekSerial.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnZoekSerial.Name = "btnZoekSerial";
            this.btnZoekSerial.Size = new System.Drawing.Size(216, 50);
            this.btnZoekSerial.TabIndex = 3;
            this.btnZoekSerial.Text = "Zoek alle seriële poorten";
            this.btnZoekSerial.UseVisualStyleBackColor = true;
            this.btnZoekSerial.Click += new System.EventHandler(this.btnZoekSerial_Click);
            // 
            // tlpnlDisplays
            // 
            this.tlpnlDisplays.ColumnCount = 4;
            this.tlpnlDisplays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlDisplays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlDisplays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlDisplays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlDisplays.Location = new System.Drawing.Point(287, 126);
            this.tlpnlDisplays.Name = "tlpnlDisplays";
            this.tlpnlDisplays.RowCount = 5;
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.Size = new System.Drawing.Size(356, 337);
            this.tlpnlDisplays.TabIndex = 3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlPorts);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(229, 724);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblGamemodes);
            this.pnlRight.Controls.Add(this.btn501Game);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(737, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(276, 724);
            this.pnlRight.TabIndex = 5;
            // 
            // lblGamemodes
            // 
            this.lblGamemodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGamemodes.Font = new System.Drawing.Font("Helvetica-Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamemodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGamemodes.Location = new System.Drawing.Point(0, 0);
            this.lblGamemodes.Name = "lblGamemodes";
            this.lblGamemodes.Size = new System.Drawing.Size(276, 50);
            this.lblGamemodes.TabIndex = 1;
            this.lblGamemodes.Text = "Gamemodes";
            this.lblGamemodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1013, 724);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.tlpnlDisplays);
            this.Controls.Add(this.btnRotate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DartsMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlPorts.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tlpnlDisplays;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblGamemodes;
    }
}

