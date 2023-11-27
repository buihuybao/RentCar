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

namespace RentalCar
{
    public partial class createUser : Form
    {
        public createUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnlogin_Click(object sender, EventArgs e)
        {
            formlogin log = new formlogin();
            log.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int rd = random.Next(100000, 1000000);


                con.Open();
                string checksql = "select * from Users where username = @idcheck";
                SqlCommand checkcmd = new SqlCommand(checksql, con);
                checkcmd.Parameters.AddWithValue("@idcheck", txtCreateUser.Text);
                SqlDataReader checkdr = checkcmd.ExecuteReader();
                if (checkdr.Read())
                {
                    MessageBox.Show("Car already exists. Please choose another code!");
                }
                else
                {
                    checkdr.Close();
                    con.Open();
                    string sql = "insert into Users(id, username, password) values(@id, @UserName, @Password)";
                    SqlCommand cm = new SqlCommand(sql, con);
                    cm.Parameters.AddWithValue("@UserName", txtCreateUser.Text);
                    cm.Parameters.AddWithValue("@Password", txtCreatePasswordUser.Text);
                    cm.Parameters.AddWithValue("@id", rd);
                    cm.ExecuteNonQuery();
                    txtCreateUser.Clear();
                    txtCreatePasswordUser.Clear();
                    MessageBox.Show("Create user successfully");
                    con.Close();
                    formlogin f = new formlogin();
                    f.Show();
                    this.Dispose();
                    this.Hide();
                }


                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
