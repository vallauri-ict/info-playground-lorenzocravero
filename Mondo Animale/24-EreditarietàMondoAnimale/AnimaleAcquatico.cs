using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class AnimaleAcquatico : Animale
    {
		public AnimaleAcquatico(string s) : base(s)
		{
            //super(s);
        }

        public override string vive()
		{
			return "nell'acqua";
		}

		public override string chi_sei()
		{
			return "un animale acquatico";
		}
	}
}
