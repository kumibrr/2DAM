using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_imc
{
    public partial class Form1 : Form
    {
        private double height = 1;
        private double weight = 1;
        private double imc = 0;
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string filePath = Path.Combine(projectPath, "Resources");

        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e5dece");
        }

        private void updateIMC()
        {
            if(height != 0)
            {
                imc = weight / (height / 100 * 2);
            }

            txtIMC.Text = imc.ToString();

            if (imc < 18.5)
            {
                pictureBox1.Image = Image.FromFile(filePath + "\\PesoBajo.jpg");
            } else if (imc < 25)
            {
                pictureBox1.Image = Image.FromFile(filePath + "\\PesoIdeal.jpg");
            } else if (imc < 30)
            {
                pictureBox1.Image = Image.FromFile(filePath + "\\Sobrepeso.jpg");
            } else if (imc < 35)
            {
                pictureBox1.Image = Image.FromFile(filePath + "\\Obeso.jpg");
            } else if (imc < 40)
            {
                pictureBox1.Image = Image.FromFile(filePath + "\\ObesidadSevera.jpg");
            } else
            {
                pictureBox1.Image = Image.FromFile(filePath + "\\ObesidadMorbida.jpg");
            }
        }

        private void tbHeight_Scroll(object sender, EventArgs e)
        {
            height = tbHeight.Value;
            txtHeight.Text = tbHeight.Value.ToString();
            updateIMC();
        }

        private void sbWeight_Scroll(object sender, ScrollEventArgs e)
        {
            weight = sbWeight.Maximum - sbWeight.Value;
            txtWeight.Text = weight.ToString();
            updateIMC();
        }
    }
}
