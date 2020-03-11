namespace KinoApp
{
    partial class Form1
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
            this.dvorane = new System.Windows.Forms.ListView();
            this.dvorana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis_filmova = new System.Windows.Forms.ListView();
            this.film = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.osoblje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dvorane
            // 
            this.dvorane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dvorana});
            this.dvorane.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dvorane.HideSelection = false;
            this.dvorane.Location = new System.Drawing.Point(53, 54);
            this.dvorane.Name = "dvorane";
            this.dvorane.Size = new System.Drawing.Size(282, 371);
            this.dvorane.TabIndex = 0;
            this.dvorane.UseCompatibleStateImageBehavior = false;
            this.dvorane.View = System.Windows.Forms.View.List;
            this.dvorane.Click += new System.EventHandler(this.dvorane_Click);
            // 
            // dvorana
            // 
            this.dvorana.Text = "Popis dvorana";
            this.dvorana.Width = 113;
            // 
            // popis_filmova
            // 
            this.popis_filmova.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popis_filmova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.film});
            this.popis_filmova.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popis_filmova.HideSelection = false;
            this.popis_filmova.Location = new System.Drawing.Point(341, 54);
            this.popis_filmova.Name = "popis_filmova";
            this.popis_filmova.Size = new System.Drawing.Size(285, 371);
            this.popis_filmova.TabIndex = 1;
            this.popis_filmova.UseCompatibleStateImageBehavior = false;
            this.popis_filmova.View = System.Windows.Forms.View.Tile;
            this.popis_filmova.Click += new System.EventHandler(this.popis_filmova_Click);
            // 
            // film
            // 
            this.film.Text = "Popis filmova";
            this.film.Width = 106;
            // 
            // osoblje
            // 
            this.osoblje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osoblje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osoblje.Location = new System.Drawing.Point(654, 54);
            this.osoblje.Name = "osoblje";
            this.osoblje.Size = new System.Drawing.Size(134, 34);
            this.osoblje.TabIndex = 2;
            this.osoblje.Text = "Osoblje";
            this.osoblje.UseVisualStyleBackColor = true;
            this.osoblje.Click += new System.EventHandler(this.osoblje_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis dvorana";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(429, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Popis filmova";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osoblje);
            this.Controls.Add(this.popis_filmova);
            this.Controls.Add(this.dvorane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dvorane;
        private System.Windows.Forms.ColumnHeader dvorana;
        private System.Windows.Forms.ListView popis_filmova;
        private System.Windows.Forms.ColumnHeader film;
        private System.Windows.Forms.Button osoblje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

