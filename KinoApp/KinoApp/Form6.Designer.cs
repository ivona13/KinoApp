namespace KinoApp
{
    partial class Osoblje
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
            this.nazad = new System.Windows.Forms.Button();
            this.zaposlenici = new System.Windows.Forms.ListView();
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dvorana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pocetak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nazad.Location = new System.Drawing.Point(613, 38);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(141, 34);
            this.nazad.TabIndex = 1;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // zaposlenici
            // 
            this.zaposlenici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ime,
            this.prezime,
            this.dvorana,
            this.pocetak,
            this.kraj});
            this.zaposlenici.HideSelection = false;
            this.zaposlenici.Location = new System.Drawing.Point(55, 105);
            this.zaposlenici.Name = "zaposlenici";
            this.zaposlenici.Size = new System.Drawing.Size(496, 310);
            this.zaposlenici.TabIndex = 2;
            this.zaposlenici.UseCompatibleStateImageBehavior = false;
            this.zaposlenici.View = System.Windows.Forms.View.Details;
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            // 
            // dvorana
            // 
            this.dvorana.Text = "Dvorana";
            // 
            // pocetak
            // 
            this.pocetak.Text = "Početak";
            // 
            // kraj
            // 
            this.kraj.Text = "Kraj";
            // 
            // Osoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zaposlenici);
            this.Controls.Add(this.nazad);
            this.Name = "Osoblje";
            this.Text = "Osoblje";
            this.Load += new System.EventHandler(this.Osoblje_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.ListView zaposlenici;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ColumnHeader dvorana;
        private System.Windows.Forms.ColumnHeader pocetak;
        private System.Windows.Forms.ColumnHeader kraj;
    }
}