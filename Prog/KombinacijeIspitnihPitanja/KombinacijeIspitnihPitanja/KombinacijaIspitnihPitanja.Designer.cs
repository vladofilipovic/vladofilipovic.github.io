namespace KombinacijeIspitnihPitanja
{
	partial class KombinacijaIspitnihPitanja
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ucitajSpisak = new System.Windows.Forms.Button();
			this.status = new System.Windows.Forms.Label();
			this.pregledajSpisak = new System.Windows.Forms.Button();
			this.generisiKombinaciju = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pregledajKombinaciju = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ucitajSpisak
			// 
			this.ucitajSpisak.Location = new System.Drawing.Point(165, 37);
			this.ucitajSpisak.Name = "ucitajSpisak";
			this.ucitajSpisak.Size = new System.Drawing.Size(202, 42);
			this.ucitajSpisak.TabIndex = 0;
			this.ucitajSpisak.Text = "Učitaj spisak ispitnih pitanja...";
			this.ucitajSpisak.UseVisualStyleBackColor = true;
			this.ucitajSpisak.Click += new System.EventHandler(this.ucitajSpisak_Click);
			// 
			// status
			// 
			this.status.AutoEllipsis = true;
			this.status.Location = new System.Drawing.Point(2, 244);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(529, 46);
			this.status.TabIndex = 1;
			this.status.Text = "Doborodošli!";
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pregledajSpisak
			// 
			this.pregledajSpisak.Location = new System.Drawing.Point(165, 86);
			this.pregledajSpisak.Name = "pregledajSpisak";
			this.pregledajSpisak.Size = new System.Drawing.Size(202, 42);
			this.pregledajSpisak.TabIndex = 2;
			this.pregledajSpisak.Text = "Pregledaj spisak ispitnih pitanja...";
			this.pregledajSpisak.UseVisualStyleBackColor = true;
			this.pregledajSpisak.Click += new System.EventHandler(this.pregledajSpisak_Click);
			// 
			// generisiKombinaciju
			// 
			this.generisiKombinaciju.Location = new System.Drawing.Point(165, 135);
			this.generisiKombinaciju.Name = "generisiKombinaciju";
			this.generisiKombinaciju.Size = new System.Drawing.Size(202, 42);
			this.generisiKombinaciju.TabIndex = 3;
			this.generisiKombinaciju.Text = "Generiši kombinaciju...";
			this.generisiKombinaciju.UseVisualStyleBackColor = true;
			this.generisiKombinaciju.Click += new System.EventHandler(this.generisiKombinaciju_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "in";
			this.openFileDialog1.FileName = "Pitanja";
			this.openFileDialog1.Title = "Učitaj spisak";
			// 
			// pregledajKombinaciju
			// 
			this.pregledajKombinaciju.Location = new System.Drawing.Point(165, 184);
			this.pregledajKombinaciju.Name = "pregledajKombinaciju";
			this.pregledajKombinaciju.Size = new System.Drawing.Size(202, 42);
			this.pregledajKombinaciju.TabIndex = 5;
			this.pregledajKombinaciju.Text = "Pregledaj kombinaciju...";
			this.pregledajKombinaciju.UseVisualStyleBackColor = true;
			this.pregledajKombinaciju.Click += new System.EventHandler(this.pregledajKombinaciju_Click);
			// 
			// KombinacijaIspitnihPitanja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 316);
			this.Controls.Add(this.pregledajKombinaciju);
			this.Controls.Add(this.generisiKombinaciju);
			this.Controls.Add(this.pregledajSpisak);
			this.Controls.Add(this.status);
			this.Controls.Add(this.ucitajSpisak);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "KombinacijaIspitnihPitanja";
			this.Text = "Kombinacija";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ucitajSpisak;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Button pregledajSpisak;
		private System.Windows.Forms.Button generisiKombinaciju;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button pregledajKombinaciju;
	}
}

