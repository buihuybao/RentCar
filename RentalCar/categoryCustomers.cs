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
    public partial class categoryCustomers : Form
    {
        Main main = new Main();
        public categoryCustomers(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        public categoryCustomers()
        {
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        private void dataGrvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            main.LoadCustomers();
        }
        public void LoadCustomers()
        {
            int i = 0;
            dataGrvCategoryCustomer.Rows.Clear();
            con.Open();
            string sql = "select * from Customers";
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrvCategoryCustomer.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

            }
            con.Close();
            labeltotal.Text = i.ToString();
        }
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            createCustomer f = new createCustomer(this);
            f.Show();
        }

        private void categoryCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        public string IDCus;
        public void dataGrvCategoryCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrvCategoryCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                con.Open();
                updateCus update = new updateCus(this);
                string ID = (string)dataGrvCategoryCustomer.CurrentRow.Cells[0].Value;
                ////String ID = id.ToString();
                IDCus = ID;
                string cusname = (string)dataGrvCategoryCustomer.CurrentRow.Cells[1].Value;
                string cusid = (string)dataGrvCategoryCustomer.CurrentRow.Cells[2].Value;
                string cusphone = (string)dataGrvCategoryCustomer.CurrentRow.Cells[3].Value;
                string cusaddress = (string)dataGrvCategoryCustomer.CurrentRow.Cells[4].Value;

                update.txtUpdateNameCus.Text = cusname;
                update.txtUpdateIDCus.Text = cusid;
                update.txtUpdatePhoneCus.Text = cusphone;
                update.txtUpdateAddressCus.Text = cusaddress;
                object cellValue = dataGrvCategoryCustomer.CurrentRow.Cells[5].Value;

                // Kiểm tra nếu giá trị là null hoặc không phải là mảng byte
                if (cellValue != null && cellValue is byte[] img)
                {
                    MemoryStream ms = new MemoryStream(img);
                    update.imgUpdateCus.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Have a err!");
                }
                
                update.Show();
                con.Close();
            }
            else if (colName == "colDelete")
            {
                con.Open();
                string sqlDelete = "Delete from Customers where ID like '" + dataGrvCategoryCustomer.CurrentRow.Cells[0].Value + "'";
                SqlCommand cm = new SqlCommand(sqlDelete, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                con.Close();
                LoadCustomers();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIDCarSeacrh_TextChanged(object sender, EventArgs e)
        {
            if(txtCusIDSearch.Text != null)
            {
                txtCusAddSearch.Enabled = false;
                txtCusPhoneSearch.Enabled = false;
                txtCusNameSearch.Enabled = false;
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void txtNameCarSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCusNameSearch.Text != null)
            {
                txtCusAddSearch.Enabled = false;
                txtCusPhoneSearch.Enabled = false;
                txtCusIDSearch.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtColorCarSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCusIDSearch.Text != null)
            {
                txtCusAddSearch.Enabled = false;
                txtCusPhoneSearch.Enabled = false;
                txtCusIDSearch.Enabled = false;
                txtCusNameSearch.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGrvCategoryCustomer.Rows.Clear();
            int i = 0;
            con.Open();
            SqlCommand cm = new SqlCommand();

            //cm.Parameters.AddWithValue("@txtSearch", txtIDCarSeacrh.Text);
            if (txtCusNameSearch.Text != "")
            {
                string sql = "select * from Customers where customerName Like  @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtCusNameSearch.Text);
            }
            else if (txtCusIDSearch.Text != "")
            {
                string sql = "select * from Customers where customerID Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtCusIDSearch.Text);
            }
            else if (txtCusPhoneSearch.Text != "")
            {
                string sql = "select * from Customers where customerPhone Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtCusPhoneSearch.Text);
            }
            else if (txtCusAddSearch.Text != "")
            {
                string sql = "select * from Customers where customerAddress Like @txtSearch";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@txtSearch", txtCusAddSearch.Text);
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrvCategoryCustomer.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            labeltotal.Text = i.ToString();
            con.Close();
        }

        private void txtModelCarSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGrvCategoryCustomer.SelectAll();
            DataObject copydata = dataGrvCategoryCustomer.GetClipboardContent();
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

        private void txtNameSeacrh_TextChanged(object sender, EventArgs e)
        {
            if (txtCusNameSearch.Text != null)
            {
                txtCusAddSearch.Enabled = false;
                txtCusPhoneSearch.Enabled = false;
                txtCusIDSearch.Enabled = false;
            }
        }

        private void txtIDSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCusIDSearch.Text != null)
            {
                txtCusAddSearch.Enabled = false;
                txtCusPhoneSearch.Enabled = false;
                txtCusNameSearch.Enabled = false;
            }
        }

        private void txtPhoneSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCusPhoneSearch.Text != null)
            {
                txtCusAddSearch.Enabled = false;
                txtCusIDSearch.Enabled = false;
                txtCusNameSearch.Enabled = false;
            }
        }

        private void txtAddSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCusAddSearch.Text != null)
            {
                txtCusPhoneSearch.Enabled = false;
                txtCusIDSearch.Enabled = false;
                txtCusNameSearch.Enabled = false;
            }
        }
    }
}
