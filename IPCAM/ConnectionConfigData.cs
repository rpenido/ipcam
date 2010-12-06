using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace CamViewer
{
    [Serializable]
    public class ConnectionConfigData
    {
        public string Address;
        public string UserName;
        public string Password;
        public string Path ="c:\\";

        

        private static ConnectionConfigData _conf;

        public ConnectionConfigData()
        {
            // Private constructor
        }
        /*
        public static void CreateConnectionConfigData()
        {
            if (File.Exists("config.dat"))
            {
                Logger.WriteLine("Loading config file...");
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("config.dat", FileMode.Open);
                fs.Seek(0, SeekOrigin.Begin);
                try
                {
                    _conf = (ConnectionConfigData)bf.Deserialize(fs);
                    Logger.WriteLine("Config file loaded !");
                }
                catch(Exception e)
                {
                    Logger.WriteLine("Error loading config file !");
                    Logger.WriteError(e);
                    _conf = new ConnectionConfigData();
                }
                
                fs.Close();
            }
            else
            {
                Logger.WriteLine("Config file not found !");
                _conf = new ConnectionConfigData();
            }
        }
        
        public void Save()
        {
            Logger.WriteLine("Saving config file !");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("config.dat", FileMode.Create);
            bf.Serialize(fs, this);	 // "Save" object state
            fs.Close();
        }
        
        public static ConnectionConfigData Get()
        {
            if (_conf == null)
            {
                CreateConnectionConfigData();
            }

            return _conf;
        }
         */ 

    }
}
