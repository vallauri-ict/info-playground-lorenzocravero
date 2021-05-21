using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_di_prova_sulle_classi
{
    class Rectangle
    {
        public int b;
        public int h;

        public Rectangle()
        {
            b = 10;
            h = 15;
        }

        public Rectangle(int x,int y)
        {
            System.Windows.Forms.MessageBox.Show("Rettangolo creato\nBase: "+x+"\nAltezza: "+y);
        }

        public static int calcolaArea(int b, int h)
        {
            int area;
            return area = b * h;
        }

        public static int calcolaPerimetro(int b, int h)
        {
            int perimetro;
            return perimetro = (b + h) * 2;
        }
    }
}
