namespace KombinacijeIspitnihPitanja
{
	partial class GenerisanjeKombinacije
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
			this.ucitajMapiranje = new System.Windows.Forms.Button();
			this.sacuvajMapiranje = new System.Windows.Forms.Button();
			this.generisiKombinaciju = new System.Windows.Forms.Button();
			this.mapiranje = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.status = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.brojPitanjaNaListici = new System.Windows.Forms.TextBox();
			this.brojListicaKombinacije = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ucitajMapiranje
			// 
			this.ucitajMapiranje.Location = new System.Drawing.Point(12, 12);
			this.ucitajMapiranje.Name = "ucitajMapiranje";
			this.ucitajMapiranje.Size = new System.Drawing.Size(134, 30);
			this.ucitajMapiranje.TabIndex = 1;
			this.ucitajMapiranje.Text = "Učitaj mapiranje...";
			this.ucitajMapiranje.UseVisualStyleBackColor = true;
			this.ucitajMapiranje.Click += new System.EventHandler(this.ucitajMapiranje_Click);
			// 
			// sacuvajMapiranje
			// 
			this.sacuvajMapiranje.Location = new System.Drawing.Point(239, 12);
			this.sacuvajMapiranje.Name = "sacuvajMapiranje";
			this.sacuvajMapiranje.Size = new System.Drawing.Size(134, 30);
			this.sacuvajMapiranje.TabIndex = 2;
			this.sacuvajMapiranje.Text = "Sačuvaj mapiranje...";
			this.sacuvajMapiranje.UseVisualStyleBackColor = true;
			this.sacuvajMapiranje.Visible = false;
			// 
			// generisiKombinaciju
			// 
			this.generisiKombinaciju.Location = new System.Drawing.Point(126, 415);
			this.generisiKombinaciju.Name = "generisiKombinaciju";
			this.generisiKombinaciju.Size = new System.Drawing.Size(134, 30);
			this.generisiKombinaciju.TabIndex = 6;
			this.generisiKombinaciju.Text = "Generiši kombinaciju!";
			this.generisiKombinaciju.UseVisualStyleBackColor = true;
			this.generisiKombinaciju.Click += new System.EventHandler(this.generisiKombinaciju_Click);
			// 
			// mapiranje
			// 
			this.mapiranje.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapiranje.FormattingEnabled = true;
			this.mapiranje.ItemHeight = 15;
			this.mapiranje.Location = new System.Drawing.Point(12, 79);
			this.mapiranje.Name = "mapiranje";
			this.mapiranje.Size = new System.Drawing.Size(360, 274);
			this.mapiranje.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "map";
			this.openFileDialog1.FileName = "Mapiranje";
			this.openFileDialog1.Title = "Učitaj spisak";
			// 
			// status
			// 
			this.status.AutoEllipsis = true;
			this.status.Location = new System.Drawing.Point(10, 448);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(363, 44);
			this.status.TabIndex = 5;
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Broj pitanja na listici:";
			// 
			// brojPitanjaNaListici
			// 
			this.brojPitanjaNaListici.Location = new System.Drawing.Point(150, 49);
			this.brojPitanjaNaListici.Name = "brojPitanjaNaListici";
			this.brojPitanjaNaListici.Size = new System.Drawing.Size(85, 20);
			this.brojPitanjaNaListici.TabIndex = 3;
			this.brojPitanjaNaListici.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.brojPitanjaNaListici.TextChanged += new System.EventHandler(this.brojPitanjaNaListici_TextChanged);
			// 
			// brojListicaKombinacije
			// 
			this.brojListicaKombinacije.Location = new System.Drawing.Point(150, 372);
			this.brojListicaKombinacije.Name = "brojListicaKombinacije";
			this.brojListicaKombinacije.Size = new System.Drawing.Size(85, 20);
			this.brojListicaKombinacije.TabIndex = 5;
			this.brojListicaKombinacije.Text = "100";
			this.brojListicaKombinacije.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 375);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Broj listica u kombinaciji:";
			// 
			// GenerisanjeKombinacije
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 495);
			this.Controls.Add(this.brojListicaKombinacije);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.brojPitanjaNaListici);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.status);
			this.Controls.Add(this.mapiranje);
			this.Controls.Add(this.generisiKombinaciju);
			this.Controls.Add(this.sacuvajMapiranje);
			this.Controls.Add(this.ucitajMapiranje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "GenerisanjeKombinacije";
			this.Text = "GenerisanjeKombinacije";
			this.Load += new System.EventHandler(this.GenerisanjeKombinacije_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ucitajMapiranje;
		private System.Windows.Forms.Button sacuvajMapiranje;
		private System.Windows.Forms.Button generisiKombinaciju;
		private System.Windows.Forms.ListBox mapiranje;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox brojPitanjaNaListici;
		private System.Windows.Forms.TextBox brojListicaKombinacije;
		private System.Windows.Forms.Label label2;
	}
}