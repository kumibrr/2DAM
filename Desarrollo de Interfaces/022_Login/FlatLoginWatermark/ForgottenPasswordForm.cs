using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatLoginWatermark
{
    public partial class ForgottenPasswordForm : Form
    {
        private SqlConnection connection;
        private SmtpClient smtpClient = new SmtpClient();
        public ForgottenPasswordForm(SqlConnection connection)
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

        private void ForgottenPasswordForm_Load(object sender, EventArgs e)
        {
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("*******@gmail.com", "*****************");
            smtpClient.EnableSsl = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String password = "";
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT TOP 1 CONTRA FROM Usuario WHERE EMAIL='{txtMail.Text}'", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    password = rd["CONTRA"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error.Noséqué.");
            }

            MailMessage message = new MailMessage
            {
                From = new MailAddress("*******@gmail.com"),
                Subject = "Recuperación de contraseña",
                Body = $"aaah tu contraseña es {password}",
                IsBodyHtml = false,
            };

            message.To.Add(txtMail.Text);
            smtpClient.Send(message);
            
            MessageBox.Show("Correo enviado, compruebe su bandeja de entrada.");
            this.Close();
        }
    }
}
