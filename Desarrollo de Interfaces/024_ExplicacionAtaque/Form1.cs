using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesoConectado
{
  public partial class Form1 : Form
  {
    private SqlConnection ConexionConBD = null;
    private SqlCommand OrdenSql;
    private SqlDataReader Lector;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
            // Crear la cadena de conexión
            ConexionConBD = new SqlConnection(@"Server=DESKTOP-99GH4P6;Database=bd_telefonos; Integrated Security=true;");
            ConexionConBD.Open();
    }

    private void BtMostrarDatos_Click(object sender, EventArgs e)
    {

        OrdenSql = new SqlCommand($"SELECT nombre FROM telefonos WHERE telefono = {ctSql.Text}", ConexionConBD);
        Lector = OrdenSql.ExecuteReader();
        while (Lector.Read())
        {
            lsTfnos.Items.Add(Lector[0]);
        }
        Lector.Close();
    }
  }
}
