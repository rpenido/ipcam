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
using AForge.Controls;

namespace CamViewer
{
    public partial class MainForm : Form
    {

        MJPEGStream stream;
        MJPEGStream stream2;
        MJPEGStream stream3;
        MJPEGStream stream4;
        MJPEGStream stream5;
        ConnectionConfigDataList conf;
        IPanTiltController camController;
        MotionDetector motionDetector;
        DateTime lastFrameDatetime = DateTime.Now;
        double fps;
        Font font = new Font("Courier New", 15, FontStyle.Bold, GraphicsUnit.Pixel, 0);
        DateTime startTime;
        CameraRecorder camRec;

        public MainForm()
        {
            InitializeComponent();

            conf = ConnectionConfigDataList.Get();
            lblPath.Text = conf[0].Path;
            camController = new FOSCAMController(conf[0]);
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
            conf.Save();
            camController.Stop();

            if (stream != null)
            {
                stream.Stop();
            }
            if (stream2 != null)
            {
                stream2.Stop();
            }
            
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
                button2_Click_1(this, null);
            }
            else if (WindowState != FormWindowState.Minimized && btnView.Enabled)
            {
                btnView_Click(this, null);
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

        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            ConfigCameraListForm form = new ConfigCameraListForm();
            form.ShowDialog();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            stream = new MJPEGStream("http://"+conf[0].Address + "/videostream.cgi");
            stream.NewFrame += videoSource_NewFrame;
            stream.Login = conf[0].UserName;
            stream.Password = conf[0].Password;
            if (conf.Count > 1)
            {
                stream2 = new MJPEGStream("http://" + conf[1].Address + "/videostream.cgi");
                //stream2.NewFrame += videoSource_NewFrame;
                stream2.Login = conf[1].UserName;
                stream2.Password = conf[1].Password;

                videoSourcePlayer2.VideoSource = stream2;
            }
            if (conf.Count > 2)
            {
                stream3 = new MJPEGStream("http://" + conf[2].Address + "/videostream.cgi");
                //stream2.NewFrame += videoSource_NewFrame;
                stream3.Login = conf[2].UserName;
                stream3.Password = conf[2].Password;

                videoSourcePlayer3.VideoSource = stream3;
            }


            btnView.Enabled = false;
            btndesconect.Enabled = true;
            btnConfig.Enabled = false;
            btnRecoder.Enabled = true;

            // motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());

            videoSourcePlayer1.VideoSource = stream;
            
            stream.Start();
            stream2.Start();

            Text = "[Conectado] IPCam";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {                        
            stream.Stop();
            stream2.Stop();            
            videoSourcePlayer1.VideoSource = null;
            videoSourcePlayer2.VideoSource = null;            
            btnView.Enabled = true;            
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
            lbltime.Text = //elapsedTime.ToString("hh':'mm':'ss");
            lbltime.Text = elapsedTime.ToString();

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            camController.MoveHome();
        }

     

        private void videoSourcePlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            Point location = e.Location;
            double X = (double)location.X / (double)videoSourcePlayer1.Width * 640;
            double Y = (double)location.Y / (double)videoSourcePlayer1.Height * 480;
            camController.DirectPT((int)X, (int)Y);

        }

        

        private void videoSourcePlayer1_MouseEnter(object sender, EventArgs e)
        {
            videoSourcePlayer1.Focus();
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

        private void videoSourcePlayer2_Click(object sender, EventArgs e)
        {
            VideoSourcePlayer player = sender as VideoSourcePlayer;
            IVideoSource oldSource = player.VideoSource;
            videoSourcePlayer1.VideoSource = player.VideoSource;
            videoSourcePlayer2.VideoSource = stream;
        }

       
        
    }
}
