using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaciKnjige
{
    public class AutorKnjige
    {
        public Autor Autor { get; set; }
        public Knjiga Knjiga { get; set; }

        public AutorKnjige(Autor autor,Knjiga knjiga)
        {
            Autor = autor;
            Knjiga = knjiga;
        }

    }
}
