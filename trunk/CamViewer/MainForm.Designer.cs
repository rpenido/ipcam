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
            this.btnRight2 = new System.Windows.Forms.Button();
            this.btnDown2 = new System.Windows.Forms.Button();
            this.btnLeft2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(93, 1);
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
            this.btnUp.Location = new System.Drawing.Point(35, 109);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(19, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "U";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseLeave += new System.EventHandler(this.btnUp_MouseLeave);
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 133);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(19, 23);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "L";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(35, 159);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(19, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "D";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(58, 133);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(19, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "R";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnRight2
            // 
            this.btnRight2.Location = new System.Drawing.Point(58, 239);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(19, 23);
            this.btnRight2.TabIndex = 11;
            this.btnRight2.Text = "R";
            this.btnRight2.UseVisualStyleBackColor = true;
            // 
            // btnDown2
            // 
            this.btnDown2.Location = new System.Drawing.Point(35, 265);
            this.btnDown2.Name = "btnDown2";
            this.btnDown2.Size = new System.Drawing.Size(19, 23);
            this.btnDown2.TabIndex = 10;
            this.btnDown2.Text = "D";
            this.btnDown2.UseVisualStyleBackColor = true;
            this.btnDown2.Click += new System.EventHandler(this.btnDown2_Click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.Location = new System.Drawing.Point(12, 239);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(19, 23);
            this.btnLeft2.TabIndex = 9;
            this.btnLeft2.Text = "L";
            this.btnLeft2.UseVisualStyleBackColor = true;
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(35, 215);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(19, 23);
            this.btnUp2.TabIndex = 8;
            this.btnUp2.Text = "U";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(18, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 484);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRight2);
            this.Controls.Add(this.btnDown2);
            this.Controls.Add(this.btnLeft2);
            this.Controls.Add(this.btnUp2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnRight2;
        private System.Windows.Forms.Button btnDown2;
        private System.Windows.Forms.Button btnLeft2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

