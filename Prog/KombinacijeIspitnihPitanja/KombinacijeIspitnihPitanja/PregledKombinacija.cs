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
	public partial class PregledKombinacija : Form
	{
		public PregledKombinacija()
		{
			InitializeComponent();
		}


		private void OsveziKontrole()
		{
			predmet.Text = Program.spisakKombinacija.Predmet;
			godina.Text = Program.spisakKombinacija.SkolskaGodina +
				" | " + Program.spisakKombinacija.Datum.ToString("dd.MM.yyyy");
			kombinacije.Items.Clear();
			for (int i = 0; i < Program.spisakKombinacija.Count(); i++)
			{
				string s = "";
				for (int j = 0; j < Program.spisakKombinacija[i].Count(); j++)
					s += Program.spisakKombinacija[i][j] + " | " + Environment.NewLine;
				kombinacije.Items.Add(s);
			}
		}

		private void PregledUcitanihPitanja_Resize(object sender, EventArgs e)
		{
			kombinacije.Width = this.ClientSize.Width - 2 * kombinacije.Left;
			kombinacije.Height = this.ClientSize.Height - kombinacije.Top;
		}

		private void PregledKombinacija_Load(object sender, EventArgs e)
		{
			if (Program.spisakKombinacija.Predmet != "")
			{
				OsveziKontrole();
			}

		}

		private void sacuvajKombinaciju_Click(object sender, EventArgs e)
		{
			if (Program.spisakIspitnihPitanja.Count() == 0)
			{
				status.Text = "Ne postoji spisak ispitnih pitanja!";
				status.ForeColor = Color.DarkRed;
				return;
			}
			if (Program.spisakMapiranja.Count() == 0)
			{
				status.Text = "Ne postoji spisak mapiranja!";
				status.ForeColor = Color.DarkRed;
				return;
			}
			if (Program.spisakKombinacija.Count() == 0)
			{
				status.Text = "Nije generisan postoji spisak ispitnih kombinacija!";
				status.ForeColor = Color.DarkRed;
				return;
			}
			saveFileDialog1.Filter = "Out files (*.out)|*.out|All files (*.*)|*.*";
			saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
			DialogResult rezultat = saveFileDialog1.ShowDialog(this);
			if (rezultat != DialogResult.OK)
			{
				status.Text = "Upis ispitnih kombinacija u datoteku '" + saveFileDialog1.FileName + "' nije uspeo.";
				status.ForeColor = Color.DarkRed;
				return;
			}
			string fileName = saveFileDialog1.FileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			for (int i = 0; i < Program.spisakKombinacija.Count(); i++)
			{
				streamWriter.WriteLine(Program.spisakKombinacija.Predmet + " - " +
					Program.spisakKombinacija.SkolskaGodina);
				streamWriter.WriteLine();
				streamWriter.WriteLine(Program.spisakKombinacija.Datum.ToString("dd.MM.yyyy") + " - " + (i + 1));
				streamWriter.WriteLine();
				for (int j = 0; j < Program.spisakKombinacija[i].Count(); j++)
				{
					streamWriter.WriteLine(Program.spisakKombinacija[i][j]);
					streamWriter.WriteLine();
				}
				streamWriter.WriteLine();
				streamWriter.WriteLine("-----------------------------------------------------------------------------");
			}
			streamWriter.Flush();
			streamWriter.Close();
			status.Text = "Uspešno je izvršen upis kombinacije u datoteku '" + saveFileDialog1.FileName + "'.";
			status.ForeColor = Color.DarkBlue;

		}
	}
}
