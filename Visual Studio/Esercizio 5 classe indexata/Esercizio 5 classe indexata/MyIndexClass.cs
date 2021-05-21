using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5_classe_indexata
{
    class MyIndexClass
    {
        private string[] element;

        public MyIndexClass(int elementNumber)
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }

        public string this[int pos]
        {
            get { return element[pos]; }
            set { element[pos] = value; }
        }

        public int length()
        {
            return element.Length;
        }
    }
}
