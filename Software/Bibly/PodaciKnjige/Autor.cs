using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaciKnjige
{
    public class Autor
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Biografija { get; set; }

        public Autor(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
