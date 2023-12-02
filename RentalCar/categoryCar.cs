using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace RentalCar
{
    public partial class categoryCar : Form
    {
        Main main = new Main();
        public categoryCar(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        public categoryCar()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            main.LoadAvailable();
            main.LoadRent();
        }

        public void LoadCars()
        {
            int i = 0;
            dataGrvCategory.Rows.Clear();
            db.con.Open();
            string sql = "select * from Car";
            db.cm = new SqlCommand(sql, db.con);
            SqlDataReader dr = db.cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrvCategory.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            labelCount.Text = i.ToString();
            db.con.Close();
            //Dispose();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void categoryCar_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnCreateNewCar_Click(object sender, EventArgs e)
        {
            addCar f = new addCar(this);
            f.ShowDialog();
        }

        private void dataGrvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrvCategory.Columns[e.ColumnIndex].Name;
            if(colName == "colEdit")
            {
                db.con.Open();
                updateCar update = new updateCar(this);
                string idcar = (string)dataGrvCategory.CurrentRow.Cells[0].Value;
                string carname = (string)dataGrvCategory.CurrentRow.Cells[1].Value;
                string carcolor = (string)dataGrvCategory.CurrentRow.Cells[2].Value;
                string carmodel = (string)dataGrvCategory.CurrentRow.Cells[3].Value;
                update.txtUpdateCarID.Text = idcar;
                update.txtUpdateCarName.Text = carname;
                update.txtUpdateCarColor.Text = carcolor;
                update.txtUpdateCarModel.Text = carmodel;

                object cellValue = dataGrvCategory.CurrentRow.Cells[4].Value;

                // Kiểm tra nếu giá trị là null hoặc không phải là mảng byte
                if (cellValue != null && cellValue is byte[] img)
                {
                    MemoryStream ms = new MemoryStream(img);
                    update.picUpdate.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Have a err!");
                }
                update.Show();
                db.con.Close();

            }
            else if(colName == "colDelete")
            {
                db.con.Open();
                string sqlDelete = "Delete from Car where id like '"+ dataGrvCategory.CurrentRow.Cells[0].Value +"'";
                SqlCommand cm = new SqlCommand(sqlDelete, db.con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                db.con.Close();
                LoadCars();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGrvCategory.Rows.Clear();
            int i = 0;
            db.con.Open();
            SqlCommand cm = new SqlCommand();

            if (txtIDCarSeacrh.Text != "")
            {
                string sql = "select * from Car where id Like  @txtSearch";
                cm = new SqlCommand(sql, db.con);
                cm.Parameters.AddWithValue("@txtSearch", txtIDCarSeacrh.Text);
            }
            else if (txtNameCarSearch.Text != "")
            {
                string sql = "select * from Car where carname Like @txtSearch";
                cm = new SqlCommand(sql, db.con);
                cm.Parameters.AddWithValue("@txtSearch", txtNameCarSearch.Text);
            }
            else if (txtColorCarSearch.Text != "")
            {
                string sql = "select * from Car where carcolor Like @txtSearch";
                cm = new SqlCommand(sql, db.con);
                cm.Parameters.AddWithValue("@txtSearch", txtColorCarSearch.Text);
            }
            else if (txtModelCarSearch.Text != "")
            {
                string sql = "select * from Car where carmodel Like @txtSearch";
                cm = new SqlCommand(sql, db.con);
                cm.Parameters.AddWithValue("@txtSearch", txtModelCarSearch.Text);
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGrvCategory.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            labelCount.Text = i.ToString();
            db.con.Close();
        }

        private void txtIDCarSeacrh_TextChanged(object sender, EventArgs e)
        {
            if(txtIDCarSeacrh.Text != "")
            {
                txtNameCarSearch.Enabled = false;
                txtColorCarSearch.Enabled = false;
                txtModelCarSearch.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtModelCarSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtModelCarSearch.Text != "")
            {
                txtNameCarSearch.Enabled = false;
                txtColorCarSearch.Enabled = false;
                txtIDCarSeacrh.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtColorCarSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtColorCarSearch.Text != "")
            {
                txtNameCarSearch.Enabled = false;
                txtIDCarSeacrh.Enabled = false;
                txtModelCarSearch.Enabled = false;
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void txtNameCarSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtNameCarSearch.Text != "")
            {
                txtIDCarSeacrh.Enabled = false;
                txtColorCarSearch.Enabled = false;
                txtModelCarSearch.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string filepath = op.FileName;
                string cn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml; HDR=YES; IMEX=1'";
                //string cn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml; HDR = YES'";
                cn = string.Format(cn, filepath, "yes");
                OleDbConnection excelconnection = new OleDbConnection(cn);
                excelconnection.Open();
                System.Data.DataTable dtexcel = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
                OleDbCommand cm = new OleDbCommand("select * from [" + excelsheet + "]", excelconnection);
                OleDbDataAdapter oda = new OleDbDataAdapter(cm);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                excelconnection.Close();
                dataGrvCategory.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGrvCategory.SelectAll();
            DataObject copydata = dataGrvCategory.GetClipboardContent();
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

        private void dataGrvCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
