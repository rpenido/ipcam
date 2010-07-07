using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;

namespace CamViewer
{

    class CameraController
    {
        const string MOVE_UP = "0";
        const string STOP_MOVE_UP = "1";

        const string MOVE_DOWN = "2";
        const string STOP_MOVE_DOWN = "3";

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
                            request.Method = "POST";
                        }
                        catch(Exception e)
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
                            request.BeginGetResponse(callBack, null);
                        }
                        catch(Exception e)
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


        private void setCommand(string command)
        {
            lock (commandLock)
            {
                _command = _conf.Address+command;
                jobEvent.Set();
            }
        }
        private void setDelay(int time)
        {
            lock (delayLock)
            {
                _delay = time;
                jobEvent.Set();
            }
        }

        public void MoveUp()
        {
            setCommand("/decoder_control.cgi?command=" + MOVE_UP);
        }

        public void MoveUp(int time)
        {
            MoveUp();
            setDelay(time);
            StopMoveUp();
        }

        public void StopMoveUp()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_UP);
        }

        public void MoveDown()
        {
            setCommand("/decoder_control.cgi?command=" + MOVE_DOWN);
        }

        public void MoveDown(int time)
        {
            MoveDown();
            setDelay(time);
            StopMoveDown();
        }

        public void StopMoveDown()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_DOWN);
        }
    }
}
