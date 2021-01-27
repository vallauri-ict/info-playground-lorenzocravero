using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class PesceDiMare : AnimaleMarino
    {
        public PesceDiMare(string s) : base(s)
        {
            //super(s);
        }

        public override string vive()
        {
            return "in mare";
        }

        public override string chi_sei()
        {
            return "un pesce di mare";
        }
    }
}
