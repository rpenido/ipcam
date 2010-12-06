using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace CamViewer
{
    static class Logger
    {
        static FileStream fs;
        static StreamWriter sw;

        static Logger()
        {
            fs = new FileStream("log.txt", FileMode.Create);
            sw = new StreamWriter(fs);
            WriteLine("Start session");
        }


        static public void WriteLine(string line)
        {
            sw.WriteLine("["+DateTime.Now.ToString("dd/MM/yy hh:mm:ss") + "] ("
                + Thread.CurrentThread.ManagedThreadId + ") "
                + line);
            sw.Flush();
        }

        static public void WriteError(Exception e)
        {
            WriteLine(e.ToString());
        }

        static public void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            WriteError(ex);
        }
    }
}
