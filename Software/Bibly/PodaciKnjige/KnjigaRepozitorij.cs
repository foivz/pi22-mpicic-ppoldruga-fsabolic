using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;

namespace PodaciKnjige
{
    public class KnjigaRepozitorij
    {
        public List<Knjiga> DohvatiSveKnjige()
        {
            List<Knjiga> knjiga = new List<Knjiga>();
            return knjiga;
        }
        public List<Knjiga> DohvatiNajcitanijeKnjige()
        {
            List<Knjiga> knjiga = new List<Knjiga>();
            return knjiga;
        }
        public int DodajKnjigu(Knjiga dodanaKnjiga)
        {
            return 0;
        }
        public int ObrisiKnjigu(Knjiga dodanaKnjiga)
        {
            return 0;
        }
        public int AzurirajKnjigu(Knjiga dodanaKnjiga)
        {
            return 0;
        }
        public List<Knjiga> DohvatiKnjiguPoKriteriju()
        {
            List<Knjiga> knjiga = new List<Knjiga>();
            return knjiga;
        }
    }
}
