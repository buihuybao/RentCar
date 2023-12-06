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

namespace RentalCar
{
    public partial class ListCarRent : Form
    {
        public ListCarRent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGrvCategory.Rows.Clear();
            int i = 0;
            con.Open();
            SqlCommand cm = new SqlCommand();

            //cm.Parameters.AddWithValue("@txtSearch", txtIDCarSeacrh.Text);
            if (txtIDCarSeacrh.Text != "")
            {
                string sql = "select * from Car where carstatus=1 and id Like  @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtIDCarSeacrh.Text);
            }
            else if (txtNameCarSearch.Text != "")
            {
                string sql = "select * from Car where carstatus=1 and carname Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtNameCarSearch.Text);
            }
            else if (txtColorCarSearch.Text != "")
            {
                string sql = "select * from Car where carstatus=1 and carcolor Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtColorCarSearch.Text);
            }
            else if (txtModelCarSearch.Text != "")
            {
                string sql = "select * from Car where carstatus=1 and carmodel Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtModelCarSearch.Text);
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrvCategory.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            labelCount.Text = i.ToString();
            con.Close();
        }
        public void LoadCars()
        {
            int i = 0;
            dataGrvCategory.Rows.Clear();
            con.Open();
            string sql = "select * from Car where carstatus=1";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrvCategory.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            labelCount.Text = i.ToString();
            con.Close();
            //Dispose();

        }
        private void ListCarRent_Load(object sender, EventArgs e)
        {
            LoadCars();

        }

        private void dataGrvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtModelCarSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
