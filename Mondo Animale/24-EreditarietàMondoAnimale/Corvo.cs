using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Corvo : Uccello
    {
        public Corvo(string s) : base(s)
        {
            verso = "gracchia";
        }

        public override string chi_sei()
        {
            return "un corvo";
        }
    }
}
