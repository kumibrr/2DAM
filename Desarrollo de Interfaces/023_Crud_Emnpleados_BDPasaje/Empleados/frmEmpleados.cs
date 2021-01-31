using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empleado
{
    public partial class frmEmpleados : Form
    {
        private int SelectedID = 0;
        SqlConnection connection;
        private List<Empleado> empleados;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                string cadenaDeConexion = @"Server=DESKTOP-99GH4P6;Database=BDPasaje; Integrated Security=true;";
                connection = new SqlConnection(cadenaDeConexion);
                connection.Open();
                getAllEmpleados();
                EmpleadoToView(empleados[SelectedID]);
                MessageBox.Show("Conexion exitosa a SQL Server");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problema al tratar de conectar a BD. Detalles:" + ex);
            }
        }

        private void getAllEmpleados()
        {
            empleados = new List<Empleado>();
            SqlCommand query = new SqlCommand("SELECT * FROM Empleado;", connection);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                empleados.Add(parseEmpleado(reader));
            }
            reader.Close();
        }

        private void EmpleadoToView(Empleado empleado)
        {
            lblCodigo.Text = empleado.id.ToString();
            txtNombre.Text = empleado.name;
            txtPaterno.Text = empleado.appPaterno;
            txtMaterno.Text = empleado.appMaterno;
            txtSueldo.Text = empleado.sueldo.ToString();
            cmbSexo.SelectedIndex = empleado.idSexo - 1;
        }

        private Empleado parseEmpleado(SqlDataReader reader)
        {
            int id = Int32.Parse(reader[0].ToString());
            string nombre = reader[1].ToString();
            string appPaterno = reader[2].ToString();
            string appMaterno = reader[3].ToString();
            string fechaContrato = reader[4].ToString();
            double sueldo = Double.Parse(reader[5].ToString());
            int idTipoUsuario = Int32.Parse(reader[6].ToString());
            int idTipoContrato = Int32.Parse(reader[7].ToString());
            int idTipoSexo = Int32.Parse(reader[8].ToString());
            int bHabilitado = Int32.Parse(reader[9].ToString());
            int bTieneUsuario = 0;
            string tipoUsuario = reader[11].ToString();
            return new Empleado(id, nombre, appPaterno, appMaterno, fechaContrato, sueldo, idTipoUsuario, idTipoContrato, idTipoSexo, bHabilitado, bTieneUsuario, tipoUsuario);
        }

        private String[] parseFromView()
        {
            String[] r = new string[11];
            r[0] = txtNombre.Text;
            r[1] = txtPaterno.Text;
            r[2] = txtMaterno.Text;
            r[3] = "2014-12-15 00:00:00.000";
            r[4] = txtSueldo.Text;
            r[5] = "1";
            r[6] = "1";
            r[7] = (cmbSexo.SelectedIndex + 1).ToString();
            r[8] = "1";
            r[9] = "1";
            r[10] = "E";
            return r;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (SelectedID == 0)
            {
                SelectedID = empleados.Count - 1;
            } else
            {
                SelectedID--;
            }
            EmpleadoToView(empleados[SelectedID]);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (SelectedID == empleados.Count - 1)
            {
                SelectedID = 0;
            } else
            {
                SelectedID++;
            }
            EmpleadoToView(empleados[SelectedID]);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string[] emp = parseFromView();

            SqlCommand query = new SqlCommand();
            query.Connection = connection;
            query.CommandText = $"INSERT INTO Empleado (NOMBRE, APPATERNO, APMATERNO, FECHACONTRATO, SUELDO, IIDTIPOUSUARIO, IIDTIPOCONTRATO, IIDSEXO, BHABILITADO, bTieneUsuario, TIPOUSUARIO) VALUES ('{emp[0]}', '{emp[1]}', '{emp[2]}', CONVERT(date, '13-02-2014', 105), '{emp[4]}', '{emp[5]}', '{emp[6]}', '{emp[7]}', '{emp[8]}', '{emp[9]}', '{emp[10]}')";
            int result = query.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Usuario insertado correctamente.");
            } else
            {
                MessageBox.Show("El usuario no se ha podido insertar.");
            }
            getAllEmpleados();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Empleado emp = empleados[SelectedID];
            SqlCommand query = new SqlCommand($"DELETE FROM Empleado WHERE IIDEMPLEADO = {emp.id}", connection);
            int result = query.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Empleado eliminado satisfactoriamente.");
            } else
            {
                MessageBox.Show("El empleado no se ha podido eliminar.");
            }
            getAllEmpleados();
            btnAnterior.PerformClick();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] emp = parseFromView();
            Empleado empleado = empleados[SelectedID];

            SqlCommand query = new SqlCommand();
            query.Connection = connection;
            query.CommandText = $"UPDATE Empleado SET NOMBRE = '{emp[0]}', APPATERNO = '{emp[1]}', APMATERNO = '{emp[2]}', SUELDO = '{emp[4]}', IIDTIPOUSUARIO = '{emp[5]}', IIDTIPOCONTRATO = '{emp[6]}', IIDSEXO = '{emp[7]}', BHABILITADO = '{emp[8]}', bTieneUsuario = '{emp[9]}', TIPOUSUARIO = '{emp[10]}' WHERE IIDEMPLEADO = '{empleado.id}'";
            int result = query.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Los datos del usuario no se ha podido actualizar.");
            }
            getAllEmpleados();
        }
    }
}
