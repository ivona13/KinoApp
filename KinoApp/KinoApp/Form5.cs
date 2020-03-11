using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace KinoApp
{
    public partial class FormPodaci : Form
    {
        List<Button> sjedala;
        int id_filma, cijena, brojRacuna = 0;
        string film, termin, dvorana;
        Boolean rezervirano = false;

        public SqlConnection cn = new SqlConnection("Data Source=PC-00\\IVONASQL;Initial Catalog=KinoDB;Integrated Security=True");

        public FormPodaci(List<Button> sjedala, int id_filma)
        {
            this.id_filma = id_filma;
            this.sjedala = new List<Button>();
            this.sjedala = sjedala;

            cn.Open();
            SqlCommand command = new SqlCommand("select * from filmovi where id = " + id_filma, cn);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            cijena = Int32.Parse(dr["cijena"].ToString()) * sjedala.Count();
            film = dr["naslov"].ToString();
            termin = dr["termin"].ToString();
            dvorana = dr["dvorana"].ToString();
            dr.Close();

            InitializeComponent();
        }

        private void rezerviraj_Click(object sender, EventArgs e)
        {
           
            if (imeBox.Text != "" && prezimeBox.Text != "" && !rezervirano)
            {
                foreach (Button b in sjedala)
                {
                    try
                    {
                        int sjedalo = Int32.Parse(b.Name.ToString().Substring(6));
                        SqlCommand rezervacijaQuery = new SqlCommand("insert into Rezervacije (sjedalo, id_filma, ime, prezime) " +
                        "values (" + sjedalo + ", " + id_filma + ", '" + imeBox.Text.ToString().Trim() + "', '" + prezimeBox.Text.ToString().Trim() + "')", cn);
                        rezervacijaQuery.ExecuteNonQuery();
                        rezervirano = true;
                        rezerviraj.Enabled = false;
                        brojRacuna++;
                    }
                    catch (InvalidCastException) { }
                    
                }
                MessageBox.Show("Uspjesna rezervacija");
                imeBox.Enabled = false;
                prezimeBox.Enabled = false;
            }

            // ispisi racun
            racun.Enabled = true;
        }

        private void FormPodaci_Load(object sender, EventArgs e)
        {
            Label cijenaLabel = new Label();
            cijenaLabel.Location = new Point(230, 160);
            cijenaLabel.Text = new StringBuilder().Append("Cijena: ").Append(cijena.ToString()).Append(" kn").ToString();
            cijenaLabel.Font = new Font(cijenaLabel.Font, FontStyle.Bold);
            cijenaLabel.AutoSize = true;
            this.Controls.Add(cijenaLabel);
        }

        private void racun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
            PdfSharp.Pdf.PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
            StringBuilder sb = new StringBuilder();
            sb.Append("Ime i prezime kupca: ").Append(imeBox.Text).Append(" ")
                .Append(prezimeBox.Text);
            gfx.DrawString(sb.ToString(), font, XBrushes.Black, new XRect(20, 50, 20, 0));

            sb = new StringBuilder();
            sb.Append("Film: ").Append(film);
            gfx.DrawString(sb.ToString(), font, XBrushes.Black, new XRect(20, 80, 20, 0));

            sb = new StringBuilder();
            sb.Append("Dvorana: ").Append(dvorana).Append(", sjedala: ");
            foreach (Button b in sjedala)
            {
                sb.Append(b.Name.Substring(6));
                if (sjedala.IndexOf(b) < sjedala.Count() - 1) sb.Append(", ");
            }
            gfx.DrawString(sb.ToString(), font, XBrushes.Black, new XRect(20, 110, 20, 0));

            sb = new StringBuilder();
            sb.Append("Vrijeme: ").Append(termin);
            gfx.DrawString(sb.ToString(), font, XBrushes.Black, new XRect(20, 140, 20, 0));

            sb = new StringBuilder();
            sb.Append("Cijena: ").Append(cijena).Append("kn");
            gfx.DrawString(sb.ToString(), font, XBrushes.Black, new XRect(20, 170, 20, 0));

            string filename = new StringBuilder().Append("Racun").Append(brojRacuna.ToString()).Append(".pdf").ToString();
            document.Save(filename);

            Process.Start(filename);
        }

        private void FormPodaci_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from filmovi where id = " + id_filma, cn);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            Hide();
            Form3 form = new Form3(dr["dvorana"].ToString(), dr["naslov"].ToString(), dr["termin"].ToString());
            form.ShowDialog();
            Close();
        }
    }
}
