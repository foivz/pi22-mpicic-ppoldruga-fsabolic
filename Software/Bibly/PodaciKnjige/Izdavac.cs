﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodaciKnjige
{
    public class Izdavac
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Izdavac()
        {

        }

        public Izdavac(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
