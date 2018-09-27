using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KombinacijeIspitnihPitanja
{
	static class Program
	{
		internal static SpisakIspitnihPitanja spisakIspitnihPitanja = new SpisakIspitnihPitanja();
		internal static SpisakMapiranja spisakMapiranja = new SpisakMapiranja();
		internal static SpisakKombinacija spisakKombinacija = new SpisakKombinacija();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new KombinacijaIspitnihPitanja());
		}
	}
}
