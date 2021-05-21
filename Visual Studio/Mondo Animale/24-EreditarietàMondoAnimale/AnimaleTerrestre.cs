using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class AnimaleTerrestre : Animale
    {
		public AnimaleTerrestre(string s) : base(s)
		{
            //super(s);
        }

        public override string vive()
		{
			return "sulla terraferma";
		}

		public override string chi_sei()
		{
			return "un animale terrestre";
		}
	}
}
