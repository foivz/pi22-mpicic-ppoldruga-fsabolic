using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PosudbeIRezervacije;
using Postavke;

namespace Testovi
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IzracunajZakasninu_ProsaoDatumVracanja_VracaZakasninu()
        {
            //Arrange
            Posudba posudba = new Posudba
            {
                Id = 60,
                PredvideniDatumVracanja = DateTime.Now.AddDays(-2).Date
            };

            //Act
            double zakasnina = posudba.IzracunajZakasninu();

            //Assert
            double cijenaZakasnineJednogDana = PostavkeRepozitorij.DohvatiIznosZakasnine();
            double ispravnaZaksnina = 2 * cijenaZakasnineJednogDana;
            Assert.AreEqual(ispravnaZaksnina, zakasnina);
        }
    }
}
