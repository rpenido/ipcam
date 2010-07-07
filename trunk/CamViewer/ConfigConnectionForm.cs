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
        ConnectionConfigData configData;

        public ConfigConnectionForm()
        {
            InitializeComponent();
            configData = ConnectionConfigData.Get();
            edtAddress.Text = configData.Address;
            edtUsername.Text = configData.UserName;
            edtPassword.Text = configData.Password;
            chk640.Checked = configData.HighResolution;
        }

        private void configConnection_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            configData.Address = edtAddress.Text;
            configData.UserName = edtUsername.Text;
            configData.Password = edtPassword.Text;
            configData.HighResolution = chk640.Checked;
            configData.Save();
        }
    }
}
