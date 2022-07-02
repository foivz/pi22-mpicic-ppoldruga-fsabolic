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
        public static string DohvatiRadnoVrijeme()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT radno_vrijeme" +
                    " FROM postavke";

            List<string> radnoVrijeme = new List<string>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                radnoVrijeme.Add(reader["radno_vrijeme"].ToString());
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return radnoVrijeme[0];
        }

        public static string DohvatiKontakt()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT kontakt" +
                    " FROM postavke";

            List<string> kontakt = new List<string>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                kontakt.Add(reader["kontakt"].ToString());
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return kontakt[0];
        }
        public static string DohvatiAdresu()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT adresa" +
                    " FROM postavke";

            List<string> adresa = new List<string>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                adresa.Add(reader["adresa"].ToString());
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return adresa[0];
        }
        public static double DohvatiClanarinu()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT clanarina" +
                    " FROM postavke";

            List<double> clanarina = new List<double>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                clanarina.Add(double.Parse(reader["clanarina"].ToString()));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return clanarina[0];
        }

        public static int AzurirajInformacije(int maxBrojPosudbi, double zakasnina, int trajanjeRezervacije, int trajanjePosudbe, int trajanjeProduljenja, string radnoVrijeme, string kontakt, double clanarina)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"UPDATE postavke SET max_broj_posudbi={maxBrojPosudbi},zakasnina={zakasnina},trajanje_rezervacije={trajanjeRezervacije},trajanje_posudbe={trajanjePosudbe},trajanje_produljenja={trajanjeProduljenja},radno_vrijeme='{radnoVrijeme}',kontakt='{kontakt}',clanarina={clanarina}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

    }
}
