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
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        public string username;
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createUser create = new createUser();
            create.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserNameLogin.Text == "")
            {
                MessageBox.Show("You have to enter username");
                txtUserNameLogin.Select();
                return;
            }
            else if (txtPasswordLogin.Text == "")
            {
                MessageBox.Show("You have to enter password");
                txtPasswordLogin.Select();
                return;
            }

            con.Open();
            string sql = "select * from Users where username like @username and password like @password";
            SqlCommand cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@username", txtUserNameLogin.Text);
            cm.Parameters.AddWithValue("@password", txtPasswordLogin.Text);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                username = txtUserNameLogin.Text;
                Main f = new Main();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No success");
            }
            dr.Close();
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
