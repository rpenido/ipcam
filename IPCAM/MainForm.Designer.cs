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
            this.btnView = new System.Windows.Forms.Button();
            this.btndesconect = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer5 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.videoSourcePlayer1.Location = new System.Drawing.Point(146, 15);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(614, 513);
            this.videoSourcePlayer1.TabIndex = 23;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer1_MouseClick);
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
            this.groupBox2.Location = new System.Drawing.Point(9, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 143);
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
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(13, 321);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(115, 33);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btndesconect
            // 
            this.btndesconect.Enabled = false;
            this.btndesconect.Location = new System.Drawing.Point(14, 359);
            this.btndesconect.Name = "btndesconect";
            this.btndesconect.Size = new System.Drawing.Size(115, 33);
            this.btndesconect.TabIndex = 13;
            this.btndesconect.Text = "Desconectar";
            this.btndesconect.UseVisualStyleBackColor = true;
            this.btndesconect.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(14, 397);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(115, 33);
            this.btnConfig.TabIndex = 14;
            this.btnConfig.Text = "Configurar CAM";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click_1);
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Location = new System.Drawing.Point(146, 534);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer2.TabIndex = 32;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.Click += new System.EventHandler(this.videoSourcePlayer2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Location = new System.Drawing.Point(306, 534);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer3.TabIndex = 33;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Location = new System.Drawing.Point(465, 534);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer4.TabIndex = 34;
            this.videoSourcePlayer4.Text = "videoSourcePlayer4";
            this.videoSourcePlayer4.VideoSource = null;
            // 
            // videoSourcePlayer5
            // 
            this.videoSourcePlayer5.Location = new System.Drawing.Point(625, 534);
            this.videoSourcePlayer5.Name = "videoSourcePlayer5";
            this.videoSourcePlayer5.Size = new System.Drawing.Size(135, 116);
            this.videoSourcePlayer5.TabIndex = 35;
            this.videoSourcePlayer5.Text = "videoSourcePlayer5";
            this.videoSourcePlayer5.VideoSource = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 655);
            this.Controls.Add(this.videoSourcePlayer5);
            this.Controls.Add(this.videoSourcePlayer4);
            this.Controls.Add(this.videoSourcePlayer3);
            this.Controls.Add(this.videoSourcePlayer2);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.btnUpRight);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDownRight);
            this.Controls.Add(this.btnDownLeft);
            this.Controls.Add(this.btnUpLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndesconect);
            this.Controls.Add(this.btnView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IP CAM BETA V. 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btndesconect;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.TextBox lblPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

