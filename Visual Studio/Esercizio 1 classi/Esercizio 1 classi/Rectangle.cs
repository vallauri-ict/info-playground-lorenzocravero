using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Esercizio_1_classi
{
    class Rectangle
    {
        //dimensioni del rettangolo
        public int side1,side2;
        private string descrizione;
        public Color color;

        public Rectangle()
        {
            descrizione = "Sono un rettangolo";
        }

        public Rectangle(int l): this(l,l)
        {

        }

        public Rectangle(int b,int h)
        {
            side1 = b;
            side2 = h;
        }

        public string getSide()
        {
            return "Base: "+side1.ToString() + " Altezza: " + side2.ToString();
        }
    }
}
