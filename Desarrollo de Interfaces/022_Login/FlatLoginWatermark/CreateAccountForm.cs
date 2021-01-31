using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatLoginWatermark
{
    public partial class CreateAccountForm : Form
    {
        private SqlConnection connection;
        public CreateAccountForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand($"INSERT INTO Usuario (NOMBREUSUARIO, CONTRA, NOMBREC, EMAIL) VALUES ('{textBox1.Text}', '{textBox3.Text}', '{textBox5.Text}', '{textBox2.Text}')", connection);
            int r = query.ExecuteNonQuery();
            
            switch (r)
            {
                case 0:
                    MessageBox.Show("No se ha creado el usuario");
                    break;
                case 1:
                    MessageBox.Show("Usuario creado satisfactoriamente.");
                    break;
            }
            this.Close();
        }
    }
}
