
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
            this.labelCountRent = new System.Windows.Forms.Label();
            this.grvCategoryRent = new System.Windows.Forms.DataGridView();
            this.idRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colinformation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategoryRent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.colinformation,
            this.colDelete});
            this.grvCategoryRent.Location = new System.Drawing.Point(12, 65);
            this.grvCategoryRent.Name = "grvCategoryRent";
            this.grvCategoryRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvCategoryRent.Size = new System.Drawing.Size(937, 430);
            this.grvCategoryRent.TabIndex = 4;
            this.grvCategoryRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrvCategory_CellContentClick);
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
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 44;
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
            // categoryRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(975, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryRent";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewButtonColumn colinformation;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}