using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KombinacijeIspitnihPitanja
{
	public partial class PregledUcitanihPitanja : Form
	{
		public PregledUcitanihPitanja()
		{
			InitializeComponent();
		}


		private void PregledUcitanihPitanja_Load(object sender, EventArgs e)
		{
			if (Program.spisakIspitnihPitanja.Predmet != "")
			{
				OsveziKontrole();
			}
		}

		private void OsveziKontrole()
		{
			predmet.Text = Program.spisakIspitnihPitanja.Predmet;
			godina.Text = Program.spisakIspitnihPitanja.SkolskaGodina;
			pitanja.Items.Clear();
			for (int i = 0; i < Program.spisakIspitnihPitanja.Count(); i++)
				pitanja.Items.Add(
					Program.spisakIspitnihPitanja[i].Grupa.ToString().PadRight(3) + " | " +
					Program.spisakIspitnihPitanja[i].GrupaOpis.ToString().PadRight(Program.spisakIspitnihPitanja.DuzinaNajduzegOpisaGrupe()) + " | " +
					Program.spisakIspitnihPitanja[i].Tekst.ToString().PadRight(Program.spisakIspitnihPitanja.DuzinaNajduzegTekstaPitanja()) + " | " +
					Program.spisakIspitnihPitanja[i].Frekfencija.ToString().PadRight(3)
			);
		}

		private void PregledUcitanihPitanja_Resize(object sender, EventArgs e)
		{
			pitanja.Width = this.ClientSize.Width - 2 * pitanja.Left;
			pitanja.Height = this.ClientSize.Height - pitanja.Top;
		}

		private void sacuvajSpisakPitanja_Click(object sender, EventArgs e)
		{
			if (Program.spisakIspitnihPitanja.Count() == 0)
			{
				status.Text = "Ne postoji spisak ispitnih pitanja!";
				status.ForeColor = Color.DarkRed;
				return;
			}
			saveFileDialog1.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
			DialogResult rezultat = saveFileDialog1.ShowDialog(this);
			if (rezultat != DialogResult.OK)
			{
				status.Text = "Upis ispitnih pitanja u datoteku '" + saveFileDialog1.FileName + "' nije uspeo.";
				status.ForeColor = Color.DarkRed;
				return;
			}
			string fileName = saveFileDialog1.FileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine();
			streamWriter.WriteLine(Program.spisakIspitnihPitanja.Predmet + " - " +
				Program.spisakIspitnihPitanja.SkolskaGodina);
			streamWriter.WriteLine();
			List<string> opisiGrupa = Program.spisakIspitnihPitanja.OpisiGrupa();
			for (int i = 0; i < opisiGrupa.Count(); i++)
			{
				streamWriter.WriteLine( (i+1) + ". " + opisiGrupa[i] );
				int oznakaGrupe = Program.spisakIspitnihPitanja.OznakaGrupe(opisiGrupa[i]);
				List<int> frekfencijeUGrupi = Program.spisakIspitnihPitanja.FrekfencijeZaDatuGrupu(oznakaGrupe);
				List<string> pitanjaUGrupi = Program.spisakIspitnihPitanja.PitanjaZaDatuGrupu(oznakaGrupe);
				for (int j = 0; j < pitanjaUGrupi.Count(); j++)
				{
					if (frekfencijeUGrupi[j] > 0)
					{
						streamWriter.WriteLine(pitanjaUGrupi[j]);
					}
				}
				streamWriter.WriteLine();
			}
			streamWriter.Flush();
			streamWriter.Close();
			status.Text = "Uspešno je izvršen upis kombinacije u datoteku '" + saveFileDialog1.FileName + "'.";
			status.ForeColor = Color.DarkBlue;


		}
	}
}
