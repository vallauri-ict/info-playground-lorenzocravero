using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class Quadrupede : AnimaleTerrestre
    {
        public Quadrupede(string s) : base(s)
        {
            //super(s);
        }

        public override string si_muove()
        {
            return "avanzando su 4 zampe";
        }
    }
}
