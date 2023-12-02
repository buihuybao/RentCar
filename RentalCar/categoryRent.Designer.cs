
namespace RentalCar
{
    partial class categoryRent
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
            this.label4 = new System.Windows.Forms.Label();
            this.statusSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.endSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarIDSearch = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.txtIDCusSearch = new System.Windows.Forms.TextBox();
            this.txtIDRentSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelCountRent = new System.Windows.Forms.Label();
            this.grvCategoryRent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colinformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategoryRent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.statusSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.startSearch);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.endSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCarIDSearch);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.txtIDCusSearch);
            this.panel1.Controls.Add(this.txtIDRentSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.labelCountRent);
            this.panel1.Controls.Add(this.grvCategoryRent);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 528);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(683, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Status";
            // 
            // statusSearch
            // 
            this.statusSearch.Location = new System.Drawing.Point(734, 71);
            this.statusSearch.Name = "statusSearch";
            this.statusSearch.Size = new System.Drawing.Size(89, 20);
            this.statusSearch.TabIndex = 39;
            this.statusSearch.TextChanged += new System.EventHandler(this.statusSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Start";
            // 
            // startSearch
            // 
            this.startSearch.Location = new System.Drawing.Point(507, 70);
            this.startSearch.Name = "startSearch";
            this.startSearch.Size = new System.Drawing.Size(48, 20);
            this.startSearch.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(861, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(585, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "End";
            // 
            // endSearch
            // 
            this.endSearch.Location = new System.Drawing.Point(617, 70);
            this.endSearch.Name = "endSearch";
            this.endSearch.Size = new System.Drawing.Size(48, 20);
            this.endSearch.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(320, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Car ID";
            // 
            // txtCarIDSearch
            // 
            this.txtCarIDSearch.Location = new System.Drawing.Point(366, 70);
            this.txtCarIDSearch.Name = "txtCarIDSearch";
            this.txtCarIDSearch.Size = new System.Drawing.Size(89, 20);
            this.txtCarIDSearch.TabIndex = 32;
            this.txtCarIDSearch.TextChanged += new System.EventHandler(this.txtCarIDSearch_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(132, 73);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(81, 16);
            this.Name.TabIndex = 31;
            this.Name.Text = "Customer ID";
            // 
            // txtIDCusSearch
            // 
            this.txtIDCusSearch.Location = new System.Drawing.Point(213, 70);
            this.txtIDCusSearch.Name = "txtIDCusSearch";
            this.txtIDCusSearch.Size = new System.Drawing.Size(90, 20);
            this.txtIDCusSearch.TabIndex = 30;
            this.txtIDCusSearch.TextChanged += new System.EventHandler(this.txtIDCusSearch_TextChanged);
            // 
            // txtIDRentSearch
            // 
            this.txtIDRentSearch.Location = new System.Drawing.Point(63, 71);
            this.txtIDRentSearch.Name = "txtIDRentSearch";
            this.txtIDRentSearch.Size = new System.Drawing.Size(63, 20);
            this.txtIDRentSearch.TabIndex = 28;
            this.txtIDRentSearch.TextChanged += new System.EventHandler(this.txtIDRentSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID Rent";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(832, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 27;
            this.button3.Text = "Export Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelCountRent
            // 
            this.labelCountRent.AutoSize = true;
            this.labelCountRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRent.ForeColor = System.Drawing.Color.Yellow;
            this.labelCountRent.Location = new System.Drawing.Point(9, 498);
            this.labelCountRent.Name = "labelCountRent";
            this.labelCountRent.Size = new System.Drawing.Size(57, 20);
            this.labelCountRent.TabIndex = 6;
            this.labelCountRent.Text = "label2";
            this.labelCountRent.Click += new System.EventHandler(this.labelCountRent_Click);
            // 
            // grvCategoryRent
            // 
            this.grvCategoryRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCategoryRent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvCategoryRent.BackgroundColor = System.Drawing.Color.Coral;
            this.grvCategoryRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCategoryRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRent,
            this.customerid,
            this.CarID,
            this.startRent,
            this.endRent,
            this.status,
            this.colinformation,
            this.colDelete});
            this.grvCategoryRent.Location = new System.Drawing.Point(12, 99);
            this.grvCategoryRent.Name = "grvCategoryRent";
            this.grvCategoryRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvCategoryRent.Size = new System.Drawing.Size(937, 396);
            this.grvCategoryRent.TabIndex = 4;
            this.grvCategoryRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategory_CellContentClick);
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
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rent Car";
            // 
            // idRent
            // 
            this.idRent.HeaderText = "ID";
            this.idRent.Name = "idRent";
            // 
            // customerid
            // 
            this.customerid.HeaderText = "Customer ID";
            this.customerid.Name = "customerid";
            // 
            // CarID
            // 
            this.CarID.HeaderText = "Car ID";
            this.CarID.Name = "CarID";
            // 
            // startRent
            // 
            this.startRent.HeaderText = "Start Day";
            this.startRent.Name = "startRent";
            // 
            // endRent
            // 
            this.endRent.HeaderText = "End Day";
            this.endRent.Name = "endRent";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // colinformation
            // 
            this.colinformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colinformation.HeaderText = "Information";
            this.colinformation.Name = "colinformation";
            this.colinformation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colinformation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colinformation.Text = "Information";
            this.colinformation.UseColumnTextForButtonValue = true;
            this.colinformation.Width = 84;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText = "End";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "End";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 32;
            // 
            // categoryRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(975, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "categoryRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryRent";
            this.Load += new System.EventHandler(this.categoryRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategoryRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCountRent;
        private System.Windows.Forms.DataGridView grvCategoryRent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox statusSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarIDSearch;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtIDCusSearch;
        private System.Windows.Forms.TextBox txtIDRentSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn endRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn colinformation;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}