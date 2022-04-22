
namespace BTL
{
    partial class Form_PhoneData
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PhoneID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_BrandID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BrandID = new System.Windows.Forms.ComboBox();
            this.dataGridView_Phone = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Brand = new System.Windows.Forms.Button();
            this.btn_UpdatePhone = new System.Windows.Forms.Button();
            this.btn_DeletePhone = new System.Windows.Forms.Button();
            this.btn_AddPhone = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ReportPhone = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.bTL_HuongSukienDataSet = new BTL.BTL_HuongSukienDataSet();
            this.bTLHuongSukienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_PhoneModel = new System.Windows.Forms.TextBox();
            this.textBox_BrandID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phone)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bTL_HuongSukienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLHuongSukienDataSetBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1351, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý cửa hàng điện thoại";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_Price, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Quantity, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_PhoneID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 133);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1348, 84);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price.Location = new System.Drawing.Point(205, 46);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(465, 34);
            this.textBox_Price.TabIndex = 7;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Quantity.Location = new System.Drawing.Point(878, 4);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(467, 34);
            this.textBox_Quantity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã điện thoại:";
            // 
            // textBox_PhoneID
            // 
            this.textBox_PhoneID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PhoneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PhoneID.Location = new System.Drawing.Point(205, 4);
            this.textBox_PhoneID.Name = "textBox_PhoneID";
            this.textBox_PhoneID.Size = new System.Drawing.Size(465, 34);
            this.textBox_PhoneID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(776, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // label_BrandID
            // 
            this.label_BrandID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_BrandID.AutoSize = true;
            this.label_BrandID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_BrandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BrandID.Location = new System.Drawing.Point(69, 9);
            this.label_BrandID.Name = "label_BrandID";
            this.label_BrandID.Size = new System.Drawing.Size(130, 25);
            this.label_BrandID.TabIndex = 0;
            this.label_BrandID.Text = "Mã Hãng ĐT:";
            this.label_BrandID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_BrandID.Click += new System.EventHandler(this.label_BrandID_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên điện thoại:";
            // 
            // comboBox_BrandID
            // 
            this.comboBox_BrandID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BrandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BrandID.FormattingEnabled = true;
            this.comboBox_BrandID.Location = new System.Drawing.Point(407, 3);
            this.comboBox_BrandID.Name = "comboBox_BrandID";
            this.comboBox_BrandID.Size = new System.Drawing.Size(264, 37);
            this.comboBox_BrandID.TabIndex = 10;
            this.comboBox_BrandID.SelectedValueChanged += new System.EventHandler(this.comboBox_BrandID_SelectedValueChanged);
            // 
            // dataGridView_Phone
            // 
            this.dataGridView_Phone.AllowUserToAddRows = false;
            this.dataGridView_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Phone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phone.Location = new System.Drawing.Point(12, 344);
            this.dataGridView_Phone.Name = "dataGridView_Phone";
            this.dataGridView_Phone.ReadOnly = true;
            this.dataGridView_Phone.RowHeadersWidth = 51;
            this.dataGridView_Phone.RowTemplate.Height = 24;
            this.dataGridView_Phone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Phone.Size = new System.Drawing.Size(1345, 410);
            this.dataGridView_Phone.TabIndex = 2;
            this.dataGridView_Phone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDataToTextView);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_Brand, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_UpdatePhone, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_DeletePhone, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_AddPhone, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Search, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_ReportPhone, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Staff, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_Customer, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 223);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1345, 115);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(314, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bán Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Brand
            // 
            this.btn_Brand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Brand.Location = new System.Drawing.Point(45, 63);
            this.btn_Brand.Name = "btn_Brand";
            this.btn_Brand.Size = new System.Drawing.Size(178, 45);
            this.btn_Brand.TabIndex = 5;
            this.btn_Brand.Text = "Update Hãng ĐT";
            this.btn_Brand.UseVisualStyleBackColor = true;
            this.btn_Brand.Click += new System.EventHandler(this.btn_Brand_Click);
            // 
            // btn_UpdatePhone
            // 
            this.btn_UpdatePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdatePhone.Location = new System.Drawing.Point(1121, 10);
            this.btn_UpdatePhone.Name = "btn_UpdatePhone";
            this.btn_UpdatePhone.Size = new System.Drawing.Size(178, 37);
            this.btn_UpdatePhone.TabIndex = 4;
            this.btn_UpdatePhone.Text = "Sửa";
            this.btn_UpdatePhone.UseVisualStyleBackColor = true;
            this.btn_UpdatePhone.Click += new System.EventHandler(this.btn_UpdatePhone_Click);
            // 
            // btn_DeletePhone
            // 
            this.btn_DeletePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeletePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletePhone.Location = new System.Drawing.Point(852, 10);
            this.btn_DeletePhone.Name = "btn_DeletePhone";
            this.btn_DeletePhone.Size = new System.Drawing.Size(178, 37);
            this.btn_DeletePhone.TabIndex = 3;
            this.btn_DeletePhone.Text = "Xóa";
            this.btn_DeletePhone.UseVisualStyleBackColor = true;
            this.btn_DeletePhone.Click += new System.EventHandler(this.btn_DeletePhone_Click);
            // 
            // btn_AddPhone
            // 
            this.btn_AddPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPhone.Location = new System.Drawing.Point(583, 10);
            this.btn_AddPhone.Name = "btn_AddPhone";
            this.btn_AddPhone.Size = new System.Drawing.Size(178, 37);
            this.btn_AddPhone.TabIndex = 2;
            this.btn_AddPhone.Text = "Thêm";
            this.btn_AddPhone.UseVisualStyleBackColor = true;
            this.btn_AddPhone.Click += new System.EventHandler(this.btn_AddPhone_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(314, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(178, 37);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ReportPhone
            // 
            this.btn_ReportPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ReportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportPhone.Location = new System.Drawing.Point(45, 6);
            this.btn_ReportPhone.Name = "btn_ReportPhone";
            this.btn_ReportPhone.Size = new System.Drawing.Size(178, 45);
            this.btn_ReportPhone.TabIndex = 0;
            this.btn_ReportPhone.Text = "Report";
            this.btn_ReportPhone.UseVisualStyleBackColor = true;
            this.btn_ReportPhone.Click += new System.EventHandler(this.btn_ReportPhone_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.Location = new System.Drawing.Point(583, 67);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(178, 37);
            this.btn_Staff.TabIndex = 6;
            this.btn_Staff.Text = "Nhân Viên";
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(852, 67);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(178, 37);
            this.btn_Customer.TabIndex = 7;
            this.btn_Customer.Text = "Khách Hàng";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // bTL_HuongSukienDataSet
            // 
            this.bTL_HuongSukienDataSet.DataSetName = "BTL_HuongSukienDataSet";
            this.bTL_HuongSukienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bTLHuongSukienDataSetBindingSource
            // 
            this.bTLHuongSukienDataSetBindingSource.DataSource = this.bTL_HuongSukienDataSet;
            this.bTLHuongSukienDataSetBindingSource.Position = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_PhoneModel, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox_BrandID, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_BrandID, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_BrandID, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 84);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1351, 43);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // textBox_PhoneModel
            // 
            this.textBox_PhoneModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PhoneModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PhoneModel.Location = new System.Drawing.Point(879, 4);
            this.textBox_PhoneModel.Name = "textBox_PhoneModel";
            this.textBox_PhoneModel.Size = new System.Drawing.Size(469, 34);
            this.textBox_PhoneModel.TabIndex = 12;
            // 
            // textBox_BrandID
            // 
            this.textBox_BrandID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_BrandID.Enabled = false;
            this.textBox_BrandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BrandID.Location = new System.Drawing.Point(205, 4);
            this.textBox_BrandID.Name = "textBox_BrandID";
            this.textBox_BrandID.ReadOnly = true;
            this.textBox_BrandID.Size = new System.Drawing.Size(196, 34);
            this.textBox_BrandID.TabIndex = 12;
            // 
            // Form_PhoneData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 766);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dataGridView_Phone);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_PhoneData";
            this.Text = "Phone Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PhoneData_FormClosing);
            this.Load += new System.EventHandler(this.Form_PhoneData_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phone)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bTL_HuongSukienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLHuongSukienDataSetBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_BrandID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.DataGridView dataGridView_Phone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_UpdatePhone;
        private System.Windows.Forms.Button btn_DeletePhone;
        private System.Windows.Forms.Button btn_AddPhone;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ReportPhone;
        private System.Windows.Forms.ComboBox comboBox_BrandID;
        private BTL_HuongSukienDataSet bTL_HuongSukienDataSet;
        private System.Windows.Forms.BindingSource bTLHuongSukienDataSetBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox_PhoneID;
        private System.Windows.Forms.TextBox textBox_PhoneModel;
        private System.Windows.Forms.TextBox textBox_BrandID;
        private System.Windows.Forms.Button btn_Brand;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button button2;
    }
}

