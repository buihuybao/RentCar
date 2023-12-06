
namespace RentalCar
{
    partial class categoryCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelCarSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColorCarSearch = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.txtNameCarSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCarSeacrh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnCreateNewCar = new System.Windows.Forms.Button();
            this.dataGrvCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carimg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtModelCarSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtColorCarSearch);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.txtNameCarSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIDCarSeacrh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.btnCreateNewCar);
            this.panel1.Controls.Add(this.dataGrvCategory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 528);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(626, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xuất DS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(641, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(493, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtModelCarSearch
            // 
            this.txtModelCarSearch.Location = new System.Drawing.Point(540, 75);
            this.txtModelCarSearch.Name = "txtModelCarSearch";
            this.txtModelCarSearch.Size = new System.Drawing.Size(89, 20);
            this.txtModelCarSearch.TabIndex = 14;
            this.txtModelCarSearch.TextChanged += new System.EventHandler(this.txtModelCarSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(328, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Màu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtColorCarSearch
            // 
            this.txtColorCarSearch.Location = new System.Drawing.Point(372, 75);
            this.txtColorCarSearch.Name = "txtColorCarSearch";
            this.txtColorCarSearch.Size = new System.Drawing.Size(89, 20);
            this.txtColorCarSearch.TabIndex = 12;
            this.txtColorCarSearch.TextChanged += new System.EventHandler(this.txtColorCarSearch_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(159, 75);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(32, 16);
            this.Name.TabIndex = 11;
            this.Name.Text = "Tên";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // txtNameCarSearch
            // 
            this.txtNameCarSearch.Location = new System.Drawing.Point(203, 75);
            this.txtNameCarSearch.Name = "txtNameCarSearch";
            this.txtNameCarSearch.Size = new System.Drawing.Size(89, 20);
            this.txtNameCarSearch.TabIndex = 10;
            this.txtNameCarSearch.TextChanged += new System.EventHandler(this.txtNameCarSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtIDCarSeacrh
            // 
            this.txtIDCarSeacrh.Location = new System.Drawing.Point(45, 74);
            this.txtIDCarSeacrh.Name = "txtIDCarSeacrh";
            this.txtIDCarSeacrh.Size = new System.Drawing.Size(89, 20);
            this.txtIDCarSeacrh.TabIndex = 8;
            this.txtIDCarSeacrh.TextChanged += new System.EventHandler(this.txtIDCarSeacrh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lọc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.Yellow;
            this.labelCount.Location = new System.Drawing.Point(9, 498);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 20);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "label2";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // btnCreateNewCar
            // 
            this.btnCreateNewCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateNewCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewCar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateNewCar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateNewCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateNewCar.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewCar.Location = new System.Drawing.Point(734, 3);
            this.btnCreateNewCar.Name = "btnCreateNewCar";
            this.btnCreateNewCar.Size = new System.Drawing.Size(188, 43);
            this.btnCreateNewCar.TabIndex = 5;
            this.btnCreateNewCar.Text = "Thêm Xe Mới";
            this.btnCreateNewCar.UseVisualStyleBackColor = false;
            this.btnCreateNewCar.Click += new System.EventHandler(this.btnCreateNewCar_Click);
            // 
            // dataGrvCategory
            // 
            this.dataGrvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrvCategory.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGrvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.carname,
            this.carcolor,
            this.carmodel,
            this.carimg,
            this.colEdit,
            this.colDelete});
            this.dataGrvCategory.Location = new System.Drawing.Point(12, 101);
            this.dataGrvCategory.Name = "dataGrvCategory";
            this.dataGrvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrvCategory.Size = new System.Drawing.Size(937, 394);
            this.dataGrvCategory.TabIndex = 4;
            this.dataGrvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategory_CellClick);
            this.dataGrvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGrvCategory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategory_CellValueChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID ";
            this.id.Name = "id";
            // 
            // carname
            // 
            this.carname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carname.HeaderText = "Tên Xe";
            this.carname.Name = "carname";
            // 
            // carcolor
            // 
            this.carcolor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carcolor.HeaderText = "Màu Xe";
            this.carcolor.Name = "carcolor";
            // 
            // carmodel
            // 
            this.carmodel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carmodel.HeaderText = "Loại Xe";
            this.carmodel.Name = "carmodel";
            this.carmodel.Width = 68;
            // 
            // carimg
            // 
            this.carimg.HeaderText = "Hình Ảnh";
            this.carimg.Name = "carimg";
            this.carimg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.carimg.Visible = false;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText = "Chỉnh Sửa";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 62;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(928, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // categoryCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(975, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "categoryCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryCar";
            this.Load += new System.EventHandler(this.categoryCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateNewCar;
        private System.Windows.Forms.DataGridView dataGrvCategory;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCarSeacrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelCarSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColorCarSearch;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtNameCarSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn carname;
        private System.Windows.Forms.DataGridViewTextBoxColumn carcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn carmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carimg;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}