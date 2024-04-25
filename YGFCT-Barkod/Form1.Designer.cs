namespace YGFCTBarkod
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblStatusCom2 = new System.Windows.Forms.Label();
            this.lblStatusCom1 = new System.Windows.Forms.Label();
            this.btnFCTInit = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAyar = new System.Windows.Forms.Button();
            this.timerAdmin = new System.Windows.Forms.Timer(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.GroupBox();
            this.btnProgAyar = new System.Windows.Forms.Button();
            this.btnKurulum = new System.Windows.Forms.Button();
            this.projectNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardPicture = new System.Windows.Forms.PictureBox();
            this.btnStartProgramming = new System.Windows.Forms.Button();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbBarcodeLast = new System.Windows.Forms.TextBox();
            this.lblBarcodeLast = new System.Windows.Forms.Label();
            this.lblBarcodeCurrent = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbBarcodeCurrent = new System.Windows.Forms.TextBox();
            this.barcode72Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatusCom2
            // 
            this.lblStatusCom2.AutoSize = true;
            this.lblStatusCom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusCom2.Location = new System.Drawing.Point(412, 102);
            this.lblStatusCom2.Name = "lblStatusCom2";
            this.lblStatusCom2.Size = new System.Drawing.Size(57, 25);
            this.lblStatusCom2.TabIndex = 0;
            this.lblStatusCom2.Text = "OFF";
            // 
            // lblStatusCom1
            // 
            this.lblStatusCom1.AutoSize = true;
            this.lblStatusCom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusCom1.Location = new System.Drawing.Point(89, 102);
            this.lblStatusCom1.Name = "lblStatusCom1";
            this.lblStatusCom1.Size = new System.Drawing.Size(57, 25);
            this.lblStatusCom1.TabIndex = 0;
            this.lblStatusCom1.Text = "OFF";
            // 
            // btnFCTInit
            // 
            this.btnFCTInit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFCTInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFCTInit.Location = new System.Drawing.Point(6, 19);
            this.btnFCTInit.Name = "btnFCTInit";
            this.btnFCTInit.Size = new System.Drawing.Size(764, 94);
            this.btnFCTInit.TabIndex = 2;
            this.btnFCTInit.Text = "BUTONLARA BASARAK BARKOD TESTİNİ BAŞLAT";
            this.btnFCTInit.UseVisualStyleBackColor = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFCTInit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(9, 726);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 124);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operator Control";
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rtbConsole);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(809, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(477, 682);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operator Output";
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.rtbConsole.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsole.ForeColor = System.Drawing.Color.White;
            this.rtbConsole.Location = new System.Drawing.Point(9, 22);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(0);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(458, 657);
            this.rtbConsole.TabIndex = 46;
            this.rtbConsole.TabStop = false;
            this.rtbConsole.Text = "";
            this.rtbConsole.TextChanged += new System.EventHandler(this.rtbConsole_TextChanged);
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Location = new System.Drawing.Point(180, 74);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(100, 20);
            this.tbUserLogin.TabIndex = 52;
            this.tbUserLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserLogin_KeyDown_1);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(363, 18);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(110, 45);
            this.btnCikis.TabIndex = 45;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.BackColor = System.Drawing.Color.Aqua;
            this.btnAyar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyar.Location = new System.Drawing.Point(9, 18);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(110, 45);
            this.btnAyar.TabIndex = 6;
            this.btnAyar.Text = "AYARLAR";
            this.btnAyar.UseVisualStyleBackColor = false;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // timerAdmin
            // 
            this.timerAdmin.Tick += new System.EventHandler(this.timerAdmin_Tick_1);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(4, 102);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 25);
            this.label30.TabIndex = 46;
            this.label30.Text = "COM1:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(322, 102);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 25);
            this.label31.TabIndex = 47;
            this.label31.Text = "COM2:";
            // 
            // admin
            // 
            this.admin.Controls.Add(this.btnProgAyar);
            this.admin.Controls.Add(this.btnKurulum);
            this.admin.Controls.Add(this.btnCikis);
            this.admin.Controls.Add(this.tbUserLogin);
            this.admin.Controls.Add(this.lblStatusCom2);
            this.admin.Controls.Add(this.lblStatusCom1);
            this.admin.Controls.Add(this.label30);
            this.admin.Controls.Add(this.btnAyar);
            this.admin.Controls.Add(this.label31);
            this.admin.Location = new System.Drawing.Point(809, 699);
            this.admin.Margin = new System.Windows.Forms.Padding(2);
            this.admin.Name = "admin";
            this.admin.Padding = new System.Windows.Forms.Padding(2);
            this.admin.Size = new System.Drawing.Size(477, 151);
            this.admin.TabIndex = 50;
            this.admin.TabStop = false;
            this.admin.Text = "Admin Kontrol";
            // 
            // btnProgAyar
            // 
            this.btnProgAyar.BackColor = System.Drawing.Color.Aqua;
            this.btnProgAyar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProgAyar.Location = new System.Drawing.Point(128, 18);
            this.btnProgAyar.Name = "btnProgAyar";
            this.btnProgAyar.Size = new System.Drawing.Size(110, 45);
            this.btnProgAyar.TabIndex = 51;
            this.btnProgAyar.Text = "P-AYARLAR";
            this.btnProgAyar.UseVisualStyleBackColor = false;
            this.btnProgAyar.Click += new System.EventHandler(this.btnProgAyar_Click);
            // 
            // btnKurulum
            // 
            this.btnKurulum.BackColor = System.Drawing.Color.Turquoise;
            this.btnKurulum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKurulum.Location = new System.Drawing.Point(246, 18);
            this.btnKurulum.Name = "btnKurulum";
            this.btnKurulum.Size = new System.Drawing.Size(110, 45);
            this.btnKurulum.TabIndex = 50;
            this.btnKurulum.Text = "KURULUM";
            this.btnKurulum.UseVisualStyleBackColor = false;
            this.btnKurulum.Click += new System.EventHandler(this.btnKurulum_Click);
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.BackColor = System.Drawing.Color.Ivory;
            this.projectNameTxt.Enabled = false;
            this.projectNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectNameTxt.Location = new System.Drawing.Point(18, 153);
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.Size = new System.Drawing.Size(769, 46);
            this.projectNameTxt.TabIndex = 55;
            this.projectNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YGFCTBarkod.Properties.Resources.alpnext_Logo_kopyası;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(203, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // cardPicture
            // 
            this.cardPicture.InitialImage = null;
            this.cardPicture.Location = new System.Drawing.Point(18, 360);
            this.cardPicture.Margin = new System.Windows.Forms.Padding(2);
            this.cardPicture.Name = "cardPicture";
            this.cardPicture.Size = new System.Drawing.Size(767, 265);
            this.cardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPicture.TabIndex = 51;
            this.cardPicture.TabStop = false;
            // 
            // btnStartProgramming
            // 
            this.btnStartProgramming.BackColor = System.Drawing.Color.Ivory;
            this.btnStartProgramming.FlatAppearance.BorderSize = 0;
            this.btnStartProgramming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartProgramming.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStartProgramming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnStartProgramming.Image = global::YGFCTBarkod.Properties.Resources.up_32x32;
            this.btnStartProgramming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartProgramming.Location = new System.Drawing.Point(584, 302);
            this.btnStartProgramming.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartProgramming.Name = "btnStartProgramming";
            this.btnStartProgramming.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnStartProgramming.Size = new System.Drawing.Size(119, 44);
            this.btnStartProgramming.TabIndex = 61;
            this.btnStartProgramming.Text = "PROGRAM";
            this.btnStartProgramming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartProgramming.UseVisualStyleBackColor = false;
            this.btnStartProgramming.Click += new System.EventHandler(this.btnStartProgramming_Click);
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.Ivory;
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.ForeColor = System.Drawing.Color.White;
            this.tbState.Location = new System.Drawing.Point(115, 309);
            this.tbState.Margin = new System.Windows.Forms.Padding(0);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(449, 33);
            this.tbState.TabIndex = 56;
            this.tbState.TabStop = false;
            this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBarcodeLast
            // 
            this.tbBarcodeLast.BackColor = System.Drawing.Color.White;
            this.tbBarcodeLast.Enabled = false;
            this.tbBarcodeLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBarcodeLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbBarcodeLast.Location = new System.Drawing.Point(115, 269);
            this.tbBarcodeLast.Margin = new System.Windows.Forms.Padding(0);
            this.tbBarcodeLast.Name = "tbBarcodeLast";
            this.tbBarcodeLast.Size = new System.Drawing.Size(672, 31);
            this.tbBarcodeLast.TabIndex = 60;
            // 
            // lblBarcodeLast
            // 
            this.lblBarcodeLast.AutoSize = true;
            this.lblBarcodeLast.BackColor = System.Drawing.Color.Ivory;
            this.lblBarcodeLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcodeLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBarcodeLast.Location = new System.Drawing.Point(22, 257);
            this.lblBarcodeLast.Margin = new System.Windows.Forms.Padding(0);
            this.lblBarcodeLast.Name = "lblBarcodeLast";
            this.lblBarcodeLast.Size = new System.Drawing.Size(60, 25);
            this.lblBarcodeLast.TabIndex = 57;
            this.lblBarcodeLast.Text = "Son ";
            // 
            // lblBarcodeCurrent
            // 
            this.lblBarcodeCurrent.AutoSize = true;
            this.lblBarcodeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcodeCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBarcodeCurrent.Location = new System.Drawing.Point(19, 202);
            this.lblBarcodeCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBarcodeCurrent.Name = "lblBarcodeCurrent";
            this.lblBarcodeCurrent.Size = new System.Drawing.Size(86, 25);
            this.lblBarcodeCurrent.TabIndex = 58;
            this.lblBarcodeCurrent.Text = "Barkod";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label15.Location = new System.Drawing.Point(23, 227);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 25);
            this.label15.TabIndex = 62;
            this.label15.Text = "Giriş:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Ivory;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label16.Location = new System.Drawing.Point(22, 282);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 25);
            this.label16.TabIndex = 63;
            this.label16.Text = "Barkod:";
            // 
            // tbBarcodeCurrent
            // 
            this.tbBarcodeCurrent.BackColor = System.Drawing.Color.White;
            this.tbBarcodeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBarcodeCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbBarcodeCurrent.Location = new System.Drawing.Point(114, 216);
            this.tbBarcodeCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.tbBarcodeCurrent.Name = "tbBarcodeCurrent";
            this.tbBarcodeCurrent.Size = new System.Drawing.Size(672, 31);
            this.tbBarcodeCurrent.TabIndex = 59;
            // 
            // barcode72Text
            // 
            this.barcode72Text.BackColor = System.Drawing.Color.Ivory;
            this.barcode72Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcode72Text.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode72Text.ForeColor = System.Drawing.Color.White;
            this.barcode72Text.Location = new System.Drawing.Point(154, 690);
            this.barcode72Text.Margin = new System.Windows.Forms.Padding(0);
            this.barcode72Text.Name = "barcode72Text";
            this.barcode72Text.Size = new System.Drawing.Size(631, 33);
            this.barcode72Text.TabIndex = 64;
            this.barcode72Text.TabStop = false;
            this.barcode72Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Barkod-72 :";
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 3000;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 630);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 57);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cypress";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(625, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "3585310200";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(13, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3585310100";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1305, 855);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcode72Text);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnStartProgramming);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbBarcodeLast);
            this.Controls.Add(this.tbBarcodeCurrent);
            this.Controls.Add(this.lblBarcodeLast);
            this.Controls.Add(this.lblBarcodeCurrent);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.cardPicture);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGCM Barkod";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.admin.ResumeLayout(false);
            this.admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnFCTInit;
    public System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.Label lblStatusCom1;
    private System.Windows.Forms.GroupBox groupBox4;
    public System.IO.Ports.SerialPort serialPort2;
    private System.Windows.Forms.Label lblStatusCom2;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.RichTextBox rtbConsole;
    private System.Windows.Forms.Button btnAyar;
    private System.Windows.Forms.Timer timerAdmin;
    private System.Windows.Forms.Button btnCikis;
    private System.Windows.Forms.TextBox tbUserLogin;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.GroupBox admin;
    private System.Windows.Forms.Button btnKurulum;
    private System.Windows.Forms.PictureBox cardPicture;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox projectNameTxt;
    private System.Windows.Forms.Button btnStartProgramming;
    private System.Windows.Forms.TextBox tbState;
    private System.Windows.Forms.TextBox tbBarcodeLast;
    private System.Windows.Forms.Label lblBarcodeLast;
    private System.Windows.Forms.Label lblBarcodeCurrent;
    private System.Windows.Forms.Button btnProgAyar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbBarcodeCurrent;
        private System.Windows.Forms.TextBox barcode72Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer waitTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
    }
}

