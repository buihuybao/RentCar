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
    public partial class Main : Form
    {
        formlogin log = new formlogin();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            //int height = Screen.PrimaryScreen.Bounds.Height;
            //int width = Screen.PrimaryScreen.Bounds.Width;
            //this.Width = width -200;
            //this.Height = height - 200;
            //Top = 100;
            //Left = 100;
            //panel1.Width = width - 220;
            //panel1.Left = 10;
            //panel1.Height = height - 220;
            //panel1.Top = 10;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void btnNewCar_Click(object sender, EventArgs e)
        {
            categoryCar ca = new categoryCar(this);
            ca.Show();
        }

        private void btnNewCus_Click(object sender, EventArgs e)
        {
            categoryCustomers f = new categoryCustomers(this);
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            label2.Text = "Hello " + log.username + "!";
            LoadAvailable();
            LoadCustomers();
            LoadRent();
            LoadOrder();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadAvailable()
        {
            int i = 0;
            grvRentVailable.Rows.Clear();
            con.Open();
            string sql = "select * from Car where carstatus = '0'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grvRentVailable.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            con.Close();
            LableCarsAvailable.Text = "Lable Cars Available: " + i.ToString();
        }
        public void LoadRent()
        {
            int i = 0;
            grvRent.Rows.Clear();
            con.Open();
            string sql = "select * from Car where carstatus = '1'";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grvRent.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            con.Close();
            LableCarsRent.Text = "Lable CarsRent: " + i.ToString();
        }
        public void LoadCustomers()
        {
            int i = 0;
            grvcustomer.Rows.Clear();
            con.Open();
            string sql = "select * from Customers";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grvcustomer.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

            }
            con.Close();
            LableCustomers.Text = "Lable Customers: " + i.ToString();
        }
        private void grvRentVali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvRentNoVali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            rentcar f = new rentcar(this);
            f.Show();
        }

        private void dataGrvCategoryCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadOrder()
        {
            int i = 0;
            grvOrder.Rows.Clear();
            con.Open();
            string sql = "select * from RentCar";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grvOrder.Rows.Add(dr[0], dr[1], dr[2]);
            }
            con.Close();
            LabelOrder.Text = "Lable Order: " + i.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ListCarAvailable f = new ListCarAvailable();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ListCarRent f = new ListCarRent();
            f.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            categoryCustomers f = new categoryCustomers(this);
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            categoryRent f = new categoryRent(this);
            f.Show();
        }
    }
}
