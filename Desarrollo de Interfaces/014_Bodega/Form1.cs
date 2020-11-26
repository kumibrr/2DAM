﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_Bodega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NewCustomerForm cust = new NewCustomerForm();
            cust.setLabelText("Nuevo Cliente");
            cust.MdiParent = this;
            cust.WindowState = FormWindowState.Maximized;
            cust.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NewCustomerForm cust = new NewCustomerForm();
            cust.setLabelText("Realizar Pedido");
            cust.MdiParent = this;
            cust.WindowState = FormWindowState.Maximized;
            cust.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewCustomerForm cust = new NewCustomerForm();
            cust.setLabelText("Mostrar Pedidos");
            cust.MdiParent = this;
            cust.WindowState = FormWindowState.Maximized;
            cust.Show();
        }
    }
}
