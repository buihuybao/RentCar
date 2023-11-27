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
    public partial class updateCus : Form
    {

        categoryCustomers f = new categoryCustomers();

        public updateCus(categoryCustomers f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtCreateIDCus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreatePhoneCus_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.OpenImage(imgUpdateCus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.con.Open();
            string sqlEdit = "update Customers set customerName = @cusname, customerID = @cusid, customerPhone = @cusphone, customerAddress = @cusaddress, customerImg = @cusimg where ID like @id";
            SqlCommand cm = new SqlCommand(sqlEdit, db.con);
            cm.Parameters.AddWithValue("@id", f.IDCus);
            cm.Parameters.AddWithValue("@cusname", txtUpdateNameCus.Text);
            cm.Parameters.AddWithValue("@cusid", txtUpdateIDCus.Text);
            cm.Parameters.AddWithValue("@cusphone", txtUpdatePhoneCus.Text);
            cm.Parameters.AddWithValue("@cusaddress", txtUpdateAddressCus.Text);
            db.ConvertImageToSave(imgUpdateCus);
            cm.Parameters.AddWithValue("@cusimg", db._img);
            cm.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            f.LoadCustomers();
            db.con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgUpdateCus_Click(object sender, EventArgs e)
        {

        }
    }
}
