
namespace RentalCar
{
    partial class categoryCustomers
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
            this.labeltotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.txtCusAddSearch = new System.Windows.Forms.TextBox();
            this.dataGrvCategoryCustomer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCusPhoneSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.txtCusIDSearch = new System.Windows.Forms.TextBox();
            this.txtCusNameSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrvCategoryCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labeltotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCreateNewCustomer);
            this.panel1.Controls.Add(this.txtCusAddSearch);
            this.panel1.Controls.Add(this.dataGrvCategoryCustomer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCusPhoneSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.txtCusIDSearch);
            this.panel1.Controls.Add(this.txtCusNameSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 528);
            this.panel1.TabIndex = 1;
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
            this.button3.Location = new System.Drawing.Point(638, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 26;
            this.button3.Text = "Export Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(865, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.ForeColor = System.Drawing.Color.Yellow;
            this.labeltotal.Location = new System.Drawing.Point(8, 490);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(57, 20);
            this.labeltotal.TabIndex = 6;
            this.labeltotal.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(635, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Customer Address";
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateNewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(734, 4);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(188, 43);
            this.btnCreateNewCustomer.TabIndex = 5;
            this.btnCreateNewCustomer.Text = "Create New Customer";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = false;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // txtCusAddSearch
            // 
            this.txtCusAddSearch.Location = new System.Drawing.Point(758, 76);
            this.txtCusAddSearch.Name = "txtCusAddSearch";
            this.txtCusAddSearch.Size = new System.Drawing.Size(89, 20);
            this.txtCusAddSearch.TabIndex = 23;
            this.txtCusAddSearch.TextChanged += new System.EventHandler(this.txtAddSearch_TextChanged);
            // 
            // dataGrvCategoryCustomer
            // 
            this.dataGrvCategoryCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrvCategoryCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrvCategoryCustomer.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGrvCategoryCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrvCategoryCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.customerName,
            this.customerID,
            this.customerPhone,
            this.customerAddress,
            this.customerImg,
            this.colEdit,
            this.colDelete});
            this.dataGrvCategoryCustomer.Location = new System.Drawing.Point(12, 102);
            this.dataGrvCategoryCustomer.Name = "dataGrvCategoryCustomer";
            this.dataGrvCategoryCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrvCategoryCustomer.Size = new System.Drawing.Size(937, 385);
            this.dataGrvCategoryCustomer.TabIndex = 4;
            this.dataGrvCategoryCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategoryCustomer_CellClick);
            this.dataGrvCategoryCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategory_CellContentClick);
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
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 31;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(427, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Customer Phone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            // txtCusPhoneSearch
            // 
            this.txtCusPhoneSearch.Location = new System.Drawing.Point(534, 76);
            this.txtCusPhoneSearch.Name = "txtCusPhoneSearch";
            this.txtCusPhoneSearch.Size = new System.Drawing.Size(89, 20);
            this.txtCusPhoneSearch.TabIndex = 21;
            this.txtCusPhoneSearch.TextChanged += new System.EventHandler(this.txtPhoneSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Customers";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(232, 79);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(81, 16);
            this.Name.TabIndex = 20;
            this.Name.Text = "Customer ID";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // txtCusIDSearch
            // 
            this.txtCusIDSearch.Location = new System.Drawing.Point(312, 76);
            this.txtCusIDSearch.Name = "txtCusIDSearch";
            this.txtCusIDSearch.Size = new System.Drawing.Size(90, 20);
            this.txtCusIDSearch.TabIndex = 19;
            this.txtCusIDSearch.TextChanged += new System.EventHandler(this.txtIDSearch_TextChanged);
            // 
            // txtCusNameSearch
            // 
            this.txtCusNameSearch.Location = new System.Drawing.Point(120, 77);
            this.txtCusNameSearch.Name = "txtCusNameSearch";
            this.txtCusNameSearch.Size = new System.Drawing.Size(89, 20);
            this.txtCusNameSearch.TabIndex = 17;
            this.txtCusNameSearch.TextChanged += new System.EventHandler(this.txtNameSeacrh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Customer Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // categoryCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(975, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "categoryCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryCustomers";
            this.Load += new System.EventHandler(this.categoryCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrvCategoryCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.DataGridView dataGrvCategoryCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerImg;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusAddSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusPhoneSearch;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtCusIDSearch;
        private System.Windows.Forms.TextBox txtCusNameSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}