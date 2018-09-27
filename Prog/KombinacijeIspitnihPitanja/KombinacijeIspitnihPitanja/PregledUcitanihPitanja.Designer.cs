namespace KombinacijeIspitnihPitanja
{
	partial class PregledUcitanihPitanja
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
			this.pitanja = new System.Windows.Forms.ListBox();
			this.predmet = new System.Windows.Forms.Label();
			this.godina = new System.Windows.Forms.Label();
			this.sacuvajSpisakPitanja = new System.Windows.Forms.Button();
			this.status = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// pitanja
			// 
			this.pitanja.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pitanja.FormattingEnabled = true;
			this.pitanja.HorizontalScrollbar = true;
			this.pitanja.ItemHeight = 15;
			this.pitanja.Location = new System.Drawing.Point(1, 71);
			this.pitanja.Name = "pitanja";
			this.pitanja.Size = new System.Drawing.Size(951, 439);
			this.pitanja.TabIndex = 0;
			// 
			// predmet
			// 
			this.predmet.AutoSize = true;
			this.predmet.Location = new System.Drawing.Point(2, 0);
			this.predmet.Name = "predmet";
			this.predmet.Size = new System.Drawing.Size(99, 13);
			this.predmet.TabIndex = 1;
			this.predmet.Text = "Pitanja nisu učitana";
			// 
			// godina
			// 
			this.godina.AutoSize = true;
			this.godina.Location = new System.Drawing.Point(2, 26);
			this.godina.Name = "godina";
			this.godina.Size = new System.Drawing.Size(0, 13);
			this.godina.TabIndex = 2;
			// 
			// sacuvajSpisakPitanja
			// 
			this.sacuvajSpisakPitanja.Location = new System.Drawing.Point(740, 12);
			this.sacuvajSpisakPitanja.Name = "sacuvajSpisakPitanja";
			this.sacuvajSpisakPitanja.Size = new System.Drawing.Size(202, 24);
			this.sacuvajSpisakPitanja.TabIndex = 6;
			this.sacuvajSpisakPitanja.Text = "Sačuvaj spisak pitanja...";
			this.sacuvajSpisakPitanja.UseVisualStyleBackColor = true;
			this.sacuvajSpisakPitanja.Click += new System.EventHandler(this.sacuvajSpisakPitanja_Click);
			// 
			// status
			// 
			this.status.AutoSize = true;
			this.status.Location = new System.Drawing.Point(2, 55);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(0, 13);
			this.status.TabIndex = 7;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "Pitanja";
			// 
			// PregledUcitanihPitanja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 512);
			this.Controls.Add(this.status);
			this.Controls.Add(this.sacuvajSpisakPitanja);
			this.Controls.Add(this.godina);
			this.Controls.Add(this.predmet);
			this.Controls.Add(this.pitanja);
			this.Name = "PregledUcitanihPitanja";
			this.Text = "Pregled učitanih pitanja";
			this.Load += new System.EventHandler(this.PregledUcitanihPitanja_Load);
			this.Resize += new System.EventHandler(this.PregledUcitanihPitanja_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox pitanja;
		private System.Windows.Forms.Label predmet;
		private System.Windows.Forms.Label godina;
		private System.Windows.Forms.Button sacuvajSpisakPitanja;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}