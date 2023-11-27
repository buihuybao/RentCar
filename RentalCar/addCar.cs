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
using RentalCar;

namespace RentalCar
{
    public partial class addCar : Form
    {
        categoryCar f = new categoryCar();
        public addCar(categoryCar f)
        {
            InitializeComponent();
            this.f = f;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.OpenImage(pic);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string checksql = "select * from Car where id = @idcheck";
            SqlCommand checkcmd = new SqlCommand(checksql, con);
            checkcmd.Parameters.AddWithValue("@idcheck", txtCreateCarID.Text);
            SqlDataReader checkdr = checkcmd.ExecuteReader();
            if (checkdr.Read())
            {
                MessageBox.Show("Car already exists. Please choose another code!");
            }else
            {
                checkdr.Close();
                string sql = "insert into Car(id, carname, carcolor, carmodel, carimg) values (@id, @carname, @carcolor, @carmodel, @carimg)";
                SqlCommand cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@id", txtCreateCarID.Text);
                cm.Parameters.AddWithValue("@carname", txtCreateCarName.Text);
                cm.Parameters.AddWithValue("@carcolor", txtCreateCarColor.Text);
                cm.Parameters.AddWithValue("@carmodel", txtCreateCarModel.Text);
                db.ConvertImageToSave(pic);
                cm.Parameters.AddWithValue("@carimg", db._img);
                cm.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
                f.LoadCars();
            }    


            con.Close();
            txtCreateCarID.Clear();
            txtCreateCarName.Clear();
            txtCreateCarColor.Clear();
            txtCreateCarModel.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCar_Load(object sender, EventArgs e)
        {

        }

        private void txtCreateCarModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
