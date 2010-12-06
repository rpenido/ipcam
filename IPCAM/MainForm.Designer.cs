namespace CamViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnUpRight = new System.Windows.Forms.Button();
            this.btnDownRight = new System.Windows.Forms.Button();
            this.btnDownLeft = new System.Windows.Forms.Button();
            this.btnUpLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.btnRecoder = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btndesconect = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnZoommenos = new System.Windows.Forms.Button();
            this.btnZoomplus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer5 = new AForge.Controls.VideoSourcePlayer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpRight
            // 
            this.btnUpRight.Image = ((System.Drawing.Image)(resources.GetObject("btnUpRight.Image")));
            this.btnUpRight.Location = new System.Drawing.Point(93, 27);
            this.btnUpRight.Name = "btnUpRight";
            this.btnUpRight.Size = new System.Drawing.Size(36, 36);
            this.btnUpRight.TabIndex = 22;
            this.btnUpRight.UseVisualStyleBackColor = true;
            this.btnUpRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpRight_MouseDown);
            this.btnUpRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpRight_MouseUp);
            // 
            // btnDownRight
            // 
            this.btnDownRight.Image = ((System.Drawing.Image)(resources.GetObject("btnDownRight.Image")));
            this.btnDownRight.Location = new System.Drawing.Point(93, 99);
            this.btnDownRight.Name = "btnDownRight";
            this.btnDownRight.Size = new System.Drawing.Size(36, 36);
            this.btnDownRight.TabIndex = 21;
            this.btnDownRight.UseVisualStyleBackColor = true;
            this.btnDownRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDownRight_MouseDown);
            this.btnDownRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDownRight_MouseUp);
            // 
            // btnDownLeft
            // 
            this.btnDownLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnDownLeft.Image")));
            this.btnDownLeft.Location = new System.Drawing.Point(19, 100);
            this.btnDownLeft.Name = "btnDownLeft";
            this.btnDownLeft.Size = new System.Drawing.Size(36, 36);
            this.btnDownLeft.TabIndex = 20;
            this.btnDownLeft.UseVisualStyleBackColor = true;
            this.btnDownLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDownLeft_MouseDown);
            this.btnDownLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDownLeft_MouseUp);
            // 
            // btnUpLeft
            // 
            this.btnUpLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnUpLeft.Image")));
            this.btnUpLeft.Location = new System.Drawing.Point(19, 27);
            this.btnUpLeft.Name = "btnUpLeft";
            this.btnUpLeft.Size = new System.Drawing.Size(36, 36);
            this.btnUpLeft.TabIndex = 19;
            this.btnUpLeft.UseVisualStyleBackColor = true;
            this.btnUpLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpLeft_MouseDown);
            this.btnUpLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpLeft_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(93, 63);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(36, 36);
            this.btnRight.TabIndex = 18;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(56, 99);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(36, 36);
            this.btnDown.TabIndex = 17;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(19, 63);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(36, 36);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(56, 27);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(36, 36);
            this.btnUp.TabIndex = 15;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.Location = new System.Drawing.Point(146, 15);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(614, 513);
            this.videoSourcePlayer1.TabIndex = 23;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.Click += new System.EventHandler(this.videoSourcePlayer1_Click_1);
            this.videoSourcePlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer1_MouseClick);
            this.videoSourcePlayer1.MouseEnter += new System.EventHandler(this.videoSourcePlayer1_MouseEnter);
            this.videoSourcePlayer1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer1_MouseWheel);
            // 
            // btnRecoder
            // 
            this.btnRecoder.Enabled = false;
            this.btnRecoder.Location = new System.Drawing.Point(5, 19);
            this.btnRecoder.Name = "btnRecoder";
            this.btnRecoder.Size = new System.Drawing.Size(115, 33);
            this.btnRecoder.TabIndex = 24;
            this.btnRecoder.Text = "Gravar";
            this.btnRecoder.UseVisualStyleBackColor = true;
            this.btnRecoder.Click += new System.EventHandler(this.btnRecoder_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(5, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 33);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 137);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(47, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lbltime);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnRecoder);
            this.groupBox2.Location = new System.Drawing.Point(11, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 143);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gravação";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPath.Enabled = false;
            this.lblPath.Location = new System.Drawing.Point(32, 113);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(86, 20);
            this.lblPath.TabIndex = 32;
            this.lblPath.Text = "c:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Duração:";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 27);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(51, 56);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(49, 13);
            this.lbltime.TabIndex = 26;
            this.lbltime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btndesconect
            // 
            this.btndesconect.Enabled = false;
            this.btndesconect.Location = new System.Drawing.Point(15, 457);
            this.btndesconect.Name = "btndesconect";
            this.btndesconect.Size = new System.Drawing.Size(115, 33);
            this.btndesconect.TabIndex = 13;
            this.btndesconect.Text = "Desconectar";
            this.btndesconect.UseVisualStyleBackColor = true;
            this.btndesconect.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(15, 495);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(115, 33);
            this.btnConfig.TabIndex = 14;
            this.btnConfig.Text = "Configurar CAM";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click_1);
            // 
            // btnZoommenos
            // 
            this.btnZoommenos.Image = ((System.Drawing.Image)(resources.GetObject("btnZoommenos.Image")));
            this.btnZoommenos.Location = new System.Drawing.Point(14, 155);
            this.btnZoommenos.Name = "btnZoommenos";
            this.btnZoommenos.Size = new System.Drawing.Size(58, 27);
            this.btnZoommenos.TabIndex = 28;
            this.btnZoommenos.UseVisualStyleBackColor = true;
            this.btnZoommenos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWide_MouseDown);
            this.btnZoommenos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWide_MouseUp);
            // 
            // btnZoomplus
            // 
            this.btnZoomplus.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomplus.Image")));
            this.btnZoomplus.Location = new System.Drawing.Point(64, 15);
            this.btnZoomplus.Name = "btnZoomplus";
            this.btnZoomplus.Size = new System.Drawing.Size(58, 27);
            this.btnZoomplus.TabIndex = 29;
            this.btnZoomplus.UseVisualStyleBackColor = true;
            this.btnZoomplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTele_MouseDown);
            this.btnZoomplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTele_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZoomplus);
            this.groupBox3.Location = new System.Drawing.Point(9, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 52);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textBox16);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.btnSet);
            this.groupBox4.Controls.Add(this.btn16);
            this.groupBox4.Controls.Add(this.btn15);
            this.groupBox4.Controls.Add(this.btn14);
            this.groupBox4.Controls.Add(this.btn13);
            this.groupBox4.Controls.Add(this.btn12);
            this.groupBox4.Controls.Add(this.btn11);
            this.groupBox4.Controls.Add(this.btn10);
            this.groupBox4.Controls.Add(this.btn9);
            this.groupBox4.Controls.Add(this.btn8);
            this.groupBox4.Controls.Add(this.btn7);
            this.groupBox4.Controls.Add(this.btn6);
            this.groupBox4.Controls.Add(this.btn5);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.btn3);
            this.groupBox4.Controls.Add(this.btn4);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Location = new System.Drawing.Point(766, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 520);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preset Position";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(42, 448);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 32;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(42, 420);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 31;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(42, 392);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 30;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(42, 364);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 29;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(42, 336);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 28;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(42, 308);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(42, 281);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(42, 252);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(42, 224);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(42, 196);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(42, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(42, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSet
            // 
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(8, 476);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(76, 26);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Set Position";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btn16
            // 
            this.btn16.Enabled = false;
            this.btn16.Location = new System.Drawing.Point(9, 448);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(27, 22);
            this.btn16.TabIndex = 15;
            this.btn16.Text = "16";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn15
            // 
            this.btn15.Enabled = false;
            this.btn15.Location = new System.Drawing.Point(9, 420);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(27, 22);
            this.btn15.TabIndex = 14;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn14
            // 
            this.btn14.Enabled = false;
            this.btn14.Location = new System.Drawing.Point(9, 392);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(27, 22);
            this.btn14.TabIndex = 13;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btn13
            // 
            this.btn13.Enabled = false;
            this.btn13.Location = new System.Drawing.Point(9, 364);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(27, 22);
            this.btn13.TabIndex = 12;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn12
            // 
            this.btn12.Enabled = false;
            this.btn12.Location = new System.Drawing.Point(9, 336);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(27, 22);
            this.btn12.TabIndex = 11;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.Enabled = false;
            this.btn11.Location = new System.Drawing.Point(9, 308);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(27, 22);
            this.btn11.TabIndex = 10;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn10
            // 
            this.btn10.Enabled = false;
            this.btn10.Location = new System.Drawing.Point(9, 280);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(27, 22);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn9
            // 
            this.btn9.Enabled = false;
            this.btn9.Location = new System.Drawing.Point(9, 252);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(27, 22);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Enabled = false;
            this.btn8.Location = new System.Drawing.Point(9, 224);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(27, 22);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Enabled = false;
            this.btn7.Location = new System.Drawing.Point(9, 196);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(27, 22);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Enabled = false;
            this.btn6.Location = new System.Drawing.Point(9, 168);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(27, 22);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Enabled = false;
            this.btn5.Location = new System.Drawing.Point(9, 140);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(27, 22);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(9, 56);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(27, 22);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Enabled = false;
            this.btn3.Location = new System.Drawing.Point(9, 84);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(27, 22);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Enabled = false;
            this.btn4.Location = new System.Drawing.Point(9, 112);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(27, 22);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Enabled = false;
            this.btn1.Location = new System.Drawing.Point(9, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(27, 22);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer2.ContextMenuStrip = this.contextMenuStrip1;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(146, 534);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer2.TabIndex = 32;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer3.Location = new System.Drawing.Point(306, 534);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer3.TabIndex = 33;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer4.Location = new System.Drawing.Point(465, 534);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer4.TabIndex = 34;
            this.videoSourcePlayer4.Text = "videoSourcePlayer4";
            this.videoSourcePlayer4.VideoSource = null;
            // 
            // videoSourcePlayer5
            // 
            this.videoSourcePlayer5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer5.Location = new System.Drawing.Point(625, 534);
            this.videoSourcePlayer5.Name = "videoSourcePlayer5";
            this.videoSourcePlayer5.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer5.TabIndex = 35;
            this.videoSourcePlayer5.Text = "videoSourcePlayer5";
            this.videoSourcePlayer5.VideoSource = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 693);
            this.Controls.Add(this.videoSourcePlayer5);
            this.Controls.Add(this.videoSourcePlayer4);
            this.Controls.Add(this.videoSourcePlayer3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.videoSourcePlayer2);
            this.Controls.Add(this.btnZoommenos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.btnUpRight);
            this.Controls.Add(this.btnDownRight);
            this.Controls.Add(this.btnDownLeft);
            this.Controls.Add(this.btnUpLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btndesconect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IP CAM BETA V. 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpRight;
        private System.Windows.Forms.Button btnDownRight;
        private System.Windows.Forms.Button btnDownLeft;
        private System.Windows.Forms.Button btnUpLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button btnRecoder;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndesconect;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnZoommenos;
        private System.Windows.Forms.Button btnZoomplus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lblPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSet;
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
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

