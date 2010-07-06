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
            this._conf = configuration;
            workerThread = new Thread(doWork);
            jobEvent = new AutoResetEvent(false);
            stopEvent = new ManualResetEvent(false);
            workerThread.Start();
        }
        public void Stop()
        {
            stopEvent.Set();
            workerThread.Join();
        }


        private void doWork()
        {
            WebRequest request;

            while (true)
            {
                if (jobEvent.WaitOne(500))
                {
                    lock (delayLock)
                    {
                        Thread.Sleep(_delay);
                    }

                    lock (commandLock)
                    {
                        request = WebRequest.Create(_command);
                    }
                    request.Credentials = new NetworkCredential(_conf.UserName, _conf.Password);
                    request.GetResponse();
                }
                else if (stopEvent.WaitOne(0))
                {
                    break;
                }

            }
        }

        private void setCommand(string command)
        {
            lock (commandLock)
            {
                _command = command;
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
            setCommand(_conf + "/decoder_control.cgi?command=" + MOVE_UP);
        }

        public void MoveUp(int time)
        {
            MoveUp();
            setDelay(time);
            StopMoveUp();
        }

        public void StopMoveUp()
        {
            setCommand(_conf + "/decoder_control.cgi?command=" + STOP_MOVE_UP);
        }

        public void MoveDown()
        {
            setCommand(_conf + "/decoder_control.cgi?command=" + MOVE_DOWN);
        }

        public void MoveDown(int time)
        {
            MoveDown();
            setDelay(time);
            StopMoveDown();
        }

        public void StopMoveDown()
        {
            setCommand(_conf + "/decoder_control.cgi?command=" + STOP_MOVE_DOWN);
        }
    }
}
