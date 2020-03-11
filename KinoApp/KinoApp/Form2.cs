using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoApp
{
    public partial class Form2 : Form
    {
        string dvorana;
        public string datum = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");
        public SqlConnection cn = new SqlConnection("Data Source=PC-00\\IVONASQL;Initial Catalog=KinoDB;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String dvorana)
        {
            InitializeComponent();
            this.dvorana = dvorana;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand query = new SqlCommand("select velicina from Dvorane where ime = '" + dvorana + "'", cn);
            SqlDataReader dr = query.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            sb.Append(dvorana).Append("\nVelicina dvorane: ");

            while (dr.Read()) {
                sb.Append(dr["velicina"].ToString()).Append(" sjedala");
            }
            dr.Close();

            Label dvoranaLabel = new Label();
            dvoranaLabel.Text = sb.ToString();
            dvoranaLabel.Location = new Point(20, 20);
            dvoranaLabel.AutoSize = true;
            this.Controls.Add(dvoranaLabel);

            SqlCommand filmquery = new SqlCommand("select naslov, termin from Filmovi where dvorana = '" + dvorana + "' order by termin", cn);
            dr = filmquery.ExecuteReader();
            while (dr.Read())
            {
                if (dr["termin"].ToString().CompareTo(datum) >= 0)
                {
                    string[] row = { dr["naslov"].ToString(), dr["termin"].ToString() };
                    ListViewItem item = new ListViewItem(row);
                    filmovi.Items.Add(item);
                }
            }

        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();
        }

        private void filmovi_Click(object sender, EventArgs e)
        {
            string film = filmovi.SelectedItems[0].Text;
            string termin = filmovi.SelectedItems[0].SubItems[1].Text;
            Hide();
            Form3 form3 = new Form3(dvorana, film, termin);
            form3.ShowDialog();
            Close();
        }
    }
}
