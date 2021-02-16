using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            readOrderXML(@"C:\XMLs\X401006348340800140121.xml");
        }

        private void readOrderXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNode root = doc.SelectSingleNode("/OkiXMLService/OkiSI/EscalationTPM");
            String ticket = root.SelectSingleNode("TicketID").InnerText;
            listImported.Items.Add(ticket);
            // Usar sortedset con lista
        }
    }
}
