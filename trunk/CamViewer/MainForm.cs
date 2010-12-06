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
        ConnectionConfigData conf;
        CameraController camController;
        MotionDetector motionDetector;
        AVIWriter a;
        DateTime lastFrameDatetime = DateTime.Now;
        Font font = new Font("Courier New", 15, FontStyle.Bold, GraphicsUnit.Pixel, 0);

        public MainForm()
        {            
            InitializeComponent();
            conf = ConnectionConfigData.Get();
            camController = new CameraController(conf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res="8";
            
            if (conf.HighResolution)
            {
                res = "32";
            }
            else
            {
                res = "8";
            }
            
            stream = new MJPEGStream(conf.Address+"/image?speed=0");
            stream.NewFrame += videoSource_NewFrame;
            a = new AVIWriter("wmv3");
            a.FrameRate = 20;
            a.Open("c:\\test.avi", 736, 480);
            stream.Login = conf.UserName;
            stream.Password = conf.Password;
            button1.Enabled = false;
            button2.Enabled = true;

            //motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            
            videoSourcePlayer1.VideoSource = stream;
            stream.Start();
            Text = "[Conectado] IPCam";
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            DateTime currentTime = DateTime.Now;
            double fps = 1/(currentTime - lastFrameDatetime).TotalSeconds;
            Graphics b = Graphics.FromImage(eventArgs.Frame);
            TextRenderer.DrawText(b, currentTime.ToString("dd/mm/yyyy hh:mm:ss"), font, new Point(5, 5),
                Color.White, Color.Black);
            TextRenderer.DrawText(b, fps.ToString(), font, new Point(5, 20),
                Color.White, Color.Black);
            a.AddFrame(eventArgs.Frame);
            lastFrameDatetime = currentTime;
            //motionDetector.ProcessFrame(eventArgs.Frame);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            a.Close();
            stream.SignalToStop();
            videoSourcePlayer1.VideoSource = null;
            button1.Enabled = true;
            button2.Enabled = false;
            Text = "IPCam";
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigConnectionForm form = new ConfigConnectionForm();
            form.ShowDialog();
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveDown();
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMoveUp();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            camController.Stop();

            if (stream != null)
            {
                stream.Stop();
            }                        
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveLeft();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMoveLeft();
        }

        
        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveUp();           
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMoveUp();
        }



        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveRight();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMoveRight();
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && button2.Enabled && conf != null)
            {
                button2_Click(this, null);
            }
            else if (WindowState != FormWindowState.Minimized && button1.Enabled)
            {
                button1_Click(this, null);
            }
        }

        private void btnUpLeft_MouseDown(object sender, MouseEventArgs e)
        {
            //camController.MoveUpLeft();
        }

        private void btnUpLeft_MouseUp(object sender, MouseEventArgs e)
        {
            //camController.StopMove();
        }

        private void btnUpRight_MouseDown(object sender, MouseEventArgs e)
        {
            //camController.MoveUpRight();
        }

        private void btnUpRight_MouseUp(object sender, MouseEventArgs e)
        {
            //camController.StopMove();
        }

        private void btnDownRight_MouseDown(object sender, MouseEventArgs e)
        {
            //camController.MoveDownRight();
        }

        private void btnDownRight_MouseUp(object sender, MouseEventArgs e)
        {
            //camController.StopMove();
        }

        private void btnDownLeft_MouseDown(object sender, MouseEventArgs e)
        {
            //camController.MoveDownLeft();
        }

        private void btnDownLeft_MouseUp(object sender, MouseEventArgs e)
        {
            //camController.StopMove();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
