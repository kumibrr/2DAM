using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private Dictionary<String, Order> orders = new Dictionary<string, Order>();
        private SortedList ordersKeyList = new SortedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            readXMLFolder();
        }

        private void readXMLFolder()
        {
            string path = @"C:\XMLs";
            DirectoryInfo dir = new DirectoryInfo(path);
            
            // TODO: Guardar importaciones en local.

            foreach (FileInfo file in dir.GetFiles("*.xml"))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(file.FullName);
                    Order order = Order.ParseFromNode(doc);
                    orders.Add(order.ticket, order);
                    listImported.Items.Add(order.ticket);
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
                    } catch
                    {
                        MessageBox.Show("Error de escritura", "No se puede escribir en la carpeta de log");
                    }
                }
            }

            Console.WriteLine(orders);
            
            // Usar sortedset con lista
        }
    }
}
