using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KinoApp
{

    public partial class Form3 : Form
    {
        string dvorana, film, termin;
        int velicina, id_filma;
        public const int MalaDvorana = 50;
        public const int SrednjaDvorana = 90;
        public const int VelikaDvorana = 120;

        List<Button> sjedala = new List<Button>();
        List<Button> rezerviranaSjedala = new List<Button>();
        List<Button> oznacenaSjedala = new List<Button>();
        List<Button> otkaziSjedala = new List<Button>();
        public SqlConnection cn = new SqlConnection("Data Source=PC-00\\IVONASQL;Initial Catalog=KinoDB;Integrated Security=True");

        public Form3(string dvorana, string film, string termin)
        {
            this.dvorana = dvorana;
            this.film = film;
            this.termin = termin;
            InitializeComponent();
            oznacenaSjedala.Clear();
        }

        private void dvorane_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void rezerviraj_Click(object sender, EventArgs e)
        {
            if (oznacenaSjedala.Count == 0)
            {
                MessageBox.Show("Nema označenih sjedala!");
                return;
            }
            Hide();
            FormPodaci unosPodataka = new FormPodaci(oznacenaSjedala, id_filma);
            unosPodataka.ShowDialog();
            Close();
        }

        private void filmovi_dvorana_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2(dvorana);
            form2.ShowDialog();
            Close();
        }

        private void termini_filma_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4(film);
            form4.ShowDialog();
            Close();
        }

        private void otkazi_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int id = Int32.Parse(otkaziSjedala[0].Name.Substring(6).ToString());
            SqlCommand brisi = new SqlCommand("delete from rezervacije where sjedalo = " + id + " and  id_filma = " + id_filma, cn);
            brisi.ExecuteNonQuery();
            otkaziSjedala[0].BackColor = Color.Gray;
            rezerviranaSjedala.Remove(otkaziSjedala[0]);
            otkaziSjedala.Clear();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand query = new SqlCommand("select * from filmovi where naslov = '" + film + "' and dvorana = '" + dvorana + "' and termin = '" + termin + "'", cn);
            SqlDataReader dr = query.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (dr.Read()) {
                id_filma = Int32.Parse(dr["id"].ToString());
                sb.Append("Ime filma: ").Append(dr["naslov"].ToString()).Append("\nDvorana: ")
                    .Append(dr["dvorana"].ToString()).Append("\nVrijeme: ").Append(dr["termin"].ToString())
                    .Append("\nRedatelj: ").Append(dr["redatelj"].ToString()).Append("\nŽanr: ").Append(dr["zanr"].ToString()).
                    Append("\nTrajanje: ").Append(dr["trajanje"].ToString()).Append(" min")
                    .Append("\nSlobodnih mjesta: ");
            }
            dr.Close();

            SqlCommand velicinaQuery = new SqlCommand("select velicina from Dvorane where ime = '" + dvorana + "'", cn);
            dr = velicinaQuery.ExecuteReader();
            dr.Read();
            velicina = Int32.Parse(dr["velicina"].ToString());
            dr.Close();

            filmovi_dvorana.Text = dvorana;

            nacrtajSjedala(velicina);

            // uredi buttone
            foreach (Button b in Controls.OfType<Button>().ToList())
            {
                for (int i = 1; i <= velicina; i++)
                {
                    if (b.Name == String.Format("button{0}", i) && !sjedala.Contains(b))
                    {
                        sjedala.Add(b);
                        b.Text = "";
                    }
                }
            }

            //oboji zuto one koji su rezervirani
            SqlCommand rezervirani = new SqlCommand("select * from Rezervacije where id_filma = '" + id_filma + "'", cn);
            dr = rezervirani.ExecuteReader();
            while(dr.Read())
            {
                int sjedalo = Int32.Parse(dr["sjedalo"].ToString());
                foreach (Button b in sjedala)
                {
                    if (b.Name == String.Format("button{0}", sjedalo))
                    {
                        b.BackColor = Color.Yellow;
                        if(!rezerviranaSjedala.Contains(b))
                        {
                            rezerviranaSjedala.Add(b);
                        }
                    }
                }
            }

            dr.Close();

            foreach(Button b in sjedala)
            {
                b.Click += oznaciSjedalo;
            }

            sb.Append(sjedala.Count() - rezerviranaSjedala.Count());
            Label infoFilm = new Label();
            infoFilm.Text = sb.ToString();
            infoFilm.Location = new Point(20, 20);
            infoFilm.AutoSize = true;
            this.Controls.Add(infoFilm);
        }

        private void oznaciSjedalo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.BackColor == Color.Yellow)
            {
                
                int sj = Int32.Parse(button.Name.Substring(6));
                SqlCommand rezervirani2 = new SqlCommand("select * from Rezervacije where id_filma = '" + id_filma + "' and sjedalo = " + sj, cn);
                SqlDataReader dr2 = rezervirani2.ExecuteReader();
                dr2.Read();
                MessageBox.Show(dr2["ime"].ToString() + " " + dr2["prezime"].ToString());
                dr2.Close();

                otkaziSjedala.Add(button);
                
                
            }
            if (oznacenaSjedala.Contains(button))
            {
                button.BackColor = Color.Gray;
                oznacenaSjedala.Remove(button);
            } else if (!rezerviranaSjedala.Contains(button))
            {
                button.BackColor = Color.Red;
                oznacenaSjedala.Add(button);
            } 
        }

        private void nacrtajSjedala(int velicina)
        {
            int brojRedova = 0;
            switch(velicina)
            {
                case MalaDvorana:
                    brojRedova = 5;
                    break;
                case SrednjaDvorana:
                    brojRedova = 6;
                    break;
                case VelikaDvorana:
                    brojRedova = 8;
                    break;
            }
            for (int i = 0; i < brojRedova; i++)
            {
                for (int j = 0; j < velicina/brojRedova; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(20, 20);
                    b.BackColor = Color.Gray;
                    b.Anchor = AnchorStyles.Bottom;
                    b.Name = new StringBuilder().Append("button").Append(i*(velicina/brojRedova) + j + 1).ToString();
                    b.Location = new Point(30 + b.Size.Width * j + 5 * j, 120 + b.Size.Height * i + 5 * i);
                    this.Controls.Add(b);
                }
             }
        }
    }
    
}
