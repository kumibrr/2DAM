using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_Insercion
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();

            try
            {
                connection = new SqlConnection(@"Server=DESKTOP-99GH4P6;Database=BDPasaje;Integrated Security=true");
                connection.Open();
            } catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                try
                {
                    SqlCommand query = new SqlCommand();
                    query.CommandText = $"INSERT INTO Marca(NOMBRE, DESCRIPCION, BHABILITADO) VALUES ('{textBox1.Text}', '{textBox2.Text}', '1')";
                    query.Connection = connection;
                    query.ExecuteNonQuery();
                    MessageBox.Show("La marca se ha insertado satisfactoriamente", "Query OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (SqlException er)
                {
                    MessageBox.Show(er.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Los campos deben tener texto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
