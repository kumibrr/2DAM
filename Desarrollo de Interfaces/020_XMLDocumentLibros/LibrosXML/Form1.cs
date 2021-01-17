﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LibrosXML
{
    public partial class Form1 : Form
    {
        //creación del documento xml vacío
        private XmlDocument docxml = new XmlDocument();
        private Libro[] libros;
        private string[] librosTitles;

        public Form1()
        {
            InitializeComponent();
            docxml.Load(@"libros.xml");
            XmlNodeList nodes = docxml.GetElementsByTagName("libro");
            libros = new Libro[nodes.Count];
            librosTitles = new string[nodes.Count];

            int i = 0;
            foreach (XmlNode node in nodes)
            {
                libros[i] = Libro.ParseFromXML(node);
                librosTitles[i] = libros[i].title;
                i++;
            }

            listBox1.Items.AddRange(librosTitles);
            listBox1.SelectedIndex = 0;
            fillLibroToUI(libros[listBox1.SelectedIndex]);
        }

        private void fillLibroToUI(Libro libro)
        {
            textBox1.Text = libro.genre;
            textBox2.Text = libro.publicationDate;
            textBox3.Text = libro.isbn;
            textBox4.Text = libro.title;
            textBox5.Text = libro.author.name;
            textBox6.Text = libro.author.lastName;
            textBox7.Text = libro.price.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLibroToUI(libros[listBox1.SelectedIndex]);
        }
    }
}
