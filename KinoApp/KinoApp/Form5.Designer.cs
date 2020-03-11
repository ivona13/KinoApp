namespace KinoApp
{
    partial class FormPodaci
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
            this.imeBox = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.Label();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.rezerviraj = new System.Windows.Forms.Button();
            this.ime = new System.Windows.Forms.Label();
            this.racun = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // imeBox
            // 
            this.imeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeBox.Location = new System.Drawing.Point(219, 76);
            this.imeBox.MaxLength = 20;
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(258, 26);
            this.imeBox.TabIndex = 0;
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezime.Location = new System.Drawing.Point(77, 164);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(88, 20);
            this.prezime.TabIndex = 2;
            this.prezime.Text = "PREZIME";
            // 
            // prezimeBox
            // 
            this.prezimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeBox.Location = new System.Drawing.Point(219, 164);
            this.prezimeBox.MaxLength = 20;
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(258, 26);
            this.prezimeBox.TabIndex = 3;
            // 
            // rezerviraj
            // 
            this.rezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezerviraj.Location = new System.Drawing.Point(332, 318);
            this.rezerviraj.Name = "rezerviraj";
            this.rezerviraj.Size = new System.Drawing.Size(145, 40);
            this.rezerviraj.TabIndex = 4;
            this.rezerviraj.Text = "Rezerviraj";
            this.rezerviraj.UseVisualStyleBackColor = true;
            this.rezerviraj.Click += new System.EventHandler(this.rezerviraj_Click);
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ime.Location = new System.Drawing.Point(77, 81);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(46, 20);
            this.ime.TabIndex = 1;
            this.ime.Text = "IME:";
            // 
            // racun
            // 
            this.racun.AutoSize = true;
            this.racun.Enabled = false;
            this.racun.Location = new System.Drawing.Point(388, 393);
            this.racun.Name = "racun";
            this.racun.Size = new System.Drawing.Size(89, 20);
            this.racun.TabIndex = 5;
            this.racun.TabStop = true;
            this.racun.Text = "Ispiši račun";
            this.racun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.racun_LinkClicked);
            // 
            // FormPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.racun);
            this.Controls.Add(this.rezerviraj);
            this.Controls.Add(this.prezimeBox);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.imeBox);
            this.Name = "FormPodaci";
            this.Text = "Podaci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPodaci_FormClosed);
            this.Load += new System.EventHandler(this.FormPodaci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.Button rezerviraj;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.LinkLabel racun;
    }
}