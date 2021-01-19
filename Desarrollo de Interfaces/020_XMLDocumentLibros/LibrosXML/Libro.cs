using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibrosXML
{
    class Libro
    {
        public string genre;
        public string publicationDate;
        public string isbn;
        public string title;
        public Author author;
        public double price;

        private Libro(string genre, string publicationDate, string isbn, string title, Author author, double price)
        {
            this.genre = genre;
            this.publicationDate = publicationDate;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public static Libro ParseFromXML(XmlNode rawLibro)
        {
            XmlAttributeCollection attributes =  rawLibro.Attributes;
            string genre = attributes.GetNamedItem("genero").Value;
            string publicationDate = attributes.GetNamedItem("fechadepublicacion").Value;
            string isbn = attributes.GetNamedItem("ISBN").Value;
            string title = rawLibro.ChildNodes[0].InnerText;
            Author author = new Author(rawLibro.ChildNodes[1].FirstChild.InnerText, rawLibro.ChildNodes[1].LastChild.InnerText);
            double price = Double.Parse(rawLibro.ChildNodes[2].InnerText);

            return new Libro(genre, publicationDate, isbn, title, author, price);
        }

        public void PushToXML(XmlDocument docxml, int index = -1)
        {

            XmlNode libro = docxml.CreateElement("libro");
            XmlAttribute genre = docxml.CreateAttribute("genero");
            XmlAttribute publicationDate = docxml.CreateAttribute("fechadepublicacion");
            XmlAttribute isbn = docxml.CreateAttribute("ISBN");
            XmlNode title = docxml.CreateElement("title");
            XmlNode author = docxml.CreateElement("autor");
            XmlNode name = docxml.CreateElement("nombre");
            XmlNode lastname = docxml.CreateElement("apellido");
            XmlNode price = docxml.CreateElement("precio");

            genre.Value = this.genre;
            publicationDate.Value = this.publicationDate;
            isbn.Value = this.isbn;
            title.InnerText = this.title;
            name.InnerText = this.author.name;
            lastname.InnerText = this.author.lastName;
            price.InnerText = this.price.ToString();

            author.AppendChild(name);
            author.AppendChild(lastname);
            libro.AppendChild(title);
            libro.AppendChild(author);
            libro.AppendChild(price);
            libro.Attributes.Append(genre);
            libro.Attributes.Append(publicationDate);
            libro.Attributes.Append(isbn);

            XmlNodeList nodes = docxml.GetElementsByTagName("libro");
            nodes[index].ParentNode.ReplaceChild(libro, nodes[index]);
            docxml.Save(@"libros.xml");
        }

        public string toString()
        {
            string str = $"" +
                $"Género: {genre}," +
                $"Año de publicación: {publicationDate}," +
                $"ISBN: {isbn}," +
                $"Título: {title}," +
                $"Autor: {author.name} {author.lastName}" +
                $"Precio: {price}";
            return str;
        }
    }

}
