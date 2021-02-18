using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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

                        //Directory.Move(file.FullName, file.DirectoryName + @"\importado\" + file.Name);
                    }
                    catch (Exception e)
                    {
                        Directory.Move(file.FullName, file.DirectoryName + @"\errores\" + file.Name);
                        try
                        {
                            using (StreamWriter sw = File.CreateText(file.DirectoryName + @"\errores\" + file.Name + " - ERRORLOG.txt"))
                            {
                                sw.WriteLine(e.Message + "\n");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error de escritura", "No se puede escribir en la carpeta de log");
                        }
                    }
                }

            }
            
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
    }
}
