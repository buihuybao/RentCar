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
    public partial class rentcar : Form
    {
        Main main = new Main();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        public rentcar(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        public rentcar()
        {
        }

        private void rentcar_Load(object sender, EventArgs e)
        {
            LoadDB();
            main.LoadRent();
            main.LoadAvailable();
        }
        public void FillCombox(String TableName, ComboBox ComboName, int FieldNumber)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("select * from " + TableName + "", con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ComboName.Items.Add(dr[FieldNumber]);
            }
            con.Close();
        }
        public void FillComboxCar(String TableName, ComboBox ComboName, int FieldNumber)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("select * from " + TableName + " where carstatus = '0'", con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ComboName.Items.Add(dr[FieldNumber]);
            }
            con.Close();
        }
        public void LoadDB()
        {
            FillCombox("Customers", comboBox1, 2);
            FillComboxCar("Car", comboBox2, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("update Car set carstatus=1 where id=@idcar", con);
            cm.Parameters.AddWithValue("@idcar", comboBox2.Text);
            cm.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show(comboBox2.Text);

            con.Open();
            cm = new SqlCommand("insert into RentCar(idRent, customerID, customerCar) values(@id, @cusID, @cusCar)", con);
            Random r = new Random();
            int id = r.Next(100000, 1000000);
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@cusID", comboBox1.Text);
            cm.Parameters.AddWithValue("@cusCar", comboBox2.Text);
            cm.ExecuteNonQuery();
            con.Close();
            main.LoadRent();
            main.LoadAvailable();
            main.LoadOrder();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
