﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Baza;
using PodaciKnjige;
using Prijava;
using Postavke;

namespace PosudbeIRezervacije
{
    public static class PosudbaRepozitorij
    {
        public static void ZatvortiPosudbu(Posudba posudba)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe " +
                $"SET" +
                $" stvarni_datum_vracanja = '{posudba.StvarniDatumVracanja:yyyy-MM-dd}'" +
                $", zakasnina = {posudba.Zakasnina}" +
                $" WHERE id_posudba = {posudba.Id}";
            BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static Posudba DohvatiPosudbuPrimjerka(Primjerak primjerak)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", predviden_datum_vracanja" +
                    " FROM posudbe" +
                    " WHERE predviden_datum_vracanja IS NOT NULL" +
                    " AND stvarni_datum_vracanja IS NULL " +
                    $" AND id_primjerak = {primjerak.Id}";
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            List<Posudba> posudba = new List<Posudba>();
            while (reader.Read())
            {
                posudba.Add(new Posudba
                {
                    Id = int.Parse(reader["id_posudba"].ToString()),
                    PredvideniDatumVracanja = DateTime.Parse(reader["predviden_datum_vracanja"].ToString())
                });
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if (posudba.Count == 0)
            {
                return null;
            }
            return posudba[0];
        }
        public static void ProduljiPosudbu(Posudba posudba, DateTime noviDatumVracanja)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe " +
                $"SET broj_produljivanja = {posudba.BrojProduljivanja}, predviden_datum_vracanja = '{noviDatumVracanja:yyyy-MM-dd}' WHERE id_posudba = {posudba.Id}";
            BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static void AzurirajZakasninu(int idPosudbe, double zakasnina)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe " +
                $"SET zakasnina = {zakasnina} WHERE id_posudba = {idPosudbe}";
            BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static void DodajPosudbuKojaNijeBilaRezervirana(Posudba posudba)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"INSERT INTO posudbe" +
                    $" (datum_posudbe" +
                    $", predviden_datum_vracanja" +
                    $", id_primjerak" +
                    $", id_korisnik) " +
                $" VALUES (" +
                    $" '{posudba.DatumPosudbe:yyyy-MM-dd}'" +
                    $", '{posudba.PredvideniDatumVracanja:yyyy-MM-dd}'" +
                    $", {posudba.Primjerak.Id}" +
                    $", '{posudba.Korisnik.OIB}')";
            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static void AzurirajPosudbuKojaJeBilaRezervirana(Posudba posudba)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe SET " +
                    $"datum_posudbe = '{posudba.DatumPosudbe.ToString("yyyy-MM-dd")}'" +
                    $", predviden_datum_vracanja = '{posudba.PredvideniDatumVracanja.ToString("yyyy-MM-dd")}'" +
                    $", rezervacija_potvrdena = 1" +
                    $" WHERE id_posudba = {posudba.Id}";
            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static List<Posudba> DohvatiTrenutnePosudbeKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", datum_posudbe" +
                    ", predviden_datum_vracanja" +
                    ", broj_produljivanja" +
                    ", zakasnina" +
                    ", id_primjerak" +
                    " FROM posudbe" +
                    " WHERE stvarni_datum_vracanja IS NULL" +
                    " AND datum_posudbe IS NOT NULL" +
                    $" AND id_korisnik = '{korisnik.OIB}'";
            List<Posudba> trenutnePosudbeKorisnika = new List<Posudba>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int idPosudbe = int.Parse(reader["id_posudba"].ToString());
                int idPrimjerka = int.Parse(reader["id_primjerak"].ToString());
                trenutnePosudbeKorisnika.Add(new Posudba { 
                    Id = idPosudbe,
                    DatumPosudbe = DateTime.Parse(reader["datum_posudbe"].ToString()),
                    PredvideniDatumVracanja = DateTime.Parse(reader["predviden_datum_vracanja"].ToString()),
                    BrojProduljivanja = int.Parse(reader["broj_produljivanja"].ToString()),
                    Zakasnina = double.Parse(reader["zakasnina"].ToString()),
                    Korisnik = korisnik,
                    Primjerak = PrimjerakRepozitorij.DohvatiPrimjerak(idPrimjerka)
                });
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if (trenutnePosudbeKorisnika.Count == 0)
            {
                return null;
            }
            return trenutnePosudbeKorisnika;
        }
        public static List<Posudba> DohvatiProslePosudbeKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", datum_posudbe" +
                    ", predviden_datum_vracanja" +
                    ", stvarni_datum_vracanja" +
                    ", broj_produljivanja" +
                    ", zakasnina" +
                    ", id_primjerak" +
                    " FROM posudbe" +
                    " WHERE stvarni_datum_vracanja IS NOT NULL" +
                    $" AND id_korisnik = '{korisnik.OIB}'";
            List<Posudba> proslePosudbeKorisnika = new List<Posudba>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int idPosudbe = int.Parse(reader["id_posudba"].ToString());
                int idPrimjerka = int.Parse(reader["id_primjerak"].ToString());
                proslePosudbeKorisnika.Add(new Posudba {
                    Id = idPosudbe,
                    DatumPosudbe = DateTime.Parse(reader["datum_posudbe"].ToString()),
                    PredvideniDatumVracanja = DateTime.Parse(reader["predviden_datum_vracanja"].ToString()),
                    StvarniDatumVracanja = DateTime.Parse(reader["stvarni_datum_vracanja"].ToString()),
                    BrojProduljivanja = int.Parse(reader["broj_produljivanja"].ToString()),
                    Zakasnina = double.Parse(reader["zakasnina"].ToString()),
                    Korisnik = korisnik,
                    Primjerak = PrimjerakRepozitorij.DohvatiPrimjerak(idPrimjerka)
                });
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if (proslePosudbeKorisnika.Count == 0)
            {
                return null;
            }
            return proslePosudbeKorisnika;
        }
    }
}