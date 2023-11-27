
namespace RentalCar
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnNewCus = new System.Windows.Forms.Button();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelOrder = new System.Windows.Forms.Label();
            this.grvOrder = new System.Windows.Forms.DataGridView();
            this.idRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LableCustomers = new System.Windows.Forms.Label();
            this.LableCarsRent = new System.Windows.Forms.Label();
            this.LableCarsAvailable = new System.Windows.Forms.Label();
            this.grvRent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvRentVailable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carimg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvcustomer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRentVailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRentCar);
            this.panel1.Controls.Add(this.btnNewCus);
            this.panel1.Controls.Add(this.btnNewCar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1073, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.BackColor = System.Drawing.Color.Gold;
            this.btnRentCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentCar.ForeColor = System.Drawing.Color.White;
            this.btnRentCar.Location = new System.Drawing.Point(843, 7);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(190, 58);
            this.btnRentCar.TabIndex = 4;
            this.btnRentCar.Text = "Rent Car";
            this.btnRentCar.UseVisualStyleBackColor = false;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnNewCus
            // 
            this.btnNewCus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCus.ForeColor = System.Drawing.Color.White;
            this.btnNewCus.Location = new System.Drawing.Point(638, 7);
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.Size = new System.Drawing.Size(190, 58);
            this.btnNewCus.TabIndex = 3;
            this.btnNewCus.Text = "New Customer";
            this.btnNewCus.UseVisualStyleBackColor = false;
            this.btnNewCus.Click += new System.EventHandler(this.btnNewCus_Click);
            // 
            // btnNewCar
            // 
            this.btnNewCar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCar.ForeColor = System.Drawing.Color.White;
            this.btnNewCar.Location = new System.Drawing.Point(430, 7);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(190, 58);
            this.btnNewCar.TabIndex = 2;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = false;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rental System Car";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LabelOrder);
            this.panel2.Controls.Add(this.grvOrder);
            this.panel2.Controls.Add(this.LableCustomers);
            this.panel2.Controls.Add(this.LableCarsRent);
            this.panel2.Controls.Add(this.LableCarsAvailable);
            this.panel2.Controls.Add(this.grvRent);
            this.panel2.Controls.Add(this.grvRentVailable);
            this.panel2.Controls.Add(this.grvcustomer);
            this.panel2.Location = new System.Drawing.Point(5, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 405);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1049, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "View All";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(474, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "View All";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1049, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "View All";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(474, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "View All";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelOrder
            // 
            this.LabelOrder.AutoSize = true;
            this.LabelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOrder.ForeColor = System.Drawing.Color.White;
            this.LabelOrder.Location = new System.Drawing.Point(553, 217);
            this.LabelOrder.Name = "LabelOrder";
            this.LabelOrder.Size = new System.Drawing.Size(59, 24);
            this.LabelOrder.TabIndex = 11;
            this.LabelOrder.Text = "Order";
            // 
            // grvOrder
            // 
            this.grvOrder.BackgroundColor = System.Drawing.Color.Coral;
            this.grvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRent,
            this.customer,
            this.customerCar});
            this.grvOrder.Location = new System.Drawing.Point(557, 246);
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.Size = new System.Drawing.Size(547, 151);
            this.grvOrder.TabIndex = 10;
            // 
            // idRent
            // 
            this.idRent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idRent.HeaderText = "ID";
            this.idRent.Name = "idRent";
            this.idRent.Width = 43;
            // 
            // customer
            // 
            this.customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer.HeaderText = "Customer ID";
            this.customer.Name = "customer";
            // 
            // customerCar
            // 
            this.customerCar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerCar.HeaderText = "Car ID";
            this.customerCar.Name = "customerCar";
            // 
            // LableCustomers
            // 
            this.LableCustomers.AutoSize = true;
            this.LableCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableCustomers.ForeColor = System.Drawing.Color.White;
            this.LableCustomers.Location = new System.Drawing.Point(7, 219);
            this.LableCustomers.Name = "LableCustomers";
            this.LableCustomers.Size = new System.Drawing.Size(100, 24);
            this.LableCustomers.TabIndex = 9;
            this.LableCustomers.Text = "Customers";
            // 
            // LableCarsRent
            // 
            this.LableCarsRent.AutoSize = true;
            this.LableCarsRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableCarsRent.ForeColor = System.Drawing.Color.White;
            this.LableCarsRent.Location = new System.Drawing.Point(553, 7);
            this.LableCarsRent.Name = "LableCarsRent";
            this.LableCarsRent.Size = new System.Drawing.Size(92, 24);
            this.LableCarsRent.TabIndex = 8;
            this.LableCarsRent.Text = "Cars Rent";
            // 
            // LableCarsAvailable
            // 
            this.LableCarsAvailable.AutoSize = true;
            this.LableCarsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableCarsAvailable.ForeColor = System.Drawing.Color.White;
            this.LableCarsAvailable.Location = new System.Drawing.Point(7, 9);
            this.LableCarsAvailable.Name = "LableCarsAvailable";
            this.LableCarsAvailable.Size = new System.Drawing.Size(129, 24);
            this.LableCarsAvailable.TabIndex = 6;
            this.LableCarsAvailable.Text = "Cars Available";
            // 
            // grvRent
            // 
            this.grvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvRent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvRent.BackgroundColor = System.Drawing.Color.Coral;
            this.grvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.grvRent.Location = new System.Drawing.Point(557, 36);
            this.grvRent.Name = "grvRent";
            this.grvRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvRent.Size = new System.Drawing.Size(547, 170);
            this.grvRent.TabIndex = 7;
            this.grvRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRentNoVali_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Car";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name Car";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Color Car";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Model Car";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Image";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // grvRentVailable
            // 
            this.grvRentVailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvRentVailable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvRentVailable.BackgroundColor = System.Drawing.Color.Coral;
            this.grvRentVailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRentVailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.carname,
            this.carcolor,
            this.carmodel,
            this.carimg});
            this.grvRentVailable.Location = new System.Drawing.Point(10, 36);
            this.grvRentVailable.Name = "grvRentVailable";
            this.grvRentVailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvRentVailable.Size = new System.Drawing.Size(533, 170);
            this.grvRentVailable.TabIndex = 6;
            this.grvRentVailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRentVali_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Car";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // carname
            // 
            this.carname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carname.HeaderText = "Name Car";
            this.carname.Name = "carname";
            // 
            // carcolor
            // 
            this.carcolor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carcolor.HeaderText = "Color Car";
            this.carcolor.Name = "carcolor";
            // 
            // carmodel
            // 
            this.carmodel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carmodel.HeaderText = "Model Car";
            this.carmodel.Name = "carmodel";
            this.carmodel.Width = 80;
            // 
            // carimg
            // 
            this.carimg.HeaderText = "Image";
            this.carimg.Name = "carimg";
            this.carimg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.carimg.Visible = false;
            // 
            // grvcustomer
            // 
            this.grvcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvcustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvcustomer.BackgroundColor = System.Drawing.Color.Coral;
            this.grvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.customerName,
            this.customerID,
            this.customerPhone,
            this.customerAddress,
            this.customerImg});
            this.grvcustomer.Location = new System.Drawing.Point(11, 246);
            this.grvcustomer.Name = "grvcustomer";
            this.grvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvcustomer.Size = new System.Drawing.Size(532, 151);
            this.grvcustomer.TabIndex = 5;
            this.grvcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategoryCustomer_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            // 
            // customerID
            // 
            this.customerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerPhone.HeaderText = "Customer Phone";
            this.customerPhone.Name = "customerPhone";
            // 
            // customerAddress
            // 
            this.customerAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerAddress.HeaderText = "Customer Address";
            this.customerAddress.Name = "customerAddress";
            // 
            // customerImg
            // 
            this.customerImg.HeaderText = "Customer Image";
            this.customerImg.Name = "customerImg";
            this.customerImg.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1122, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRentVailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvcustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnNewCus;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvcustomer;
        private System.Windows.Forms.DataGridView grvRent;
        private System.Windows.Forms.DataGridView grvRentVailable;
        private System.Windows.Forms.Label LableCustomers;
        private System.Windows.Forms.Label LableCarsRent;
        private System.Windows.Forms.Label LableCarsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carname;
        private System.Windows.Forms.DataGridViewTextBoxColumn carcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn carmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carimg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerImg;
        private System.Windows.Forms.Label LabelOrder;
        private System.Windows.Forms.DataGridView grvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
    }
}