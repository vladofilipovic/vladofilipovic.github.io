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
    public partial class GenerisanjeKombinacije : Form
    {
        public GenerisanjeKombinacije()
        {
            InitializeComponent();
        }

        private void ucitajMapiranje_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Map files (*.map)|*.map|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            DialogResult rezultat = openFileDialog1.ShowDialog(this);
            if (rezultat != DialogResult.OK)
            {
                status.Text = "Učitavanje mapiranja iz datoteke '" + openFileDialog1.SafeFileName + "' nije uspelo.";
                status.ForeColor = Color.DarkRed;
                return;
            }
            Program.spisakMapiranja.Clear();
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
                if (s1 != null)
                    if (!s1.StartsWith("["))
                        spisak[lineCount++] = s1.Trim();
            }
            streamReader.Close();
            fileStream.Close();
            int bpnl = 0;
            try
            {
                bpnl = Convert.ToInt32(spisak[0]);
            }
            catch (Exception exp)
            {
                status.Text = "Neuspešno čitanje datoteke mapiranja. Pogrešan red 1: '" + spisak[0] + "'"
                    + Environment.NewLine + exp.Message;
                status.ForeColor = Color.DarkRed;
                return;
            }
            Program.spisakMapiranja.BrojPitanjaNaListici = bpnl;
            for (int i = 1; i < lineCount; i++)
            {
                string[] ss = spisak[i].Split();
                if (ss.Length != 2)
                {
                    status.Text = "Neuspešno čitanje datoteke mapiranja. Pogrešan red " + (i + 1) + ": '" + spisak[i] + "'.";
                    status.ForeColor = Color.DarkRed;
                    return;
                }
                int rbr = 0, grup = 0;
                try
                {
                    rbr = Convert.ToInt32(ss[0]);
                    grup = Convert.ToInt32(ss[1]);
                }
                catch (Exception exp)
                {
                    status.Text = "Neuspešno čitanje datoteke mapiranja. Pogrešan red " + (i + 1) + ": '" + spisak[i] + "'"
                        + Environment.NewLine + exp.Message;
                    status.ForeColor = Color.DarkRed;
                    return;
                }
                Mapiranje map = new Mapiranje();
                map.RedniBrojPitanja = rbr;
                map.GrupaPitanjaUSpisku = grup;
                Program.spisakMapiranja[i - 1] = map;
            }
            OsveziKontrole();
            status.Text = "Datoteka mapiranja '" + openFileDialog1.SafeFileName + "' je uspešno pročitana.";
            status.ForeColor = Color.DarkBlue;
        }

        private void OsveziKontrole()
        {
            brojPitanjaNaListici.Text = Program.spisakMapiranja.BrojPitanjaNaListici.ToString();
            List<string> ls = Program.spisakIspitnihPitanja.OpisiGrupa();
            mapiranje.Items.Clear();
            for (int i = 0; i < ls.Count; i++)
            {
                int rbrPitanja = Program.spisakMapiranja[i].RedniBrojPitanja;
                int grupaUSpisku = Program.spisakMapiranja[i].GrupaPitanjaUSpisku;
                string opisGrupe = ls[grupaUSpisku - 1];
                mapiranje.Items.Add(
                    rbrPitanja.ToString().PadRight(2) + " | " +
                    grupaUSpisku.ToString() + " - " + opisGrupe);
            }
        }

        private void GenerisanjeKombinacije_Load(object sender, EventArgs e)
        {
            if (Program.spisakMapiranja.Count() > 0)
            {
                OsveziKontrole();
            }
        }

        private void brojPitanjaNaListici_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.spisakMapiranja.BrojPitanjaNaListici = Convert.ToInt32(brojPitanjaNaListici.Text);
            }
            catch (Exception exp)
            {
                status.Text = "Nekorektan broj pitanja na listici. " + exp.Message;
                status.ForeColor = Color.DarkRed;
                return;
            }
        }

        private void generisiKombinaciju_Click(object sender, EventArgs e)
        {
            int brojListica = 0;
            try
            {
                brojListica = Convert.ToInt32(brojListicaKombinacije.Text);
            }
            catch (Exception exp)
            {
                status.Text = "Nekorektan broj listića kombinacije. " + exp.Message;
                status.ForeColor = Color.DarkRed;
                return;
            }
            int brojPitanjaNaKombinaciji = 0;
            try
            {
                brojPitanjaNaKombinaciji = Convert.ToInt32(brojPitanjaNaListici.Text);
            }
            catch (Exception exp)
            {
                status.Text = "Nekorektan broj pitanja na listiću. " + exp.Message;
                status.ForeColor = Color.DarkRed;
                return;
            }
            Program.spisakKombinacija.Clear();
            Program.spisakKombinacija.Datum = DateTime.Today;
            Program.spisakKombinacija.Predmet = Program.spisakIspitnihPitanja.Predmet;
            Program.spisakKombinacija.SkolskaGodina = Program.spisakIspitnihPitanja.SkolskaGodina;
            List<string>[] pitanja = new List<string>[brojPitanjaNaKombinaciji];
            for (int i = 0; i < brojPitanjaNaKombinaciji; i++)
            {
                pitanja[i] = new List<string>();
                List<int> grupe = Program.spisakMapiranja.GrupeZaDatoPitanje(i + 1);
                foreach (int grupa in grupe)
                {
                    List<int> frekfencijeUGrupi = Program.spisakIspitnihPitanja.FrekfencijeZaDatuGrupu(grupa);
                    List<string> pitanjaUGrupi = Program.spisakIspitnihPitanja.PitanjaZaDatuGrupu(grupa);
                    for (int j = 0; j < frekfencijeUGrupi.Count; j++)
                        for (int k = 0; k < frekfencijeUGrupi[j]; k++)
                        {
                            string s = pitanjaUGrupi[j];
                            pitanja[i].Add(s);
                        }
                }
            }
            Random r = new Random();
            for (int i = 1; i <= brojListica; i++)
            {
                Kombinacija komb = new Kombinacija();
                for (int j = 0; j < pitanja.Length; j++)
                {
                    komb[j] = pitanja[j][r.Next(pitanja[j].Count)];
                }
                Program.spisakKombinacija[i - 1] = komb;
            }
            status.Text = "Kombinacije pitanja su uspešno generisane.";
            status.ForeColor = Color.DarkBlue;
        }
    }
}
