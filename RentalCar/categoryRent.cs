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
    public partial class categoryRent : Form
    {
        public categoryRent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");

        private void btnCreateNewCar_Click(object sender, EventArgs e)
        {
            rentcar f = new rentcar();
            f.ShowDialog();
        }

        public void dataGrvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grvCategoryRent.Columns[e.ColumnIndex].Name;
            if (colName == "colinformation")
            {
                con.Open();
                fullinforRent f = new fullinforRent(this);
                f.label14.Text = (string)grvCategoryRent.CurrentRow.Cells[0].Value;
                string sqlCustomer = "select * from Customers where customerID = '" + grvCategoryRent.CurrentRow.Cells[1].Value + "' ";
                SqlCommand cm = new SqlCommand(sqlCustomer, con);
                SqlDataReader dr = cm.ExecuteReader();

                if (dr.HasRows)
                {
                    // Có dữ liệu trả về từ truy vấn
                    if (dr.Read())
                    {
                        f.idcustomer.Text = dr[0].ToString();
                        f.namecustomer.Text = dr[1].ToString();
                        f.phonecustomer.Text = dr[2].ToString();
                        f.addresscustomer.Text = dr[3].ToString();

                        object cellValue = dr[4];

                        // Kiểm tra nếu giá trị là null hoặc không phải là mảng byte
                        if (cellValue != null && cellValue is byte[] img)
                        {
                            MemoryStream ms = new MemoryStream(img);
                            f.pictureBox1.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            MessageBox.Show("Have a err!");
                        }
                    }
                }
                else
                {
                    // Không có dữ liệu trả về
                    MessageBox.Show("No data found for the specified ID.");
                }
                dr.Close();

                string sqlCar = "select * from Car where id = '" + grvCategoryRent.CurrentRow.Cells[2].Value + "' ";
                SqlCommand cmc = new SqlCommand(sqlCar, con);
                SqlDataReader drc = cmc.ExecuteReader();

                if (drc.HasRows)
                {
                    // Có dữ liệu trả về từ truy vấn
                    if (drc.Read())
                    {
                        f.idcar.Text = drc[0].ToString();
                        f.namecar.Text = drc[1].ToString();
                        f.colorcar.Text = drc[2].ToString();
                        f.modelcar.Text = drc[3].ToString();
                    }
                }
                else
                {
                    // Không có dữ liệu trả về
                    MessageBox.Show("No data found for the specified ID.");
                }

                f.ShowDialog();
                dr.Close(); // Đóng SqlDataReader khi không cần sử dụng nữa
                con.Close();

            }
            else if (colName == "colDelete")
            {
                con.Open();
                string sqlDelete = "Delete from RentCar where idRent like '" + grvCategoryRent.CurrentRow.Cells[0].Value + "'";
                SqlCommand cm = new SqlCommand(sqlDelete, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                
                con.Close();
                LoadGrvRent();
                
            }
        }

        public void LoadGrvRent()
        {
            int i = 0;
            grvCategoryRent.Rows.Clear();
            con.Open();
            string sql = "select * from RentCar";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grvCategoryRent.Rows.Add(dr[0], dr[1], dr[2]);

            }
            con.Close();
            labelCountRent.Text = "Lable Rent: " + i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void categoryRent_Load(object sender, EventArgs e)
        {
            LoadGrvRent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
