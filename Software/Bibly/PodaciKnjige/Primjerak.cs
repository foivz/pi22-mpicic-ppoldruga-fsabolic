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
        public string ISBN { get; set; }
        public StatusPrimjerka Status { get; set; }
        public Knjiga Knjiga { get; set; }
        public Primjerak(int id, string isbn, StatusPrimjerka status, Knjiga knjiga)
        {

        }
    }
}
