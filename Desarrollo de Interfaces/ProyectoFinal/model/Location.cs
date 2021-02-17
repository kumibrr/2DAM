using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Location
    {
        public string name;
        public string street;
        public string city;
        public string postCode;
        public Country country;
        

        public Location(string name, string street, string city, string postCode, string country)
        {
            this.name = name;
            this.street = street;
            this.city = city;
            this.postCode = postCode;
            switch (country)
            {
                case "ES":
                    this.country = Country.ES;
                    break;
                default:
                    this.country = Country.PT;
                    break;
            }
        }
        
    }
    public enum Country
    {
        ES, PT
    };
}
