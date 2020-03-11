namespace KinoApp
{
    partial class Form2
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
            this.filmovi = new System.Windows.Forms.ListView();
            this.film = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.termin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmovi
            // 
            this.filmovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filmovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.film,
            this.termin});
            this.filmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filmovi.HideSelection = false;
            this.filmovi.Location = new System.Drawing.Point(32, 91);
            this.filmovi.Name = "filmovi";
            this.filmovi.Size = new System.Drawing.Size(356, 347);
            this.filmovi.TabIndex = 0;
            this.filmovi.UseCompatibleStateImageBehavior = false;
            this.filmovi.View = System.Windows.Forms.View.Tile;
            this.filmovi.Click += new System.EventHandler(this.filmovi_Click);
            // 
            // film
            // 
            this.film.Text = "FILM";
            this.film.Width = 249;
            // 
            // termin
            // 
            this.termin.Text = "VRIJEME ODRŽAVANJA";
            this.termin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.termin.Width = 222;
            // 
            // nazad
            // 
            this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazad.Location = new System.Drawing.Point(661, 23);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(110, 32);
            this.nazad.TabIndex = 1;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.filmovi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView filmovi;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.ColumnHeader film;
        private System.Windows.Forms.ColumnHeader termin;
    }
}