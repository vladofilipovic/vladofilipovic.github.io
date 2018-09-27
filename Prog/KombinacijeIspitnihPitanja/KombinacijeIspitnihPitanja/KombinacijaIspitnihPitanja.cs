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
	enum Citanje { CitaPredmet, CitaGodinu, CitaGrupu, CitaPitanje, CitaFrekfenciju, Gotovo };

	public partial class KombinacijaIspitnihPitanja : Form
	{

		public KombinacijaIspitnihPitanja()
		{
			InitializeComponent();
		}

		private void ucitajSpisak_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "In files (*.in)|*.in|All files (*.*)|*.*";
			openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
			DialogResult rezultat = openFileDialog1.ShowDialog(this);
			if (rezultat != DialogResult.OK)
			{
				status.Text = "Učitavanje pitanja iz datoteke '" + openFileDialog1.SafeFileName + "' nije uspelo.";
				status.ForeColor = Color.DarkRed;
				return;
			}
			Program.spisakIspitnihPitanja.Clear();
			string fileName = openFileDialog1.FileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			StreamReader streamReader = new StreamReader(fileStream);
			string[] spisak = new string[10000];
			string s1 = "";
			int lineCount = 0;
			while (s1 != null)
			{
				do
				{
					s1 = streamReader.ReadLine();
				} while (s1 == "");
				if( s1 != null )
			 spisak[lineCount++] = s1.Trim();
			}
			streamReader.Close();
			fileStream.Close();
			int i = 0;
			int brojGrupe = 0;
			string nazivGrupe = "";
			string pitanje = "";
			int frekfencija = 0;
			int j = 0;
			Citanje trenutniStatus = Citanje.CitaPredmet;
			while (trenutniStatus != Citanje.Gotovo && i<lineCount )
			{
				if (trenutniStatus == Citanje.CitaPredmet)
				{
					Program.spisakIspitnihPitanja.Predmet = spisak[i];
					trenutniStatus = Citanje.CitaGodinu;
					i++;
				}
				else if (trenutniStatus == Citanje.CitaGodinu)
				{
					if (!spisak[i].StartsWith("["))
					{
						Program.spisakIspitnihPitanja.SkolskaGodina = spisak[i];
						trenutniStatus = Citanje.CitaGrupu;
					}
					else
					{
						nazivGrupe = spisak[i].Substring(1, spisak[i].Length - 2);
						brojGrupe++;
						trenutniStatus = Citanje.CitaPitanje;
					}
					i++;
				}
				else if (trenutniStatus == Citanje.CitaGrupu)
				{
					if (spisak[i].StartsWith("["))
					{
						nazivGrupe = spisak[i].Substring(1, spisak[i].Length - 2);
						brojGrupe++;
						trenutniStatus = Citanje.CitaPitanje;
					}
					i++;
				}
				else if (trenutniStatus == Citanje.CitaPitanje)
				{
					pitanje = spisak[i] ;
					trenutniStatus = Citanje.CitaFrekfenciju;
					i++;
				}
				else if (trenutniStatus == Citanje.CitaFrekfenciju)
				{
					try
					{
						frekfencija = Convert.ToInt32(spisak[i]);
					}
					catch (Exception exp)
					{
						status.Text = exp.Message;
						trenutniStatus = Citanje.Gotovo;
					}
					IspitnoPitanje ip = new IspitnoPitanje();
					ip.Grupa = brojGrupe;
					ip.GrupaOpis = nazivGrupe;
					ip.Tekst = pitanje;
					ip.Frekfencija = frekfencija;
					Program.spisakIspitnihPitanja[j++] = ip;
					if (i == lineCount - 1)
						trenutniStatus = Citanje.Gotovo;
					else if (spisak[i + 1].StartsWith("["))
						trenutniStatus = Citanje.CitaGrupu;
					else
						trenutniStatus = Citanje.CitaPitanje;
					i++;
				}
			}
			status.Text = "Uspešno su učitana su pitanja iz datoteke '" + openFileDialog1.SafeFileName + "'.";
			status.ForeColor = Color.DarkBlue;
		}

		private void pregledajSpisak_Click(object sender, EventArgs e)
		{
			if (Program.spisakIspitnihPitanja.Count() == 0)
			{
				status.Text = "Prvo se mora učitati spisak ispitnih pitanja iz datoteke!";
				status.ForeColor = Color.DarkRed;
				return;
			}
			PregledUcitanihPitanja pup = new PregledUcitanihPitanja();
			pup.Visible = true;
		}

		private void generisiKombinaciju_Click(object sender, EventArgs e)
		{
			if (Program.spisakIspitnihPitanja.Count() == 0)
			{
				status.Text = "Prvo se mora učitati spisak ispitnih pitanja iz datoteke!";
				status.ForeColor = Color.DarkRed;
				return;
			}
			GenerisanjeKombinacije gk = new GenerisanjeKombinacije();
			gk.Visible = true;
		}

		private void pregledajKombinaciju_Click(object sender, EventArgs e)
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
			PregledKombinacija pk = new PregledKombinacija();
			pk.Visible = true;
		}

	}
}
