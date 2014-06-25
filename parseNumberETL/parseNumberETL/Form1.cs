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
        List<decimal> dataset = new List<decimal>();
        static iFileIO ifs;
        static iMath ims;
        public Form1()
        {

            InitializeComponent();
            ifs = new FileIO();
            ims = new MathFunction();
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
                if (ifs.CheckExist(filePath))
                {
                    dataset = ifs.ReadAllNumber(filePath);
                    MessageBox.Show("File loaded");
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }

            }
            else
            {
                fileIsOpen = false;
            }
        }

        private void bt_mean_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mean is"+ims.GetMean(dataset));
        }

        private void bt_sd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SD is "+ ims.GetStandDeviation(dataset));
        }

        private void bt_distribution_Click(object sender, EventArgs e)
        {
            StringBuilder outputDistribution = new StringBuilder();
            List<int> distributions = ims.GetDistributionOfBinTen(dataset);
            for (int i = 1,k=0; i < distributions.ToArray().Length; i++,k++)
            {
                outputDistribution.Append("The number between " + k * 10 + " and " + (k + 1) * 10 + " is " + distributions.ToArray()[i]+"\n");
            }
                MessageBox.Show(outputDistribution.ToString());
        }
    }
}
