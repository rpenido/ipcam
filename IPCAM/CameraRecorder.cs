using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.VFW;
using System.Drawing;
using System.Windows.Forms;

namespace CamViewer
{
    public class CameraRecorder
    {
        private string address;
        private string path;
        private MJPEGStream stream;
        private AVIWriter recorder;
        private DateTime startTime;
        private DateTime lastFrameDateTime = DateTime.Now;
        private double fps;        
        private Font font = new Font("Courier New", 15, FontStyle.Bold, GraphicsUnit.Pixel, 0);
        
        private void startRecord(string path, int fps) 
        {
            string fileName = ("cam-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss" + ".avi"));
            recorder = new AVIWriter("XVID");
            recorder.FrameRate = fps;
            recorder.Open(path + "\\"+fileName, 736, 480);
            startTime = DateTime.Now;         
                     
        }

        public CameraRecorder(ConnectionConfigData conf, string path, double fps)
        {
            this.address = "http://"+conf.Address;
            this.path = path;
            this.fps = fps;

            stream = new MJPEGStream("http://"+ address + "/image?speed=0");
            stream.NewFrame += newFrameEvent;
            startRecord(path, (int)fps);
            stream.Login = conf.UserName;
            stream.Password = conf.Password;
            stream.Start();
          
        }

        public CameraRecorder(MJPEGStream stream, string path, double fps)
        {
          
            this.path = path;
            this.stream = stream;
            this.fps = fps;

            startRecord(path, (int) fps);
            stream.NewFrame += newFrameEvent;
            
        }

        private void newFrameEvent(object sender, NewFrameEventArgs eventArgs)
        {
            DateTime currentTime = DateTime.Now;
            fps = 1 / (currentTime - lastFrameDateTime).TotalSeconds;
            
            if (currentTime - startTime > TimeSpan.FromHours(2))
            {
                recorder.Close();
                startRecord(path,(int) fps );
            }
            Graphics graphics = Graphics.FromImage(eventArgs.Frame);
            TextRenderer.DrawText(graphics, currentTime.ToString("dd/mm/yyyy HH:mm:ss"), font, new Point(5, 5),
                Color.White, Color.Black);
            if (recorder != null)
            {
                recorder.AddFrame(eventArgs.Frame);
            }
        }

        public void Stop()
        {
            stream.NewFrame += null;
            recorder.Close();
            recorder = null;
        }
    }
}
