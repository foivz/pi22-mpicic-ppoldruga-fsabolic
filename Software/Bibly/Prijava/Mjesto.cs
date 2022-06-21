﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    public class Mjesto
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        public Mjesto()
        {

        }
        public Mjesto(int id, string naziv)
        {
            ID = id;
            Naziv = naziv;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
