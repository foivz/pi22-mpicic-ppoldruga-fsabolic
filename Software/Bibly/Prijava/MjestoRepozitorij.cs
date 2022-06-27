using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;

namespace Prijava
{
    public static class MjestoRepozitorij
    {

        public static List<Mjesto> DohvatiSvaMjesta()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                   "SELECT * FROM mjesta ORDER BY naziv";


            List<Mjesto> mjesta = new List<Mjesto>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                mjesta.Add(new Mjesto(
                  int.Parse(reader["id_mjesto"].ToString()),
                  reader["naziv"].ToString()
                   ));


            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return mjesta;
        }
    }
}
