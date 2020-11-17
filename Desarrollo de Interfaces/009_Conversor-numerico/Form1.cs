using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_Conversor_numerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string formatBinary(string rawBinary)
        {
            string binSpaced = "";
            int charCount = 1;
            for (int i = 1; i < rawBinary.Length; i++, charCount++)
            {
                binSpaced += rawBinary.Substring(i, 1);
                if (charCount > 4)
                {
                    binSpaced += " ";
                    charCount = 0;
                }
            }
            return binSpaced;
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rbtnDecimal.Checked)
            {
                int value = Int32.Parse(txtDecimal.Text);

                string bin = Convert.ToString(value, 2);
                txtBinary.Text = formatBinary(bin);
                txtOctal.Text = Convert.ToString(value, 8);
                string hex = Convert.ToString(value, 16);
                txtHex.Text = hex.ToUpper();
            }
            if (rbtnBin.Checked)
            {
                Int64 value = Convert.ToInt64(txtBinary.Text, 2);

                txtDecimal.Text = Convert.ToString(value, 10);
                txtOctal.Text = Convert.ToString(value, 8);
                string hex = Convert.ToString(value, 16);
                txtHex.Text = hex.ToUpper();
            }
            if (rbtnOctal.Checked)
            {
                Int64 value = Convert.ToInt64(txtOctal.Text, 8);

                txtDecimal.Text = Convert.ToString(value, 10);
                string bin = Convert.ToString(value, 2);
                txtBinary.Text = formatBinary(bin);
                string hex = Convert.ToString(value, 16);
                txtHex.Text = hex.ToUpper();
            }
            if (rbtnHex.Checked)
            {
                Int64 value = Convert.ToInt64(txtHex.Text, 16);

                txtDecimal.Text = Convert.ToString(value, 10);
                string bin = Convert.ToString(value, 2);
                txtBinary.Text = formatBinary(bin);
                txtOctal.Text = Convert.ToString(value, 8);
            }
        }

        private string splitEachFourChar(string str)
        {
            string[] strArr = new string[str.Length / 4];

            for (int i = 0; i < str.Length; i += 4)
            {
                 str.Substring(i, 4);
            }

            return "";
        }

        private void rbtnDecimal_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimal.Enabled = true;
            txtBinary.Enabled = false;
            txtOctal.Enabled = false;
            txtHex.Enabled = false;
        }

        private void rbtnBin_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimal.Enabled = false;
            txtBinary.Enabled = true;
            txtOctal.Enabled = false;
            txtHex.Enabled = false;
        }

        private void rbtnOctal_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimal.Enabled = false;
            txtBinary.Enabled = false;
            txtOctal.Enabled = true;
            txtHex.Enabled = false;
        }

        private void rbtnHex_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimal.Enabled = false;
            txtBinary.Enabled = false;
            txtOctal.Enabled = false;
            txtHex.Enabled = true;
        }
    }
}
