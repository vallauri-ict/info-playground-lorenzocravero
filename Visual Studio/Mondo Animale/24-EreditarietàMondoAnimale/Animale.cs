using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class Animale
    {
		protected string nome;
		protected string verso;

		public Animale(string s)
		{
			nome = s;
		}

		public abstract string si_muove();

		public abstract string vive();

		public abstract string chi_sei();

		public void mostra()
		{
			Console.WriteLine(nome + ", " + chi_sei() + ", " + verso + ", si muove " + si_muove() + " e vive " + vive());
		}
	}
}
