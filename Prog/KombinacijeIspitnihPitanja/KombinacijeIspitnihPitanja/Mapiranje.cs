using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KombinacijeIspitnihPitanja
{
	class Mapiranje
	{
		private int redniBrojPitanja = 1;

		public int RedniBrojPitanja
		{
			get { return redniBrojPitanja; }
			set { redniBrojPitanja = value; }
		}

		private int grupaPitanjaUSpisku = 1;

		public int GrupaPitanjaUSpisku
		{
			get { return grupaPitanjaUSpisku; }
			set { grupaPitanjaUSpisku = value; }
		}

	}
}
