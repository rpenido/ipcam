using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CamViewer
{

    [Serializable]
    public class ConnectionConfigDataList
    {
        private List<ConnectionConfigData> confList = new List<ConnectionConfigData>();

        private static ConnectionConfigDataList _configuration;
        public int Count
        {
            get { return confList.Count; }
        }
        public ConnectionConfigData this[int index]
        {
            get { return confList[index]; }
        }

        private ConnectionConfigDataList()
        {
            // Private constructor
        }

        public void Add(ConnectionConfigData conf)
        {
            confList.Add(conf);
            Save();
        }
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
                    _configuration = (ConnectionConfigDataList)bf.Deserialize(fs);
                    Logger.WriteLine("Config file loaded !");
                }
                catch (Exception e)
                {
                    Logger.WriteLine("Error loading config file !");
                    Logger.WriteError(e);
                    _configuration = new ConnectionConfigDataList();
                }

                fs.Close();
            }
            else
            {
                Logger.WriteLine("Config file not found !");
                _configuration = new ConnectionConfigDataList();
                
                
                ConnectionConfigData a = new ConnectionConfigData();
                a.Address = "10.10.30.5";
                a.UserName = "admin";
                a.Password = "cwhyc1pk98n";
                a.Path = "c:\\";

                _configuration.confList.Add(a);
                
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

        public static ConnectionConfigDataList Get()
        {
            if (_configuration == null)
            {
                CreateConnectionConfigData();
            }

            return _configuration;
        }
    }
}
