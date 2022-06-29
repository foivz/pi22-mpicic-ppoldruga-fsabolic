using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaciKnjige
{
    public class Primjerak
    {
        public int Id { get; set; }
        public StatusPrimjerka Status { get; set; }
        public Knjiga Knjiga { get; set; }
        public string DoKadaJeNedostupan { get; set; }
        
        public Primjerak(int id, StatusPrimjerka status, Knjiga knjiga, string doKadaJeNedostupan)
        {
            Id = id;
            Status = status;
            Knjiga = knjiga;
            DoKadaJeNedostupan = doKadaJeNedostupan;
        }

        public override string ToString()
        {
            return Id + " - " + Knjiga.Naziv;
        }
    }
}
