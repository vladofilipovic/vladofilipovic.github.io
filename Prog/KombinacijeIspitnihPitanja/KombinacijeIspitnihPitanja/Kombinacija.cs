using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KombinacijeIspitnihPitanja
{
	class Kombinacija
	{
		List<string> pitanja = new List<string>();

		public string this[int i]
		{
			get
			{
				return pitanja.ElementAt(i);
			}
			set
			{
				if (pitanja.Count > i)
					pitanja.RemoveAt(i);
				pitanja.Insert(i, value);
			}
		}

		public int Count()
		{
			return pitanja.Count;
		}
	}
}
