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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private string[] codes = new string[] { "MEM400", "MEM200", "MEM100", "HDD100", "HDD002", "HDD003", "PRO125", "PRO348", "PRO100", "IMP386", "IMP678", "IMP567", "SCN448", "SCN586", "SCN689" };
        private string[] codesPrices = new string[] { "48", "37", "56", "120", "236", "180", "315", "410", "285", "95", "150", "180", "355", "275", "411" };

        private void mbtnAbout_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox1();
            about.ShowDialog();
        }

        private void exitApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnCode_Click(object sender, EventArgs e)
        {
            Form insCodes = new InsertCodesForm(codes, codesPrices);
            insCodes.MdiParent = this;
            insCodes.WindowState = FormWindowState.Maximized;
            insCodes.Show();
        }

        private void Presupuesto_Click(object sender, EventArgs e)
        {
            Form presupuesto = new FormPresupuestos(codes, codesPrices);
            presupuesto.MdiParent = this;
            presupuesto.WindowState = FormWindowState.Maximized;
            presupuesto.Show();
        }
    }
}
