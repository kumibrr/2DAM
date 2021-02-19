using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private Dictionary<String, Order> orders = new Dictionary<string, Order>();
        private SortedList ordersKeyList = new SortedList();
        private SqlConnection connection = new SqlConnection(@"Server=localhost;Database=OkiSpain; Integrated Security=true");
        private SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("**************@gmail.com", "**************"),
            EnableSsl = true
        };
        public Form1()
        {
            InitializeComponent();
            try
            {
                connection.Open();
            } catch
            {
                MessageBox.Show("No se ha podido conectar a la base de datos. Inténtelo de nuevo más tarde.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            readXMLFolder();
        }

        private void readXMLFolder()
        {
            string path = @"C:\XMLs";
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.CreateSubdirectory("cache");

            foreach (FileInfo file in dir.GetFiles("*.xml"))
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM importadosOki WHERE fichero='{file.Name}'", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                var canRead = true;
                while (rd.Read())
                {
                    if (rd.GetString(0) != "")
                    {
                        canRead = false;
                        Directory.Move(file.FullName, file.DirectoryName + @"\errores\" + file.Name);
                        try
                        {
                            using (StreamWriter sw = File.CreateText(file.DirectoryName + @"\errores\" + file.Name + " - ERRORLOG.txt"))
                            {
                                sw.WriteLine("El archivo ya ha sido importado anteriormente.");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error de escritura", "No se puede escribir en la carpeta de log");
                        }
                    }
                }
                rd.Close();
                if (canRead)
                {
                    try
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(file.FullName);
                        Order order = Order.ParseFromNode(doc);
                        orders.Add(order.ticket, order);
                        listImported.Items.Add(order.ticket);
                        SqlCommand command = new SqlCommand($"INSERT INTO importadosOki (fichero) VALUES ('{file.Name}')", connection);
                        command.ExecuteNonQuery();
                        makeOrder(order);
                        order.commitOrder(connection);
                        setMailFiles(order);
                        var today = DateTime.Today;
                        using (StreamWriter sw = File.AppendText(file.DirectoryName + @$"\cache\Proceso_{today.Day}{today.Month}{today.Year}.txt"))
                        {
                            sw.Write(file.Name + ": ORDER OK\n\n");
                        }
                        //Directory.Move(file.FullName, file.DirectoryName + @"\importado\" + file.Name);
                    }
                    catch (Exception e)
                    {
                        Directory.Move(file.FullName, file.DirectoryName + @"\errores\" + file.Name);
                        try
                        {
                            var today = DateTime.Today;
                            using (StreamWriter sw = File.AppendText(file.DirectoryName + @$"\cache\Proceso_{today.Day}{today.Month}{today.Year}.txt"))
                            {
                                sw.Write(file.Name + ": " + e.Message + "\n\n");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error de escritura", "No se puede escribir en la carpeta de log");
                        }
                    }
                }

            }
            sendMails();
            
        }

        private void makeOrder(Order order)
        {
            foreach (Article article in order.articles)
            {
                var stock = article.checkStock(connection);
                switch (stock) {
                    case 0:
                        article.reserveArticle(connection);
                        article.orderArticle(connection);
                        break;
                    default:
                        article.reserveArticle(connection);
                        break;
                }
            }
        }

        private void setMailFiles(Order order)
        {
            var today = DateTime.Today;
            DirectoryInfo dir = new DirectoryInfo(@"C:\XMLs\cache\");
            try
            {
                using (StreamWriter sw = File.AppendText(dir.FullName + $"{order.workCentre}_{today.Day}{today.Month}{today.Year}.txt"))
                {
                    sw.Write($"\nOrden {order.ticket}. Referencia de artículos: ");
                    foreach (Article article in order.articles)
                    {
                        sw.Write($"{article.id}, ");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error de escritura", "No se puede escribir en la carpeta de log");
            }
        }

        private void sendMails()
        {
            foreach (string filepath in Directory.GetFiles(@"C:\XMLs\cache"))
            {
                MailMessage message = new MailMessage();
                message.To.Add("**************@gmail.com");
                message.Attachments.Add(new Attachment(filepath));
                message.From = new MailAddress("**************@gmail.com");
                
                if (filepath.Contains("Proceso"))
                {
                    message.Subject = "ISRAEL - Pedidos Procesados.";
                } else
                {
                    message.Subject = "ISRAEL - Pedidos enviados y a realizar";
                }

                smtpClient.Send(message);
            }
        }

    }
}
