using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_Premio_planeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            object[] years = { 2015, 2016, 2017, 2018, 2019, 2020 };
            cmbYear.Items.AddRange(years);
            cmbYear.SelectedIndex = years.Length - 1;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
