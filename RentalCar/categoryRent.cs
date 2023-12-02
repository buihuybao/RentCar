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
        Main main = new Main();
        public categoryRent(Main main)
        {

            InitializeComponent();
            this.main = main;
        }

        public categoryRent()
        {
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
                DateTime curentDay = DateTime.Now;
                int day = curentDay.Day;
                int month = curentDay.Month;
                int year = curentDay.Year;
                string end = day + "/" + month + "/" + year;
                string sqlDelete = "Update RentCar set status = 1, endRent = @end where idRent like '" + grvCategoryRent.CurrentRow.Cells[0].Value + "'";
                SqlCommand cm = new SqlCommand(sqlDelete, con);
                cm.Parameters.AddWithValue("@end", end);
                cm.ExecuteNonQuery();

                SqlCommand cmu = new SqlCommand("update Car set carstatus= 0 where id= '" + grvCategoryRent.CurrentRow.Cells[2].Value + "'", con);
                cmu.ExecuteNonQuery();
                MessageBox.Show("Update successfully");
                
                con.Close();
                LoadGrvRent();
                main.LoadAvailable();
                main.LoadOrder();
                main.LoadRent();
                
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
                grvCategoryRent.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

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

        private void button3_Click(object sender, EventArgs e)
        {
            grvCategoryRent.SelectAll();
            DataObject copydata = grvCategoryRent.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void txtCusPhoneSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grvCategoryRent.Rows.Clear();
            int i = 0;
            con.Open();
            SqlCommand cm = new SqlCommand();

            //cm.Parameters.AddWithValue("@txtSearch", txtIDCarSeacrh.Text);
            if (txtIDRentSearch.Text != "")
            {
                string sql = "select * from RentCar where idRent Like  @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtIDRentSearch.Text);
            }
            else if (txtIDCusSearch.Text != "")
            {
                string sql = "select * from RentCar where customerID Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtIDCusSearch.Text);
            }
            else if (txtCarIDSearch.Text != "")
            {
                string sql = "select * from RentCar where customerCar Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtCarIDSearch.Text);
            }
            else if (startSearch.Text != "" || endSearch.Text != "")
            {
                string sql = "select * from RentCar where startSearch Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", startSearch.Text);
            }
            else if (statusSearch.Text != "")
            {
                string sql = "select * from RentCar where  Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", statusSearch.Text);
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grvCategoryRent.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            labelCountRent.Text = i.ToString();
            con.Close();
        }

        private void txtIDCusSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCusSearch.Text != "")
            {
                txtIDRentSearch.Enabled = false;
                txtCarIDSearch.Enabled = false;
                startSearch.Enabled = false;
                endSearch.Enabled = false;
                statusSearch.Enabled = false;
            }
        }

        private void labelCountRent_Click(object sender, EventArgs e)
        {

        }

        private void txtIDRentSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtIDRentSearch.Text != "")
            {
                txtIDCusSearch.Enabled = false;
                txtCarIDSearch.Enabled = false;
                startSearch.Enabled = false;
                endSearch.Enabled = false;
                statusSearch.Enabled = false;
            }
        }

        private void txtCarIDSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCarIDSearch.Text != "")
            {
                txtIDRentSearch.Enabled = false;
                txtIDCusSearch.Enabled = false;
                startSearch.Enabled = false;
                endSearch.Enabled = false;
                statusSearch.Enabled = false;
            }
        }

        private void statusSearch_TextChanged(object sender, EventArgs e)
        {
            if (statusSearch.Text != "")
            {
                txtIDRentSearch.Enabled = false;
                txtIDCusSearch.Enabled = false;
                txtCarIDSearch.Enabled = false;
                startSearch.Enabled = false;
                endSearch.Enabled = false;
            }
        }
    }
}
