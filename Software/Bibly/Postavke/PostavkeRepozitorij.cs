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
        public static int DohvatiTrajanjeRezervacije()
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
        public static int DohvatiTrajanjePosudbe()
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
        public static int DohvatiMaksimalanBrojMogucihPosudbi()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT max_broj_posudbi" +
                    " FROM postavke";

            List<int> maxBrojPosudbi = new List<int>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                maxBrojPosudbi.Add(int.Parse(reader["max_broj_posudbi"].ToString()));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return maxBrojPosudbi[0];
        }
        public static int DohvatiMaksimalanBrojProduljivanjaPosudbe()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT trajanje_produljenja" +
                    " FROM postavke";

            List<int> maxBrojProduljenja = new List<int>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                maxBrojProduljenja.Add(int.Parse(reader["trajanje_produljenja"].ToString()));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return maxBrojProduljenja[0];
        }
        public static double DohvatiIznosZakasnine()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT zakasnina" +
                    " FROM postavke";

            List<double> maxBrojProduljenja = new List<double>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                maxBrojProduljenja.Add(double.Parse(reader["zakasnina"].ToString()));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return maxBrojProduljenja[0];
        }
    }
}
