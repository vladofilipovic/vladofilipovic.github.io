using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KombinacijeIspitnihPitanja
{
	class SpisakIspitnihPitanja
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


		private List<IspitnoPitanje> spisak = new List<IspitnoPitanje>();

		public int Count()
		{
			return spisak.Count;
		}

		public void Clear()
		{
			spisak.Clear();
		}


		public IspitnoPitanje this[int i]
		{
			get 
			{ 
				return spisak.ElementAt(i); 
			}
			set 
			{
				if( spisak.Count > i )
			 spisak.RemoveAt(i);
				spisak.Insert(i, value);
			}
		}
			
		public int DuzinaNajduzegOpisaGrupe()
		{
			return spisak.Select(x => x.GrupaOpis.Length).Max(); ;
		}

		public int DuzinaNajduzegTekstaPitanja()
		{
			return spisak.Select(x => x.Tekst.Length).Max(); ;
		}

		public List<string> OpisiGrupa()
		{
			return spisak.Select(x => x.GrupaOpis).Distinct().ToList();
		}

		public List<int> FrekfencijeZaDatuGrupu(int grupa)
		{
			return spisak.Where(x => x.Grupa == grupa).Select(x => x.Frekfencija).ToList();
		}

		public List<string> PitanjaZaDatuGrupu(int grupa)
		{
			return spisak.Where(x => x.Grupa == grupa).Select(x => x.Tekst).ToList();
		}

		public int OznakaGrupe( string opisGrupe)
		{
			return spisak.Where(x => x.GrupaOpis.Trim().Equals(opisGrupe.Trim())).Select(x => x.Grupa).FirstOrDefault();
		}
	}
}
