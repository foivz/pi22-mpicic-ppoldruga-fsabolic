using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaciKnjige
{
    public class Zanr
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Zanr()
        {

        }

        public Zanr(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
    }
}
