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
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("config.dat", FileMode.Open);
                fs.Seek(0, SeekOrigin.Begin);
                try
                {
                    conf = (ConnectionConfigData)bf.Deserialize(fs);
                }
                catch
                {
                    conf = new ConnectionConfigData();
                }
                
                fs.Close();
            }
            else
            {
                conf = new ConnectionConfigData();
            }
            return conf;
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("config.dat", FileMode.Create);
            bf.Serialize(fs, this);	 // "Save" object state
            fs.Close();
        }

    }
}
