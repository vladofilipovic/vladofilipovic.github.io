using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KombinacijeIspitnihPitanja
{
	class SpisakKombinacija
	{
		private string predmet = "";

		public string Predmet
		{
			get { return predmet; }
			set { predmet = value; }
		}

		private string skolskaGodina = DateTime.Today.Year.ToString() + "/" + (DateTime.Today.Year + 1).ToString();

		public string SkolskaGodina
		{
			get { return skolskaGodina; }
			set { skolskaGodina = value; }
		}

		private DateTime datum = DateTime.Today;

		public DateTime Datum
		{
			get { return datum; }
			set { datum = value; }
		}

		private List<Kombinacija> spisak = new List<Kombinacija>();

		public int Count()
		{
			return spisak.Count;
		}

		public void Clear()
		{
			spisak.Clear();
		}

		public Kombinacija this[int i]
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
	}
}
