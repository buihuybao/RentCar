using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar
{
    public partial class categoryCar : Form
    {
        Main main = new Main();
        public categoryCar(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        public categoryCar()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            main.LoadAvailable();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");

        public void LoadCars()
        {
            int i = 0;
            dataGrvCategory.Rows.Clear();
            con.Open();
            string sql = "select * from Car";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void categoryCar_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnCreateNewCar_Click(object sender, EventArgs e)
        {
            addCar f = new addCar(this);
            f.ShowDialog();
        }

        private void dataGrvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrvCategory.Columns[e.ColumnIndex].Name;
            if(colName == "colEdit")
            {
                con.Open();
                updateCar update = new updateCar(this);
                string idcar = (string)dataGrvCategory.CurrentRow.Cells[0].Value;
                string carname = (string)dataGrvCategory.CurrentRow.Cells[1].Value;
                string carcolor = (string)dataGrvCategory.CurrentRow.Cells[2].Value;
                string carmodel = (string)dataGrvCategory.CurrentRow.Cells[3].Value;
                update.txtUpdateCarID.Text = idcar;
                update.txtUpdateCarName.Text = carname;
                update.txtUpdateCarColor.Text = carcolor;
                update.txtUpdateCarModel.Text = carmodel;

                object cellValue = dataGrvCategory.CurrentRow.Cells[4].Value;

                // Kiểm tra nếu giá trị là null hoặc không phải là mảng byte
                if (cellValue != null && cellValue is byte[] img)
                {
                    MemoryStream ms = new MemoryStream(img);
                    update.picUpdate.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Have a err!");
                }
                update.Show();
                con.Close();

            }
            else if(colName == "colDelete")
            {
                con.Open();
                string sqlDelete = "Delete from Car where id like '"+ dataGrvCategory.CurrentRow.Cells[0].Value +"'";
                SqlCommand cm = new SqlCommand(sqlDelete, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                con.Close();
                LoadCars();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGrvCategory.Rows.Clear();
            int i = 0;
            con.Open();
            SqlCommand cm = new SqlCommand();

            if (txtIDCarSeacrh.Text != "")
            {
                string sql = "select * from Car where id Like  @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtIDCarSeacrh.Text);
            }
            else if (txtNameCarSearch.Text != "")
            {
                string sql = "select * from Car where carname Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtNameCarSearch.Text);
            }
            else if (txtColorCarSearch.Text != "")
            {
                string sql = "select * from Car where carcolor Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtColorCarSearch.Text);
            }
            else if (txtModelCarSearch.Text != "")
            {
                string sql = "select * from Car where carmodel Like @txtSearch";
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

        private void txtIDCarSeacrh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtModelCarSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtColorCarSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void txtNameCarSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
