using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class Bipede : AnimaleTerrestre
    {
        public Bipede(string s) : base(s)
        {
            //super(s);
        }

        public override string si_muove()
        {
            return "camminando su 2 gambe";
        }
    }
}
