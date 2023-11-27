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
    public partial class updateCar : Form
    {
        categoryCar f = new categoryCar();
        public updateCar(categoryCar f)
        {
            InitializeComponent();
            this.f = f;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.con.Open();
            string sqlEdit = "update Car set carname = @carname, carcolor = @carcolor, carmodel=@carmodel, carimg=@carimg where id like @carID";
            SqlCommand cm = new SqlCommand(sqlEdit, db.con);
            cm.Parameters.AddWithValue("@carID", txtUpdateCarID.Text);
            cm.Parameters.AddWithValue("@carname", txtUpdateCarName.Text);
            cm.Parameters.AddWithValue("@carcolor", txtUpdateCarColor.Text);
            cm.Parameters.AddWithValue("@carmodel", txtUpdateCarModel.Text);
            db.ConvertImageToSave(picUpdate);
            cm.Parameters.AddWithValue("@carimg", db._img);
            cm.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            f.LoadCars();
            db.con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.OpenImage(picUpdate);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUpdateCarColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void picUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
