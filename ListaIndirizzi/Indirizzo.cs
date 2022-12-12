using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
     class Indirizzo
    {
        string name;
        string surname;
        string street;
        string city;
        string province;
        string zip;
        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }
        public void stampaIndirizzo() {
        Console.WriteLine("nome: " + this.name );
            Console.WriteLine("surname: " + this.surname);
            Console.WriteLine("street: " + this.street);
            Console.WriteLine("city: " + this.city);
            Console.WriteLine("province: " + this.province);
            Console.WriteLine("zip: " + this.zip);


        }

    }

}
