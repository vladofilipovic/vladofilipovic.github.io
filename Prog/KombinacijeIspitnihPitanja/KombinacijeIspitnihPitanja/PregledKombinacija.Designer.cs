namespace KombinacijeIspitnihPitanja
{
	partial class PregledKombinacija
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
			this.kombinacije = new System.Windows.Forms.ListBox();
			this.predmet = new System.Windows.Forms.Label();
			this.godina = new System.Windows.Forms.Label();
			this.sacuvajKombinaciju = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.status = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// kombinacije
			// 
			this.kombinacije.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kombinacije.FormattingEnabled = true;
			this.kombinacije.HorizontalScrollbar = true;
			this.kombinacije.ItemHeight = 15;
			this.kombinacije.Location = new System.Drawing.Point(5, 74);
			this.kombinacije.Name = "kombinacije";
			this.kombinacije.Size = new System.Drawing.Size(948, 439);
			this.kombinacije.TabIndex = 0;
			// 
			// predmet
			// 
			this.predmet.AutoSize = true;
			this.predmet.Location = new System.Drawing.Point(2, 0);
			this.predmet.Name = "predmet";
			this.predmet.Size = new System.Drawing.Size(124, 13);
			this.predmet.TabIndex = 1;
			this.predmet.Text = "Kombinacije nisu učitane";
			// 
			// godina
			// 
			this.godina.AutoSize = true;
			this.godina.Location = new System.Drawing.Point(2, 26);
			this.godina.Name = "godina";
			this.godina.Size = new System.Drawing.Size(0, 13);
			this.godina.TabIndex = 2;
			// 
			// sacuvajKombinaciju
			// 
			this.sacuvajKombinaciju.Location = new System.Drawing.Point(740, 12);
			this.sacuvajKombinaciju.Name = "sacuvajKombinaciju";
			this.sacuvajKombinaciju.Size = new System.Drawing.Size(202, 24);
			this.sacuvajKombinaciju.TabIndex = 5;
			this.sacuvajKombinaciju.Text = "Sačuvaj kombinaciju...";
			this.sacuvajKombinaciju.UseVisualStyleBackColor = true;
			this.sacuvajKombinaciju.Click += new System.EventHandler(this.sacuvajKombinaciju_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "out";
			this.saveFileDialog1.FileName = "Kombinacije";
			// 
			// status
			// 
			this.status.AutoSize = true;
			this.status.Location = new System.Drawing.Point(2, 58);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(0, 13);
			this.status.TabIndex = 6;
			// 
			// PregledKombinacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 512);
			this.Controls.Add(this.status);
			this.Controls.Add(this.sacuvajKombinaciju);
			this.Controls.Add(this.godina);
			this.Controls.Add(this.predmet);
			this.Controls.Add(this.kombinacije);
			this.Name = "PregledKombinacija";
			this.Text = "Pregled ispitnih kombinacija";
			this.Load += new System.EventHandler(this.PregledKombinacija_Load);
			this.Resize += new System.EventHandler(this.PregledUcitanihPitanja_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox kombinacije;
		private System.Windows.Forms.Label predmet;
		private System.Windows.Forms.Label godina;
		private System.Windows.Forms.Button sacuvajKombinaciju;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label status;
	}
}