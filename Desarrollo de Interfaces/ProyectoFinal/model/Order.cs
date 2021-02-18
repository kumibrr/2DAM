using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProyectoFinal
{
    class Order
    {
        public string ticket;
        public Customer customer;
        public string workCentre;
        public DateTime orderDate;
        public Location locationToSend;
        public string serialNumber;
        public ArrayList articles = new ArrayList();

        private Order(string ticket, Customer customer, string workCentre, DateTime orderDate, Location locationToSend, string serialNumber, ArrayList articles)
        {
            this.ticket = ticket;
            this.customer = customer;
            this.workCentre = workCentre;
            this.orderDate = orderDate;
            this.locationToSend = locationToSend;
            this.serialNumber = serialNumber;
            this.articles = articles;
        }

        public static Order ParseFromNode(XmlDocument document)
        {
            string ticket;
            DateTime orderDate;
            Customer customer;
            Location location;
            string serialNumber;
            string workCentre;
            ArrayList articles = new ArrayList();

            XmlNode root = document.SelectSingleNode("/OkiXMLService/OkiSI/EscalationTPM");
            ticket = root.SelectSingleNode("TicketID").InnerText;
            workCentre = root.SelectSingleNode("OkiServiceFees/WorkC_Work_Center").InnerText;
            serialNumber = root.SelectSingleNode("OkiEquipmentData/Warranty_Serialnumber").InnerText;

            if (ticket == "" || workCentre == "" || serialNumber == "")
            {
                throw new ArgumentNullException("No hay suficiente información de la orden.");
            }

            orderDate = DateTime.Parse(root.SelectSingleNode("Case_Registration_Date").InnerText);

            XmlNode contactNode = root.SelectSingleNode("OkiAddressData/OkiContact");
            customer = new Customer
            (
                contactNode.SelectSingleNode("Cont_Firstname").InnerText,
                contactNode.SelectSingleNode("Cont_Lastname").InnerText,
                contactNode.SelectSingleNode("Cont_Phone").InnerText,
                contactNode.SelectSingleNode("Cont_Handy").InnerText,
                contactNode.SelectSingleNode("Cont_eMail").InnerText
            );

            if (customer.phone == "" && customer.cellphone == "" && customer.email == "")
            {
                throw new ArgumentNullException("No hay suficiente información del contacto.");
            }

            XmlNode locationNode = root.SelectSingleNode("OkiAddressData/OkiLocation");
            location = new Location
            (
                locationNode.SelectSingleNode("Loc_Company1").InnerText,
                locationNode.SelectSingleNode("Loc_Street").InnerText,
                locationNode.SelectSingleNode("Loc_City").InnerText,
                locationNode.SelectSingleNode("Loc_Post_code").InnerText,
                locationNode.SelectSingleNode("Loc_Country").InnerText
            );

            if (location.street == "" || location.postCode == "" && location.city == "")
            {
                throw new ArgumentNullException("La dirección está incompleta.");
            }

            XmlNodeList articlesNode = root.SelectNodes("OkiWarrantyExchange/SparePart");

            foreach (XmlNode articleNode in articlesNode)
            {
                Article article = new Article
                    (
                        articleNode.SelectSingleNode("ArticleNumber").InnerText,
                        articleNode.SelectSingleNode("ArticleDescription").InnerText,
                        Int32.Parse(articleNode.SelectSingleNode("Suggested_Qty").InnerText)
                    );

                if (article.id == "" && article.quantity == 0)
                {
                    throw new ArgumentNullException("No hay cantidad definida para el recambio pedido.");
                }

                articles.Add(article);
            }

            if (articles.Count == 0)
            {
                throw new ArgumentNullException("No hay ningún artículo en el archivo de pedido.");
            }
            

            return new Order(ticket, customer, workCentre, orderDate, location, serialNumber, articles);
        }

        private void commitOrder(SqlConnection connection)
        {
            // TODO: INSERT INTO pedido_suministros_cabecera and pedidos_suministros_detalle
        }
    }
}
