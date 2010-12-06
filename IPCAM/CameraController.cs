using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;

namespace CamViewer
{

    class CameraController
    {
        const string MOVE_UP = "8101060101010302FF";
        const string MOVE_DOWN = "8101060101010301FF";
        const string MOVE_LEFT = "8101060101010203FF";
        const string MOVE_RIGHT = "8101060101010103FF";

        const string MOVE_UPLEFT = "8101060101010202FF";
        const string MOVE_UPRIGHT = "8101060101010102FF";
        const string MOVE_DOWNLEFT = "8101060101010201FF";
        const string MOVE_DOWNRIGHT = "8101060101010101FF";

        const string MOVE_STOP = "8101060101010303FF";

        const string TELE = "8101040725FF";
        const string WIDE = "8101040735FF";
        const string ZOOM_STOP = "8101040700FF";
        const string HOME = "81010604FF";
        const string Auto_pan = "8101062402FF";
        const string Preset = "8101043F010";
        const string Recall = "8101043F020"; 
        
        private int _delay;
        private Object delayLock = new Object();

        Thread workerThread;
        AutoResetEvent jobEvent;
        ManualResetEvent stopEvent;
        ConnectionConfigData _conf;

        
        private string _command;
        private Object commandLock = new Object();
        

        public CameraController(ConnectionConfigData configuration)
        {
            Logger.WriteLine("Creating camera controller..");
            this._conf = configuration;
            Logger.WriteLine("Creating work thread..");
            workerThread = new Thread(doWork);
            jobEvent = new AutoResetEvent(false);
            stopEvent = new ManualResetEvent(false);
            Logger.WriteLine("Starting work thread..");
            workerThread.Start();
        }

        public void Stop()
        {
            Logger.WriteLine("Stopping work thread..");
            stopEvent.Set();
            workerThread.Join();
            Logger.WriteLine("Work thread stopped..");
        }

        private void doWork()
        {
            WebRequest request;
            Logger.WriteLine("Work thread started !");
            while (true)
            {
                if (jobEvent.WaitOne(500))
                {
                    Logger.WriteLine("Work thread: Command received [" + _command + "]");
                    lock (delayLock)
                    {
                        Thread.Sleep(_delay);
                    }

                    lock (commandLock)
                    {
                        try
                        {
                            request = WebRequest.Create(_command);

                        }
                        catch (Exception e)
                        {
                            Logger.WriteLine("Work thread: Error creating WebRequest !");
                            Logger.WriteError(e);
                            request = null;
                        }
                    }
                    if (request != null)
                    {
                        request.Credentials = new NetworkCredential(_conf.UserName, _conf.Password);
                        try
                        {
                            AsyncCallback callBack = new AsyncCallback(responseCallback);
                            using (request.GetResponse())
                            {
                            }
                        }
                        catch (Exception e)
                        {
                            Logger.WriteLine("Work thread: Error getting response !");
                            Logger.WriteError(e);
                        }
                    }
                    
                }
                else if (stopEvent.WaitOne(0))
                {
                    break;
                }

            }
        }

        static void responseCallback(IAsyncResult ar)
        {
            Logger.WriteLine("Work thread: Data sent !");
        }


        protected void setCommand(string command)
        {
            lock (commandLock)
            {
                _command = "http://"+_conf.Address+command;
                jobEvent.Set();
            }
        }
        
        protected void setDelay(int time)
        {
            lock (delayLock)
            {
                _delay = time;
                jobEvent.Set();
            }
        }

        public virtual void Auto_Span()
        {

        }



    }
}
