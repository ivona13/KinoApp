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
    public partial class Osoblje : Form
    {
        public SqlConnection cn = new SqlConnection("Data Source=PC-00\\IVONASQL;Initial Catalog=KinoDB;Integrated Security=True");
        public string dan = DateTime.Now.ToString("yyyy-MM-dd");
        public string vrijeme = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

        public Osoblje()
        {
            InitializeComponent();
        }

        private void Osoblje_Load(object sender, EventArgs e)
        {
            Label datum = new Label();
            datum.Text = new StringBuilder().Append("Zaposlenici i njihova zaduženja na dan: ").Append(dan).ToString();
            datum.Location = new Point(20, 20);
            datum.Height = 20;
            datum.Width = 400;
            Controls.Add(datum);

            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand zaduzenjaQuery = new SqlCommand("select * from Zaduzenja where kraj >='" + vrijeme + "'and pocetak <= '" + vrijeme + "'", cn);
            SqlDataReader dr = zaduzenjaQuery.ExecuteReader();
            while(dr.Read())
            {
                string[] row = { dr["ime"].ToString(), dr["prezime"].ToString(), dr["dvorana"].ToString().Substring(8),
                                dr["pocetak"].ToString().Substring(11), dr["kraj"].ToString().Substring(11) };
                ListViewItem item = new ListViewItem(row);
                zaposlenici.Items.Add(item);
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

      
    }
}
