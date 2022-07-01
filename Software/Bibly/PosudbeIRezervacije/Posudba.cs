﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodaciKnjige;
using Prijava;
using Postavke;

namespace PosudbeIRezervacije
{
    public class Posudba
    {
        public int Id { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public DateTime PredvideniDatumVracanja { get; set; }
        public DateTime StvarniDatumVracanja { get; set; }
        public int BrojProduljivanja { get; set; }
        public double Zakasnina { get; set; }
        public Korisnik Korisnik { get; set; }
        public Primjerak Primjerak { get; set; }
        public DateTime DoKadaVrijediRezervacija { get; set; }
        public int RezervacijaPotvrdena { get; set; }
        public Posudba()
        {

        }

        public bool JeLiKorisnikPresaoGranicuPosudivanja()
        {
            TimeSpan pomRazlikaDana = PredvideniDatumVracanja.Subtract(DateTime.Today);
            int razlikaDana = int.Parse(pomRazlikaDana.TotalDays.ToString());
            double iznosZakasnine = PostavkeRepozitorij.DohvatiIznosZakasnine();
            Zakasnina = (-1) * (iznosZakasnine * razlikaDana);
            PosudbaRepozitorij.AzurirajZakasninu(Id, Zakasnina);
            return Zakasnina;
        }
    }
}
