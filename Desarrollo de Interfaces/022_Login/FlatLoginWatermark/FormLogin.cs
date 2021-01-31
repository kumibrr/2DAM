using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace FlatLoginWatermark
{
    public partial class FormLogin : Form
    {
        private SqlConnection connection;
        public FormLogin()
        {
            setConnection();
            InitializeComponent();
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

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Email")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Email";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion
        private async void setConnection()
        {
            try
            {
                this.connection = new SqlConnection(@"Server=DESKTOP-99GH4P6;Database=BDPasaje;Integrated Security=true;");
                await connection.OpenAsync();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String[] userData = new String[9];
            String email = txtuser.Text;
            String password = txtpass.Text;

            SqlCommand query = new SqlCommand($"SELECT * From Usuario WHERE '{email}' = EMAIL and '{password}' = CONTRA", connection);
            SqlDataReader data = query.ExecuteReader();

            int i = 0;
            while (data.Read())
            {
                i++;
                for (int j = 0; j < 9; j++)
                {
                    userData[j] = (String)data[j].ToString();
                }

            }
            if (i > 1 || i == 0)
            {
                picError.Visible = true;
                lblError.Visible = true;
            } else
            {
                LoggedInForm loggedInForm = new LoggedInForm(userData);
                loggedInForm.Show();
            }
            data.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm form = new CreateAccountForm(connection);
            form.Show();
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgottenPasswordForm form = new ForgottenPasswordForm(connection);
            form.Show();
        }
    }
}
