using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;
using System.Data;

namespace PodaciKnjige
{
    public class IzdavacRepozitorij
    {
        public static List<Izdavac> DohvatiSveIzdavace()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT * FROM izdavaci";

            List<Izdavac> izdavaci = new List<Izdavac>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                izdavaci.Add(new Izdavac(
                    int.Parse(reader["id_izdavac"].ToString()),
                   reader["naziv"].ToString()

                   ));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return izdavaci;
        }

        public static int DodajIzdavaca(Izdavac izdavac)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"INSERT INTO izdavaci VALUES('{izdavac.Naziv}')";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
        public static int AzurirajIzdavaca(Izdavac izdavac)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"UPDATE izdavaci SET naziv='{izdavac.Naziv}' WHERE id_izdavac={izdavac.Id}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int ObrisiIzdavaca(Izdavac izdavac)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"DELETE FROM izdavaci WHERE id_izdavac={izdavac.Id}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }


    }
}
