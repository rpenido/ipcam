using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CamRecorder
{
    public partial class MainForm : Form
    {
        string path="c:\\";
        DateTime startTime;
        CameraRecorder camRec;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            camRec = new CameraRecorder("http://10.10.30.5");
            timer1.Enabled = true;
            label1.Visible = true;
            btnStop.Enabled = true;
            btnRecord.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            camRec.Stop();
            timer1.Enabled = false;
            btnStop.Enabled = false;
            btnRecord.Enabled = true;
                             

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            lblPath.Text = path;
            

        }

   
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            label1.Text = elapsedTime.ToString("hh':'mm':'ss");
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            camRec.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPath_TextChanged(object sender, EventArgs e)
        {

        }

     

     
       
       
        

    }
}
