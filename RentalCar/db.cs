using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace RentalCar { 
    internal class db
    {
        protected private static string DBName = "RentalCar";
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ST9DD9Q;Initial Catalog=RentalCar;Integrated Security=True");
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlDataReader dr = null;

        public static int _id = 0;
        public static byte[] _img;






        ////public static void FillCombo(string TableName, ComboBox ComboName, int FieldNumber)
        ////{
        ////    cn.Open();
        ////    cm = new SqlCommand("select * from " + TableName + "", cn);
        ////    dr = cm.ExecuteReader();
        ////    while (dr.Read())
        ////    {
        ////        ComboName.Items.Add(dr[FieldNumber]);
        ////    }
        ////    cn.Close();
        ////}


        public static void ConvertImageToSave(PictureBox PictureBoxName)
        {
            MemoryStream ms = new MemoryStream();
            PictureBoxName.Image.Save(ms, PictureBoxName.Image.RawFormat);
            byte[] img = ms.ToArray();
            _img = img;
            ms.Close();
        }

        public static void OpenImage(PictureBox NamePictureBox)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose image |*.png;*.bmp;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NamePictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }
        public static void ShowImageinPictureBox(PictureBox PictureBoxName, DataGridView Dgv, int NumberCell)
        {
            byte[] img = (byte[])Dgv.CurrentRow.Cells[NumberCell].Value;
            MemoryStream ms = new MemoryStream(img);
            PictureBoxName.Image = Image.FromStream(ms);
        }





    }



}