namespace KinoApp
{
    partial class Form3
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
            this.filmovi_dvorana = new System.Windows.Forms.Button();
            this.dvorane = new System.Windows.Forms.Button();
            this.rezerviraj = new System.Windows.Forms.Button();
            this.termini_filma = new System.Windows.Forms.Button();
            this.otkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmovi_dvorana
            // 
            this.filmovi_dvorana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filmovi_dvorana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filmovi_dvorana.Location = new System.Drawing.Point(642, 77);
            this.filmovi_dvorana.Name = "filmovi_dvorana";
            this.filmovi_dvorana.Size = new System.Drawing.Size(131, 46);
            this.filmovi_dvorana.TabIndex = 0;
            this.filmovi_dvorana.Text = "button1";
            this.filmovi_dvorana.UseVisualStyleBackColor = true;
            this.filmovi_dvorana.Click += new System.EventHandler(this.filmovi_dvorana_Click);
            // 
            // dvorane
            // 
            this.dvorane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dvorane.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dvorane.Location = new System.Drawing.Point(642, 29);
            this.dvorane.Name = "dvorane";
            this.dvorane.Size = new System.Drawing.Size(131, 42);
            this.dvorane.TabIndex = 1;
            this.dvorane.Text = "Popis dvorana";
            this.dvorane.UseVisualStyleBackColor = true;
            this.dvorane.Click += new System.EventHandler(this.dvorane_Click);
            // 
            // rezerviraj
            // 
            this.rezerviraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezerviraj.Location = new System.Drawing.Point(642, 295);
            this.rezerviraj.Name = "rezerviraj";
            this.rezerviraj.Size = new System.Drawing.Size(131, 34);
            this.rezerviraj.TabIndex = 30;
            this.rezerviraj.Text = "Rezerviraj";
            this.rezerviraj.UseVisualStyleBackColor = true;
            this.rezerviraj.Click += new System.EventHandler(this.rezerviraj_Click);
            // 
            // termini_filma
            // 
            this.termini_filma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termini_filma.AutoSize = true;
            this.termini_filma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termini_filma.Location = new System.Drawing.Point(642, 129);
            this.termini_filma.Name = "termini_filma";
            this.termini_filma.Size = new System.Drawing.Size(131, 41);
            this.termini_filma.TabIndex = 31;
            this.termini_filma.Text = "Termini filma";
            this.termini_filma.UseVisualStyleBackColor = true;
            this.termini_filma.Click += new System.EventHandler(this.termini_filma_Click);
            // 
            // otkazi
            // 
            this.otkazi.Location = new System.Drawing.Point(642, 348);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(131, 38);
            this.otkazi.TabIndex = 32;
            this.otkazi.Text = "Otkazi";
            this.otkazi.UseVisualStyleBackColor = true;
            this.otkazi.Click += new System.EventHandler(this.otkazi_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.termini_filma);
            this.Controls.Add(this.rezerviraj);
            this.Controls.Add(this.dvorane);
            this.Controls.Add(this.filmovi_dvorana);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filmovi_dvorana;
        private System.Windows.Forms.Button dvorane;
        private System.Windows.Forms.Button rezerviraj;
        private System.Windows.Forms.Button termini_filma;
        private System.Windows.Forms.Button otkazi;
    }
}