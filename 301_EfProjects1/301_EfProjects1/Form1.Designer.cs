namespace _301_EfProjects1
{
    partial class FrmLocation
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
            this.LocationID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.CityName = new System.Windows.Forms.Label();
            this.TextCity = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnId = new System.Windows.Forms.Button();
            this.Capacity = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.textDayNight = new System.Windows.Forms.TextBox();
            this.DayNight = new System.Windows.Forms.Label();
            this.Guide = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationID
            // 
            this.LocationID.AutoSize = true;
            this.LocationID.Location = new System.Drawing.Point(18, 42);
            this.LocationID.Name = "LocationID";
            this.LocationID.Size = new System.Drawing.Size(71, 13);
            this.LocationID.TabIndex = 0;
            this.LocationID.Text = "Locasyon Id :";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(95, 39);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 1;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.PaleGreen;
            this.btnList.Location = new System.Drawing.Point(67, 287);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(103, 21);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 314);
            this.dataGridView1.TabIndex = 3;
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(95, 98);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(100, 20);
            this.textCountry.TabIndex = 5;
            // 
            // CityName
            // 
            this.CityName.AutoSize = true;
            this.CityName.Location = new System.Drawing.Point(34, 75);
            this.CityName.Name = "CityName";
            this.CityName.Size = new System.Drawing.Size(55, 13);
            this.CityName.TabIndex = 4;
            this.CityName.Text = "Şehir Adı :";
            // 
            // TextCity
            // 
            this.TextCity.Location = new System.Drawing.Point(95, 72);
            this.TextCity.Name = "TextCity";
            this.TextCity.Size = new System.Drawing.Size(100, 20);
            this.TextCity.TabIndex = 7;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(54, 108);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(35, 13);
            this.Country.TabIndex = 6;
            this.Country.Text = "Ülke :";
            this.Country.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(67, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 21);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDelete.Location = new System.Drawing.Point(67, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 21);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Location = new System.Drawing.Point(67, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 21);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.PaleGreen;
            this.btnId.Location = new System.Drawing.Point(67, 395);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(103, 21);
            this.btnId.TabIndex = 11;
            this.btnId.Text = "ID No sırlala";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(35, 132);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(54, 13);
            this.Capacity.TabIndex = 12;
            this.Capacity.Text = "Kapasite :";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(95, 155);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 15;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(54, 158);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(35, 13);
            this.Price.TabIndex = 14;
            this.Price.Text = "Fiyat :";
            // 
            // textDayNight
            // 
            this.textDayNight.Location = new System.Drawing.Point(95, 181);
            this.textDayNight.Name = "textDayNight";
            this.textDayNight.Size = new System.Drawing.Size(100, 20);
            this.textDayNight.TabIndex = 17;
            this.textDayNight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DayNight
            // 
            this.DayNight.AutoSize = true;
            this.DayNight.Location = new System.Drawing.Point(33, 184);
            this.DayNight.Name = "DayNight";
            this.DayNight.Size = new System.Drawing.Size(56, 13);
            this.DayNight.TabIndex = 16;
            this.DayNight.Text = "Gün Gece";
            this.DayNight.Click += new System.EventHandler(this.label6_Click);
            // 
            // Guide
            // 
            this.Guide.AutoSize = true;
            this.Guide.Location = new System.Drawing.Point(41, 224);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(48, 13);
            this.Guide.TabIndex = 18;
            this.Guide.Text = "Rehber :";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(95, 130);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(100, 20);
            this.nudCapacity.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 472);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.textDayNight);
            this.Controls.Add(this.DayNight);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TextCity);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.CityName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.LocationID);
            this.Name = "FrmLocation";
            this.Text = "Rehber İşlemleri";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.Label CityName;
        private System.Windows.Forms.TextBox TextCity;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox textDayNight;
        private System.Windows.Forms.Label DayNight;
        private System.Windows.Forms.Label Guide;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

