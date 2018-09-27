using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KombinacijeIspitnihPitanja
{
	class IspitnoPitanje
	{
		private int grupa = 1;

		public int Grupa
		{
			get { return grupa; }
			set { grupa = value; }
		}

		private string grupaOpis = "";

		public string GrupaOpis
		{
			get { return grupaOpis; }
			set { grupaOpis = value; }
		}

		private string tekst = "";

		public string Tekst
		{
			get { return tekst; }
			set { tekst = value; }
		}

		private int frekfencija = 1;

		public int Frekfencija
		{
			get { return frekfencija; }
			set { frekfencija = value; }
		}
	}
}
