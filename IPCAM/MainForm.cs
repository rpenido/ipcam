using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using AForge.Video;
using AForge.Vision.Motion;
using System.Threading;
using AForge.Video.VFW;

namespace CamViewer
{
    public partial class MainForm : Form
    {

        MJPEGStream stream;
        MJPEGStream stream2;
        ConnectionConfigDataList conf;
        CameraController camController;
        MotionDetector motionDetector;
        DateTime lastFrameDatetime = DateTime.Now;
        double fps;
        Font font = new Font("Courier New", 15, FontStyle.Bold, GraphicsUnit.Pixel, 0);
        //string path = "c:\\";
        DateTime startTime;
        CameraRecorder camRec;

        public MainForm()
        {
            InitializeComponent();
            videoSourcePlayer1.MouseWheel +=  new System.Windows.Forms.MouseEventHandler(videoSourcePlayer1_MouseWheel);

            conf = ConnectionConfigDataList.Get();
            lblPath.Text = conf[0].Path;
            camController = new CameraController(conf[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            DateTime currentTime = DateTime.Now;
            fps = 1 / (currentTime - lastFrameDatetime).TotalSeconds;
            Graphics b = Graphics.FromImage(eventArgs.Frame);
            TextRenderer.DrawText(b, currentTime.ToString("dd/mm/yyyy HH:mm:ss"), font, new Point(5, 5),
                Color.White, Color.Black);
            TextRenderer.DrawText(b, fps.ToString(), font, new Point(5, 20),
                Color.White, Color.Black);
            //a.AddFrame(eventArgs.Frame);
            lastFrameDatetime = currentTime;
         //   motionDetector.ProcessFrame(eventArgs.Frame);
        }


       

      
        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveDown();
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            camController.Stop();

            if (stream != null)
            {
                stream.Stop();
            }
            conf.Save();
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveLeft();
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveUp();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveRight();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && btndesconect.Enabled && conf != null)
            {
               
            }
            else if (WindowState != FormWindowState.Minimized && button1.Enabled)
            {
                button1_Click(this, null);
            }
        }

        private void btnUpLeft_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveUpLeft();
        }

        private void btnUpLeft_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void btnUpRight_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveUpRight();
        }

        private void btnUpRight_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void btnDownRight_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveDownRight();
        }

        private void btnDownRight_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void btnDownLeft_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveDownLeft();
        }

        private void btnDownLeft_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMove();
        }

        private void btnTele_MouseDown(object sender, MouseEventArgs e)
        {
            camController.ZoomTele();
        }
        
        private void btnTele_MouseUp(object sender, MouseEventArgs e)
        {
            camController.ZoomStop();
        }
        
        private void btnWide_MouseDown(object sender, MouseEventArgs e)
        {
            camController.ZoomWide();
        }

        private void btnWide_MouseUp(object sender, MouseEventArgs e)
        {
            camController.ZoomStop();
        }

        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            ConfigCameraListForm form = new ConfigCameraListForm();
            form.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            stream = new MJPEGStream("http://"+conf[0].Address + "/image?speed=0");
            stream.NewFrame += videoSource_NewFrame;
            stream.Login = conf[0].UserName;
            stream.Password = conf[0].Password;
            
            stream2 = new MJPEGStream("http://" + conf[1].Address + "/image?speed=0");
            //stream2.NewFrame += videoSource_NewFrame;
            stream2.Login = conf[1].UserName;
            stream2.Password = conf[1].Password;

            videoSourcePlayer2.VideoSource = stream2;
            


            button1.Enabled = false;
            btndesconect.Enabled = true;
            btnConfig.Enabled = false;
            btnRecoder.Enabled = true;

            // motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());

            videoSourcePlayer1.VideoSource = stream;
            
            stream.Start();
            stream2.Start();

            Text = "[Conectado] IPCam";
            camController.Auto_Span();            
            btnSet.Enabled = true;
            btn1.Enabled=true;
            btn2.Enabled=true;
            btn3.Enabled=true;
            btn4.Enabled=true;
            btn5.Enabled=true;
            btn6.Enabled=true;
            btn7.Enabled=true;
            btn8.Enabled=true;
            btn9.Enabled=true;
            btn10.Enabled=true;
            btn11.Enabled=true;
            btn12.Enabled=true;
            btn13.Enabled=true;
            btn14.Enabled=true;
            btn15.Enabled=true;
            btn16.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
            stream.SignalToStop();            
            videoSourcePlayer1.VideoSource = null;            
            button1.Enabled = true;            
            btndesconect.Enabled = false;
            btnConfig.Enabled = true;
            btnRecoder.Enabled = false;
            Text = "IPCam";
            

        }

  
        private void btnRecoder_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            camRec = new CameraRecorder(stream,conf[0].Path, fps);
            lbltime.Text = "00:00:00";
            timer1.Enabled = true;
            btnConfig.Enabled = false;
            btnRecoder.Enabled = false;
            btndesconect.Enabled = false;
            btnStop.Enabled = true;
            button3.Enabled = false;
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            camRec.Stop();
            btnRecoder.Enabled = true;
            btnStop.Enabled = true;
            btnStop.Enabled = false;
            btndesconect.Enabled = true;
            timer1.Enabled = false;
            button3.Enabled = true;
            
        }

     
        
        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            conf[0].Path = folderBrowserDialog1.SelectedPath;
            lblPath.Text = conf[0].Path;

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            lbltime.Text = elapsedTime.ToString("hh':'mm':'ss");

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            camController.MoveHome();
        }

   

        private void btnSet_Click(object sender, EventArgs e)
        {
            presetButtons(true);
            btnSet.Enabled = false;
        }

        private void videoSourcePlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            Point location = e.Location;
            double X = (double)location.X / (double)videoSourcePlayer1.Width * 640;
            double Y = (double)location.Y / (double)videoSourcePlayer1.Height * 480;
            camController.DirectPT((int)X, (int)Y);

        }

    
        private void videoSourcePlayer1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                camController.ZoomTeleRelative("10");
                

            }
            else
            {
                camController.ZoomWideRelative("10");
                
            }
        }

     

        private void videoSourcePlayer1_MouseEnter(object sender, EventArgs e)
        {
            videoSourcePlayer1.Focus();
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            presetPosition("0");
        }
        private void presetButtons(Boolean status) 
        {
            if (status == true)
            {
                btn1.BackColor = SystemColors.ActiveCaption;
                btn2.BackColor = SystemColors.ActiveCaption;
                btn3.BackColor = SystemColors.ActiveCaption;
                btn4.BackColor = SystemColors.ActiveCaption;
                btn5.BackColor = SystemColors.ActiveCaption;
                btn6.BackColor = SystemColors.ActiveCaption;
                btn7.BackColor = SystemColors.ActiveCaption;
                btn8.BackColor = SystemColors.ActiveCaption;
                btn9.BackColor = SystemColors.ActiveCaption;
                btn10.BackColor = SystemColors.ActiveCaption;
                btn11.BackColor = SystemColors.ActiveCaption;
                btn12.BackColor = SystemColors.ActiveCaption;
                btn13.BackColor = SystemColors.ActiveCaption;
                btn14.BackColor = SystemColors.ActiveCaption;
                btn15.BackColor = SystemColors.ActiveCaption;
                btn16.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                btn1.BackColor = SystemColors.Control;
                btn2.BackColor = SystemColors.Control;
                btn3.BackColor = SystemColors.Control;
                btn4.BackColor = SystemColors.Control;
                btn5.BackColor = SystemColors.Control;
                btn6.BackColor = SystemColors.Control;
                btn7.BackColor = SystemColors.Control;
                btn8.BackColor = SystemColors.Control;
                btn9.BackColor = SystemColors.Control;
                btn10.BackColor = SystemColors.Control;
                btn11.BackColor = SystemColors.Control;
                btn12.BackColor = SystemColors.Control;
                btn13.BackColor = SystemColors.Control;
                btn14.BackColor = SystemColors.Control;
                btn15.BackColor = SystemColors.Control;
                btn16.BackColor = SystemColors.Control;
            }
            
        }

        private void presetPosition(string position)
        {
            if (btnSet.Enabled == false)
            {
                camController.CamPreset(position);
                btnSet.Enabled = true;
                presetButtons(false);
            }
            else
            {
                camController.CamRecall(position);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            presetPosition("1");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            presetPosition("2");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            presetPosition("3");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            presetPosition("4");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            presetPosition("5");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            presetPosition("6");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            presetPosition("7");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            presetPosition("8");
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            presetPosition("9");
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            presetPosition("A");
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            presetPosition("B");
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            presetPosition("C");
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            presetPosition("D");
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            presetPosition("E");
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            presetPosition("F");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            for (int i = 0; i < conf.Count; i++)
            {
                contextMenuStrip1.Items.Add(conf[i].Address);
            }
            e.Cancel = false;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = contextMenuStrip1.Items.IndexOf(e.ClickedItem);

            if (index == 0)
            {
                videoSourcePlayer2.VideoSource = stream;
            }
            else
            {
                videoSourcePlayer2.VideoSource = stream2;
            }
            
        }

       
        
    }
}
