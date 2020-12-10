using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenDeLaBarreraIsrael
{
    public partial class FormPresupuestos : Form
    {
        private string[] codes;
        private string[] codePrices;
        private string[] monitorPrices = new string[] { "99", "75" };
        private string[] keyboardPrices = new string[] { "50", "65" };
        private string[] diskDrivePrices = new string[] { "15", "25", "35" };
        private string[] cdDrivesPrices = new string[] { "35", "45", "55" };

        public FormPresupuestos(string[] codes, string[] codePrices)
        {
            InitializeComponent();

            this.codes = codes;
            this.codePrices = codePrices;
            initializeFormData();
        }

        private void initializeFormData()
        {
            foreach(string key in codes)
            {
                if (key.Contains("MEM"))
                {
                    lbMemory.Items.Add(key);
                } else if (key.Contains("HDD"))
                {
                    lbHardDrive.Items.Add(key);
                } else if (key.Contains("PRO"))
                {
                    cbCpuType.Items.Add(key);
                } else if (key.Contains("IMP"))
                {
                    lbPrinter.Items.Add(key);
                } else if (key.Contains("SCN"))
                {
                    lbScanner.Items.Add(key);
                }
            }
        }

        private void cbCpuType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCpuPrice.Text = getPriceFromString(cbCpuType.SelectedItem.ToString());
        }

        private string getPriceFromString(string value)
        {
            string r = "";
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].Equals(value))
                {
                    r = codePrices[i];
                }
            }
            return r;
        }

        private void lbMemory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRamPrice.Text = getPriceFromString(lbMemory.SelectedItem.ToString());
        }

        private void lbHardDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHddPrice.Text = getPriceFromString(lbHardDrive.SelectedItem.ToString());
        }

        private void lbPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrinterPrice.Text = getPriceFromString(lbPrinter.SelectedItem.ToString());
        }

        private void lbScanner_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtScannerPrice.Text = getPriceFromString(lbScanner.SelectedItem.ToString());
        }

        private void chkDiskDrive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiskDrive.Checked)
            {
                gbDiskDrive.Enabled = true;
            } else
            {
                gbDiskDrive.Enabled = false;
                txtDiskDrivePrice.Text = "";
            }
        }

        private void chkCd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCd.Checked)
            {
                gbCdDrive.Enabled = true;
            }
            else
            {
                gbCdDrive.Enabled = false;
                txtCdDrivePrice.Text = "";
            }
        }

        private void chkPrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrinter.Checked)
            {
                lbPrinter.Enabled = true;
            }
            else
            {
                lbPrinter.Enabled = false;
                txtPrinterPrice.Text = "";
            }
        }

        private void chkScanner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScanner.Checked)
            {
                lbScanner.Enabled = true;
            }
            else
            {
                lbScanner.Enabled = false;
                txtScannerPrice.Text = "";
            }
        }

        private void gbCdDrive_Enter(object sender, EventArgs e)
        {
            if (rbnDiskDriveSpeed40.Checked)
            {
                txtCdDrivePrice.Text = cdDrivesPrices[0];
            }
            else if (rbnDiskDriveSpeed60.Checked)
            {
                txtCdDrivePrice.Text = cdDrivesPrices[1];
            }
            else if (rbnDiskDriveSpeed80.Checked)
            {
                txtCdDrivePrice.Text = cdDrivesPrices[2];
            }
        }

        private void gbDiskDrive_Enter(object sender, EventArgs e)
        {
            if (rbnDiskDrive1.Checked)
            {
                txtDiskDrivePrice.Text = diskDrivePrices[0];
            }
            else if (rbnDiskDrive2.Checked)
            {
                txtDiskDrivePrice.Text = diskDrivePrices[1];
            }
            else if (rbnDiskDrive3.Checked)
            {
                txtDiskDrivePrice.Text = diskDrivePrices[2];
            }

           
        }
    }
}
