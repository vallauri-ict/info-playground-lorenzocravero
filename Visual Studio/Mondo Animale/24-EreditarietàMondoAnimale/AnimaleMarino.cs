using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class AnimaleMarino : AnimaleAcquatico
    {
		public AnimaleMarino(string s) : base(s)
		{
            //super(s);
        }

        public override string vive()
		{
			return "in mare";
		}

		public override string chi_sei()
		{
			return "un animale marino";
		}
	}
}
