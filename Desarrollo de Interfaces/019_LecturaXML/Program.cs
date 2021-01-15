using System;
using System.Xml;

namespace _019_LecturaXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"C:\Users\User\Downloads\empleados.xml");

            XmlNodeList empleados = xmldoc.GetElementsByTagName("empleado");

            foreach (XmlNode empleado in empleados)
            {
                Console.WriteLine(empleado.SelectSingleNode("nombre").InnerText);
            }
        }
    }
}
