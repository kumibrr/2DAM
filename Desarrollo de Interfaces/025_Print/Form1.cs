using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025_Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument p = new PrintDocument();
            Font miFuente = new Font("Arial", 16, FontStyle.Bold);

            printDialog1.Document = p;
            printDialog1.ShowDialog();
        }
    }
}
