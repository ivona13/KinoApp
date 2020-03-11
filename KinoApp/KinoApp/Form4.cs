using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoApp
{
    public partial class Form4 : Form
    {
        string naslovFilma;
        public SqlConnection cn = new SqlConnection("Data Source=PC-00\\IVONASQL;Initial Catalog=KinoDB;Integrated Security=True");
        public string datum = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

        public Form4(String naslovFilma)
        {
            this.naslovFilma = naslovFilma;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand query = new SqlCommand("select * from filmovi where naslov = '" + naslovFilma + "'", cn);
            SqlDataReader dr = query.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            dr.Read();
            sb.Append("Naslov filma: ").Append(dr["naslov"].ToString()).Append("\nRedatelj: ")
              .Append(dr["redatelj"].ToString()).Append("\nŽanr: ").Append(dr["zanr"].ToString())
              .Append("\nTrajanje: ").Append(dr["trajanje"].ToString()).Append(" min");
            dr.Close();

            Label filmLabel = new Label();
            filmLabel.Text = sb.ToString();
            filmLabel.Location = new Point(20, 20);
            filmLabel.AutoSize = true;
            this.Controls.Add(filmLabel);
            dr = query.ExecuteReader();
            //popuni popis termina
            while (dr.Read())
            {
                if (dr["termin"].ToString().CompareTo(datum) >= 0)
                {
                    string[] row = { dr["termin"].ToString(), dr["dvorana"].ToString() };
                    ListViewItem item = new ListViewItem(row);
                    termini.Items.Add(item);
                }
            }
        }

        private void popisFilmova_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void termini_Click(object sender, EventArgs e)
        {
            string termin = termini.SelectedItems[0].Text;
            string dvorana = termini.SelectedItems[0].SubItems[1].Text;
            Hide();
            Form3 form3 = new Form3(dvorana, naslovFilma, termin);
            form3.ShowDialog();
            Close();
        }
    }
}
