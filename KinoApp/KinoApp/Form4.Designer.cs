namespace KinoApp
{
    partial class Form4
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
            this.popisFilmova = new System.Windows.Forms.Button();
            this.termini = new System.Windows.Forms.ListView();
            this.termin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dvorana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // popisFilmova
            // 
            this.popisFilmova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.popisFilmova.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popisFilmova.Location = new System.Drawing.Point(685, 44);
            this.popisFilmova.Name = "popisFilmova";
            this.popisFilmova.Size = new System.Drawing.Size(90, 34);
            this.popisFilmova.TabIndex = 0;
            this.popisFilmova.Text = "Popis";
            this.popisFilmova.UseVisualStyleBackColor = true;
            this.popisFilmova.Click += new System.EventHandler(this.popisFilmova_Click);
            // 
            // termini
            // 
            this.termini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.termin,
            this.dvorana});
            this.termini.HideSelection = false;
            this.termini.Location = new System.Drawing.Point(30, 145);
            this.termini.Name = "termini";
            this.termini.Size = new System.Drawing.Size(411, 254);
            this.termini.TabIndex = 1;
            this.termini.UseCompatibleStateImageBehavior = false;
            this.termini.View = System.Windows.Forms.View.Tile;
            this.termini.Click += new System.EventHandler(this.termini_Click);
            // 
            // termin
            // 
            this.termin.Text = "Vrijeme početka";
            this.termin.Width = 130;
            // 
            // dvorana
            // 
            this.dvorana.Text = "Dvorana";
            this.dvorana.Width = 130;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.termini);
            this.Controls.Add(this.popisFilmova);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button popisFilmova;
        private System.Windows.Forms.ListView termini;
        private System.Windows.Forms.ColumnHeader termin;
        private System.Windows.Forms.ColumnHeader dvorana;
    }
}