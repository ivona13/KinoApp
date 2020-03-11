using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KinoApp
{
    public partial class Form1 : Form
    {
        public SqlConnection cn = new SqlConnection("Data Source=PC-00\\IVONASQL;Initial Catalog=KinoDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }

            SqlCommand query = new SqlCommand("select * from Dvorane", cn);
            SqlDataReader dr;
            try
            {
                dr = query.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["ime"].ToString());
                    dvorane.Items.Add(item);
                }
                dr.Close();
            } catch (SqlException) { }
            SqlCommand filmovi = new SqlCommand("select * from Filmovi", cn);
            try
            {
                dr = filmovi.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["naslov"].ToString());
                    if (popis_filmova.FindItemWithText(item.Text) == null)
                    {
                        popis_filmova.Items.Add(item);
                    }
                }  
            }
            catch (SqlException) { }
        }

        private void dvorane_Click(object sender, EventArgs e)
        {
            string dvorana = dvorane.SelectedItems[0].Text;
            Hide();
            Form2 form2 = new Form2(dvorana);
            form2.ShowDialog();
            Close();
        }

        private void popis_filmova_Click(object sender, EventArgs e)
        {
            string film = popis_filmova.SelectedItems[0].Text;
            Hide();
            Form4 form4 = new Form4(film);
            form4.ShowDialog();
            Close();
        }

        private void osoblje_Click(object sender, EventArgs e)
        {
            Hide();
            Osoblje osoblje = new Osoblje();
            osoblje.ShowDialog();
            Close();
        }
    }
}
