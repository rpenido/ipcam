using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CamViewer
{
    public partial class ConfigConnectionForm : Form
    {
        public ConnectionConfigData ConfigData;

        public ConfigConnectionForm(ConnectionConfigData conf)
        {
            InitializeComponent();
            if (conf == null) // New
            {
                ConfigData = new ConnectionConfigData();
            }
            else // Edit
            {
                ConfigData = conf;
            }
            
            edtAddress.Text = ConfigData.Address;
            edtUsername.Text = ConfigData.UserName;
            edtPassword.Text = ConfigData.Password;
            
        }


        private void btnOk_Click(object sender, EventArgs e)
        {                        
            ConfigData.Address =  edtAddress.Text;
            ConfigData.UserName = edtUsername.Text;
            ConfigData.Password = edtPassword.Text;
        }

        private void edtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "C:\\Windows\\system32\\rundll32.exe";
            p.StartInfo.Arguments = "xvidvfw.dll,Configure";
            p.Start();





        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
