﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_derivate
{
    class Mannaro : Mostro
    {
        protected bool mutato;
        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }

        public double Valore()
        {
            if (mutato)
                return 2 * base.Valore(); 
            else
                return base.Valore();
        }

        public string Verso()
        {
            if (mutato)
                return verso;
            else
                return base.Verso();
        }

        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
