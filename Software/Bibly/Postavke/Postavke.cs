using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postavke
{
    public class Postavke
    {
        private static Postavke instanca;
        public static Postavke Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new Postavke();
                return instanca;
            }
        }


    }
}
