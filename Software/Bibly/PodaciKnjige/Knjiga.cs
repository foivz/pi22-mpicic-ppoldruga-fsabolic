using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaciKnjige
{
    public class Knjiga
    {
        public string ISBN { get; set; }
        public string Naziv { get; set; }
        public Izdavac Izdavac { get; set; }
        public Zanr Zanr { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int BrojStranica { get; set; }
        public string Opis { get; set; }
        public string Naslovnica { get; set; }
        public List<Autor> ListaAutora { get; set; }

        public Knjiga()
        {
             
        }

        public Knjiga(string isbn, string naziv, Izdavac izdavac, Zanr zanr, DateTime datumIzdavanja, int brojStranica, string opis, string naslovnica, List<Autor> autori)
        {
            ISBN = isbn;
            Naziv = naziv;
            Izdavac = izdavac;
            Zanr = zanr;
            DatumIzdavanja = datumIzdavanja;
            BrojStranica = brojStranica;
            Opis = opis;
            Naslovnica = naslovnica;
            ListaAutora = autori;
        }
    }
}
