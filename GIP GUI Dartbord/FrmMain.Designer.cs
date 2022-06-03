
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
            this.btn20 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblGamemodes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRotateOff = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnAtc = new System.Windows.Forms.Button();
            this.lblATC = new System.Windows.Forms.Label();
            this.pnlPorts.SuspendLayout();
            this.tlpnlDisplays.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRotateOff.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn501Game
            // 
            this.btn501Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn501Game.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn501Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn501Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn501Game.Location = new System.Drawing.Point(31, 46);
            this.btn501Game.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn501Game.Name = "btn501Game";
            this.btn501Game.Size = new System.Drawing.Size(142, 85);
            this.btn501Game.TabIndex = 0;
            this.btn501Game.Text = "501";
            this.btn501Game.UseVisualStyleBackColor = false;
            this.btn501Game.Click += new System.EventHandler(this.btn501Game_Click);
            this.btn501Game.Paint += new System.Windows.Forms.PaintEventHandler(this.btn501Game_Paint);
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRotate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.Location = new System.Drawing.Point(0, 0);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(161, 110);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = " Rotate";
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // pnlPorts
            // 
            this.pnlPorts.Controls.Add(this.lblVerbinding);
            this.pnlPorts.Controls.Add(this.lstPoort);
            this.pnlPorts.Controls.Add(this.btnZoekSerial);
            this.pnlPorts.Location = new System.Drawing.Point(3, 46);
            this.pnlPorts.Name = "pnlPorts";
            this.pnlPorts.Size = new System.Drawing.Size(162, 308);
            this.pnlPorts.TabIndex = 2;
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
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.Location = new System.Drawing.Point(0, 41);
            this.lstPoort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(162, 267);
            this.lstPoort.TabIndex = 4;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // btnZoekSerial
            // 
            this.btnZoekSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoekSerial.Location = new System.Drawing.Point(0, 0);
            this.btnZoekSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZoekSerial.MinimumSize = new System.Drawing.Size(0, 41);
            this.btnZoekSerial.Name = "btnZoekSerial";
            this.btnZoekSerial.Size = new System.Drawing.Size(162, 41);
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
            this.tlpnlDisplays.Controls.Add(this.btn20, 3, 4);
            this.tlpnlDisplays.Controls.Add(this.btn19, 2, 4);
            this.tlpnlDisplays.Controls.Add(this.btn18, 1, 4);
            this.tlpnlDisplays.Controls.Add(this.btn17, 0, 4);
            this.tlpnlDisplays.Controls.Add(this.btn16, 3, 3);
            this.tlpnlDisplays.Controls.Add(this.btn15, 2, 3);
            this.tlpnlDisplays.Controls.Add(this.btn14, 1, 3);
            this.tlpnlDisplays.Controls.Add(this.btn13, 0, 3);
            this.tlpnlDisplays.Controls.Add(this.btn12, 3, 2);
            this.tlpnlDisplays.Controls.Add(this.btn11, 2, 2);
            this.tlpnlDisplays.Controls.Add(this.btn10, 1, 2);
            this.tlpnlDisplays.Controls.Add(this.btn9, 0, 2);
            this.tlpnlDisplays.Controls.Add(this.btn8, 3, 1);
            this.tlpnlDisplays.Controls.Add(this.btn7, 2, 1);
            this.tlpnlDisplays.Controls.Add(this.btn6, 1, 1);
            this.tlpnlDisplays.Controls.Add(this.btn5, 0, 1);
            this.tlpnlDisplays.Controls.Add(this.btn4, 3, 0);
            this.tlpnlDisplays.Controls.Add(this.btn3, 2, 0);
            this.tlpnlDisplays.Controls.Add(this.btn2, 1, 0);
            this.tlpnlDisplays.Controls.Add(this.btn1, 0, 0);
            this.tlpnlDisplays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpnlDisplays.Location = new System.Drawing.Point(0, 313);
            this.tlpnlDisplays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpnlDisplays.Name = "tlpnlDisplays";
            this.tlpnlDisplays.RowCount = 5;
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlDisplays.Size = new System.Drawing.Size(329, 275);
            this.tlpnlDisplays.TabIndex = 3;
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(248, 222);
            this.btn20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(79, 51);
            this.btn20.TabIndex = 19;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn19
            // 
            this.btn19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn19.Location = new System.Drawing.Point(166, 222);
            this.btn19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(78, 51);
            this.btn19.TabIndex = 18;
            this.btn19.Text = "19";
            this.btn19.UseVisualStyleBackColor = false;
            this.btn19.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn18
            // 
            this.btn18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn18.Location = new System.Drawing.Point(84, 222);
            this.btn18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(78, 51);
            this.btn18.TabIndex = 17;
            this.btn18.Text = "18";
            this.btn18.UseVisualStyleBackColor = false;
            this.btn18.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn17
            // 
            this.btn17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn17.Location = new System.Drawing.Point(2, 222);
            this.btn17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(78, 51);
            this.btn17.TabIndex = 16;
            this.btn17.Text = "17";
            this.btn17.UseVisualStyleBackColor = false;
            this.btn17.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16.Location = new System.Drawing.Point(248, 167);
            this.btn16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(79, 51);
            this.btn16.TabIndex = 15;
            this.btn16.Text = "16";
            this.btn16.UseVisualStyleBackColor = false;
            this.btn16.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(166, 167);
            this.btn15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(78, 51);
            this.btn15.TabIndex = 14;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Location = new System.Drawing.Point(84, 167);
            this.btn14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(78, 51);
            this.btn14.TabIndex = 13;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(2, 167);
            this.btn13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(78, 51);
            this.btn13.TabIndex = 12;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(248, 112);
            this.btn12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(79, 51);
            this.btn12.TabIndex = 11;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(166, 112);
            this.btn11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(78, 51);
            this.btn11.TabIndex = 10;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(84, 112);
            this.btn10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(78, 51);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(2, 112);
            this.btn9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 51);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(248, 57);
            this.btn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 51);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(166, 57);
            this.btn7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 51);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(84, 57);
            this.btn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 51);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(2, 57);
            this.btn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 51);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(248, 2);
            this.btn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 51);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(166, 2);
            this.btn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 51);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(84, 2);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 51);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(2, 2);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 51);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BtnLights_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlPorts);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(224, 588);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panel2);
            this.pnlRight.Controls.Add(this.lblGamemodes);
            this.pnlRight.Controls.Add(this.btn501Game);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(553, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(207, 588);
            this.pnlRight.TabIndex = 5;
            // 
            // lblGamemodes
            // 
            this.lblGamemodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGamemodes.Font = new System.Drawing.Font("Helvetica-Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamemodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGamemodes.Location = new System.Drawing.Point(0, 0);
            this.lblGamemodes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGamemodes.Name = "lblGamemodes";
            this.lblGamemodes.Size = new System.Drawing.Size(207, 41);
            this.lblGamemodes.TabIndex = 1;
            this.lblGamemodes.Text = "Gamemodes";
            this.lblGamemodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRotateOff);
            this.panel1.Controls.Add(this.lblControls);
            this.panel1.Controls.Add(this.tlpnlDisplays);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 588);
            this.panel1.TabIndex = 7;
            // 
            // pnlRotateOff
            // 
            this.pnlRotateOff.Controls.Add(this.btnRotate);
            this.pnlRotateOff.Controls.Add(this.btnOff);
            this.pnlRotateOff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRotateOff.Location = new System.Drawing.Point(0, 203);
            this.pnlRotateOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRotateOff.Name = "pnlRotateOff";
            this.pnlRotateOff.Size = new System.Drawing.Size(329, 110);
            this.pnlRotateOff.TabIndex = 6;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(168, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(161, 110);
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lblControls
            // 
            this.lblControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControls.Font = new System.Drawing.Font("Helvetica-Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblControls.Location = new System.Drawing.Point(0, 0);
            this.lblControls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(329, 41);
            this.lblControls.TabIndex = 4;
            this.lblControls.Text = "Controls";
            this.lblControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblATC);
            this.panel2.Controls.Add(this.btnHit);
            this.panel2.Controls.Add(this.btnAtc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 237);
            this.panel2.TabIndex = 3;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHit.Enabled = false;
            this.btnHit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(31, 93);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(142, 45);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "HIT!";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnAtc
            // 
            this.btnAtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtc.Location = new System.Drawing.Point(0, 0);
            this.btnAtc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtc.Name = "btnAtc";
            this.btnAtc.Size = new System.Drawing.Size(207, 70);
            this.btnAtc.TabIndex = 2;
            this.btnAtc.Text = "Around the clock";
            this.btnAtc.UseVisualStyleBackColor = false;
            this.btnAtc.Click += new System.EventHandler(this.btnAtc_Click);
            // 
            // lblATC
            // 
            this.lblATC.BackColor = System.Drawing.Color.Black;
            this.lblATC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblATC.Location = new System.Drawing.Point(58, 154);
            this.lblATC.Name = "lblATC";
            this.lblATC.Size = new System.Drawing.Size(87, 63);
            this.lblATC.TabIndex = 4;
            this.lblATC.Text = "0";
            this.lblATC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(760, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DartsMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlPorts.ResumeLayout(false);
            this.tlpnlDisplays.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlRotateOff.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Panel pnlRotateOff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnAtc;
        private System.Windows.Forms.Label lblATC;
    }
}

