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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUpLeft = new System.Windows.Forms.Button();
            this.btnDownLeft = new System.Windows.Forms.Button();
            this.btnDownRight = new System.Windows.Forms.Button();
            this.btnUpRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.Location = new System.Drawing.Point(114, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(640, 480);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(12, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(45, 99);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(28, 33);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "U";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 134);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(28, 33);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "L";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(46, 168);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(28, 33);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "D";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(80, 134);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(28, 33);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "R";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnUpLeft
            // 
            this.btnUpLeft.Location = new System.Drawing.Point(12, 99);
            this.btnUpLeft.Name = "btnUpLeft";
            this.btnUpLeft.Size = new System.Drawing.Size(28, 33);
            this.btnUpLeft.TabIndex = 8;
            this.btnUpLeft.UseVisualStyleBackColor = true;
            this.btnUpLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpLeft_MouseDown);
            this.btnUpLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpLeft_MouseUp);
            // 
            // btnDownLeft
            // 
            this.btnDownLeft.Location = new System.Drawing.Point(12, 168);
            this.btnDownLeft.Name = "btnDownLeft";
            this.btnDownLeft.Size = new System.Drawing.Size(28, 33);
            this.btnDownLeft.TabIndex = 9;
            this.btnDownLeft.UseVisualStyleBackColor = true;
            // 
            // btnDownRight
            // 
            this.btnDownRight.Location = new System.Drawing.Point(80, 168);
            this.btnDownRight.Name = "btnDownRight";
            this.btnDownRight.Size = new System.Drawing.Size(28, 33);
            this.btnDownRight.TabIndex = 10;
            this.btnDownRight.UseVisualStyleBackColor = true;
            // 
            // btnUpRight
            // 
            this.btnUpRight.Location = new System.Drawing.Point(80, 99);
            this.btnUpRight.Name = "btnUpRight";
            this.btnUpRight.Size = new System.Drawing.Size(28, 33);
            this.btnUpRight.TabIndex = 11;
            this.btnUpRight.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.btnUpRight);
            this.Controls.Add(this.btnDownRight);
            this.Controls.Add(this.btnDownLeft);
            this.Controls.Add(this.btnUpLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "MainForm";
            this.Text = "IPCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUpLeft;
        private System.Windows.Forms.Button btnDownLeft;
        private System.Windows.Forms.Button btnDownRight;
        private System.Windows.Forms.Button btnUpRight;
    }
}

