using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KombinacijeIspitnihPitanja
{
	class SpisakMapiranja
	{

		private int brojPitanjaNaListici = 4;

		public int BrojPitanjaNaListici
		{
			get { return brojPitanjaNaListici; }
			set { brojPitanjaNaListici = value; }
		}

		private List<Mapiranje> spisak = new List<Mapiranje>();

		public int Count()
		{
			return spisak.Count;
		}

		public void Clear()
		{
			spisak.Clear();
		}


		public Mapiranje this[int i]
		{
			get
			{
				return spisak.ElementAt(i);
			}
			set
			{
				if (spisak.Count > i)
					spisak.RemoveAt(i);
				spisak.Insert(i, value);
			}
		}

		public List<int> GrupeZaDatoPitanje(int redniBrojPitanja)
		{
			return spisak.Where(x => x.RedniBrojPitanja == redniBrojPitanja).Select(x => x.GrupaPitanjaUSpisku).ToList();
		}

	}

}
