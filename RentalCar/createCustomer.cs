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
    public partial class createCustomer : Form
    {
        categoryCustomers f = new categoryCustomers();

        public createCustomer(categoryCustomers f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCreateCarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCreateCarModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.OpenImage(imgCustomer);
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string checksql = "select * from Customers where customerID = @idcheck";
            SqlCommand checkcmd = new SqlCommand(checksql, con);
            checkcmd.Parameters.AddWithValue("@idcheck", txtCreateIDCus.Text);
            SqlDataReader checkdr = checkcmd.ExecuteReader();
            if (checkdr.Read())
            {
                MessageBox.Show("Car already exists. Please choose another ID!");
            }
            else
            {
                checkdr.Close();
                con.Open();
                string sql = "insert into Customers(ID, customerName, customerID, customerPhone, customerAddress, customerImg) values (@id, @customername, @customerid, @customerphone, @customerAddress, @customerimg)";
                SqlCommand cm = new SqlCommand(sql, con);
                Random ran = new Random();
                int id = ran.Next(100000, 1000000);
                cm.Parameters.AddWithValue("@id", id);
                cm.Parameters.AddWithValue("@customername", txtCreateNameCus.Text);
                cm.Parameters.AddWithValue("@customerid", txtCreateIDCus.Text);
                cm.Parameters.AddWithValue("@customerphone", txtCreatePhoneCus.Text);
                cm.Parameters.AddWithValue("@customeraddress", txtCreateAddressCus.Text);
                db.ConvertImageToSave(imgCustomer);
                cm.Parameters.AddWithValue("@customerimg", db._img);
                cm.ExecuteNonQuery();
                MessageBox.Show("Create successfully");
                con.Close();
                f.LoadCustomers();
                txtCreateIDCus.Clear();
                txtCreateNameCus.Clear();
                txtCreatePhoneCus.Clear();
                txtCreateAddressCus.Clear();
            }


        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCreateCarColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCreateCarID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
