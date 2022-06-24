using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Baza;

namespace Postavke
{
    public static class PostavkeRepozitorij
    {
        public static int VratiTrajanjeRezervacije()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT trajanje_rezervacije" +
                    " FROM postavke";

            List<int> trajanjeRezervacije = new List<int>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                trajanjeRezervacije.Add(int.Parse(reader["trajanje_rezervacije"].ToString()));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return trajanjeRezervacije[0];
        }
    }
}
