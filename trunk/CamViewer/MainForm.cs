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

namespace CamViewer
{
    public partial class MainForm : Form
    {
        MJPEGStream stream;
        ConnectionConfigData conf;
        CameraController camController;
        MotionDetector motionDetector;

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
            
            stream = new MJPEGStream(conf.Address+"/videostream.cgi?&resolution="+res);
            stream.NewFrame += videoSource_NewFrame;
            stream.Login = conf.UserName;
            stream.Password = conf.Password;
            button1.Enabled = false;
            button2.Enabled = true;

            motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            
            videoSourcePlayer1.VideoSource = stream;
            stream.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            motionDetector.ProcessFrame(eventArgs.Frame);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            stream.SignalToStop();
            videoSourcePlayer1.VideoSource = null;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigConnectionForm form = new ConfigConnectionForm();
            form.ShowDialog();
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            camController.MoveUp();
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            camController.StopMoveUp();
        }

        private void btnUp_MouseLeave(object sender, EventArgs e)
        {
            camController.StopMoveUp();
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            int time = int.Parse(textBox1.Text);
            camController.MoveUp(time);
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            int time = int.Parse(textBox1.Text);
            camController.MoveDown(time);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            camController.Stop();

            if (stream != null)
            {
                stream.Stop();
            }
            
            
        }
    }
}
