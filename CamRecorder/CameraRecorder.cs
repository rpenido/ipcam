using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.VFW;
using System.Drawing;
using System.Windows.Forms;

namespace CamRecorder
{
    public class CameraRecorder
    {
        private string address;
        
        private MJPEGStream stream;
        private AVIWriter recorder;        
        private Font font = new Font("Courier New", 15, FontStyle.Bold, GraphicsUnit.Pixel, 0);

        public CameraRecorder(string address)
        {
            this.address = address;
            stream = new MJPEGStream(address + "/image?speed=0");

            recorder = new AVIWriter("XVID");
            recorder.FrameRate = 10;
            recorder.Open("c:\\test.avi", 736, 480);

            stream.NewFrame += newFrameEvent;

            stream.Login = "admin";
            stream.Password = "cwhyc1pk98n";
            stream.Start();
        }

        private void newFrameEvent(object sender, NewFrameEventArgs eventArgs)
        {
            DateTime currentTime = DateTime.Now;
            Graphics graphics = Graphics.FromImage(eventArgs.Frame);
            TextRenderer.DrawText(graphics, currentTime.ToString("dd/mm/yyyy hh:mm:ss"), font, new Point(5, 5),
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
