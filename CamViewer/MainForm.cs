using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;

namespace CamViewer
{
    public partial class MainForm : Form
    {
        MJPEGStream stream;
        public MainForm()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res="8";
            /*
            if (radioButton1.Checked)
            {
                res = "8";
            }
            else
            {
                res = "32";
            }
              */ 
            stream = new MJPEGStream("http://192.168.0.100:1030/videostream.cgi?&resolution="+res);
            stream.Login = "a";
            stream.Password = "naoa";
            button1.Enabled = false;
            button2.Enabled = true;
            videoSourcePlayer1.VideoSource = stream;
            stream.Start();
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
    }
}
