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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(txtDecimal.Text);

            string bin = Convert.ToString(value, 2);

            txtOctal.Text = Convert.ToString(value, 8);
            string hex = Convert.ToString(value, 16);
            txtHex.Text = hex.ToUpper();
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
    }
}
