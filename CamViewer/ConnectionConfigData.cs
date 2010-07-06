using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace CamViewer
{
    [Serializable]
    class ConnectionConfigData
    {
        public string Address;
        public string UserName;
        public string Password;
        public bool HighResolution;

        private ConnectionConfigData()
        {
            // Private constructor
        }
        public static ConnectionConfigData GetConnectionConfigData()
        {
            ConnectionConfigData conf;
            if (File.Exists("config.dat"))
            {
                Logger.WriteLine("Loading config file...");
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("config.dat", FileMode.Open);
                fs.Seek(0, SeekOrigin.Begin);
                try
                {
                    conf = (ConnectionConfigData)bf.Deserialize(fs);
                    Logger.WriteLine("Config file loaded !");
                }
                catch(Exception e)
                {
                    Logger.WriteLine("Error loading config file !");
                    Logger.WriteError(e);
                    conf = new ConnectionConfigData();
                }
                
                fs.Close();
            }
            else
            {
                Logger.WriteLine("Config file not found !");
                conf = new ConnectionConfigData();
            }
            return conf;
        }

        public void Save()
        {
            Logger.WriteLine("Saving config file !");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("config.dat", FileMode.Create);
            bf.Serialize(fs, this);	 // "Save" object state
            fs.Close();
        }

    }
}
