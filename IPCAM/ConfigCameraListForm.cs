using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CamViewer
{

    public partial class ConfigCameraListForm : Form
    {
        private ConnectionConfigDataList list;
        public ConfigCameraListForm()
        {
            InitializeComponent();
            list = ConnectionConfigDataList.Get();

            for (int i = 0; i < list.Count; i++ )
            {
                listView1.Items.Add("Câmera " + i.ToString());
            }
            
        }

       private void btnAddCam_Click(object sender, EventArgs e)
        {
            ConfigConnectionForm form = new ConfigConnectionForm(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                list.Add(form.ConfigData);
                
            }
        }

       private void btnEdit_Click(object sender, EventArgs e)
       {
           if (listView1.SelectedIndices.Count != 1)
           {
               MessageBox.Show("Selecione uma câmera");
               return;
           }

           int selectedIndex = listView1.SelectedIndices[0];
           ConnectionConfigData conf = list[selectedIndex];
           ConfigConnectionForm form = new ConfigConnectionForm(conf);
           form.ShowDialog();
       }

       
    }
}
