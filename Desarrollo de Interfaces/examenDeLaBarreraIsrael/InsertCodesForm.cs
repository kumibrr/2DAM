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
    public partial class InsertCodesForm : Form
    {
        public InsertCodesForm(string[] codes, string[] codesPrices)
        {
            InitializeComponent();
            listBox1.Items.AddRange(codes);
            this.codes = codes;
            this.codesPrices = codesPrices;
        }

        private string[] codes;
        private string[] codesPrices;
        private string[] validStrCodes = new string[] {"MEM", "HDD", "PRO", "IMP", "SCN"};

        private void updateList(string[] codes)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(codes);
        }

        private bool isRefValid()
        {
            bool r = true;
            string val = textBox1.Text;
            if (val.Length > 6)
            {
                r = false;
            } else
            {
                string chars = val.Substring(0, 3);
                string num = val.Substring(3, 3);
                short parsedNumber;

                if (Int16.TryParse(num, out parsedNumber) == false)
                {
                    r = false;
                } else
                {
                    int oc = 0;
                    foreach (string str in validStrCodes)
                    {
                        if (chars.Equals(str))
                        {
                            oc++;
                        }
                        if (oc < 1)
                        {
                            r = false;
                        }
                    }
                }
            }
            return r;
        }

        private bool isPriceValid()
        {
            bool r = true;
            short parsedNumber;
            if (Int16.TryParse(textBox2.Text, out parsedNumber) == false)
            {
                r = false;
            }
            return r;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isPriceValid() == true && isRefValid() == true)
            {
                string[] newCodes = new string[codes.Length + 1];
                string[] newCodesPrices = new string[codesPrices.Length + 1];
                for (int i = 0; i < codes.Length; i++)
                {
                    newCodes[i] = codes[i];
                    newCodesPrices[i] = codesPrices[i]; 
                }
                newCodes[codes.Length] = textBox1.Text;
                newCodesPrices[codesPrices.Length] = textBox2.Text;
                codes = newCodes;
                codesPrices = newCodesPrices;
                updateList(codes);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int sIndex = listBox1.SelectedIndex;

                string[] newCodes = new string[codes.Length - 1];

                for (int i = 0, j = 0; i < codes.Length; i++, j++)
                {
                    if (i != sIndex)
                    {
                        newCodes[j] = codes[i];
                    }
                    else
                    {
                        j--;
                    }

                }
                codes = newCodes;
                updateList(newCodes);
            }
        }
    }
}
