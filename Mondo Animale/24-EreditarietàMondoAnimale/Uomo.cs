using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Uomo : Bipede
    {
        public Uomo(string s) : base(s)
        {
            verso = "parla";
        }

        public override string chi_sei()
        {
            return "un homo sapiens";
        }

        public override string vive()
        {
            return "in un condominio";
        }
    }
}
