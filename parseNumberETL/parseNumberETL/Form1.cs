using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parseNumberETL
{
    public partial class Form1 : Form
    {
        static bool fileIsOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_opencsv_Click(object sender, EventArgs e)
        {
            DialogResult dr=
            ofd_opencsv.ShowDialog();
            
            string filePath = ofd_opencsv.FileName;
            if (!filePath.Equals("")&&dr.Equals(DialogResult.OK))
            {
                fileIsOpen = true;
                bt_distribution.Enabled = true;
                bt_mean.Enabled = true;
                bt_sd.Enabled = true;
            }
            else
            {
                fileIsOpen = false;
            }
        }

        private void bt_mean_Click(object sender, EventArgs e)
        {
            MessageBox.Show((fileIsOpen==true?"Yes":"No"));
        }

        private void bt_sd_Click(object sender, EventArgs e)
        {
            MessageBox.Show((fileIsOpen == true ? "Yes" : "No"));
        }

        private void bt_distribution_Click(object sender, EventArgs e)
        {
            MessageBox.Show((fileIsOpen == true ? "Yes" : "No"));
        }
    }
}
