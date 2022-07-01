using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;
using System.Data;
namespace PodaciKnjige
{
    public static class AutorKnjigeRepozitorij
    {
        public static List<AutorKnjige> DohvatiSveAutorKnjige()
        {
            List<AutorKnjige> autoriKnjige = new List<AutorKnjige>();
            foreach(Knjiga k in KnjigaRepozitorij.DohvatiSveKnjige())
            {
                foreach(Autor a in AutorRepozitorij.DohvatiAutoreKnjige(k.ISBN))
                {
                    autoriKnjige.Add(new AutorKnjige(a,k));
                }
            }
            return autoriKnjige;
        }

        public static int DodajAutoraKnjige(AutorKnjige autorKnjige)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"INSERT INTO autor_knjige VALUES({autorKnjige.Autor.Id},'{autorKnjige.Knjiga.ISBN}')";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();
            return uspjeh;
        }
        public static int AzurirajAutoraKnjige(int stariID,string stariISBN,AutorKnjige autorKnjige)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"UPDATE autor_knjige SET id_autor = {autorKnjige.Autor.Id}, ISBN = '{autorKnjige.Knjiga.ISBN}' WHERE id_autor={stariID} AND ISBN='{stariISBN}'";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();
            return uspjeh;
        }

        public static int ObrisiAutoraKnjige(AutorKnjige autorKnjige)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"DELETE FROM autor_knjige WHERE id_autor={autorKnjige.Autor.Id} AND ISBN='{autorKnjige.Knjiga.ISBN}'";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();
            return uspjeh;
        }
    }
}
