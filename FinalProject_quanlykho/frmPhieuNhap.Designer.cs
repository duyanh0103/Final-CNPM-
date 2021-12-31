
namespace FinalProject_quanlykho
{
    partial class frmPhieuNhap
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
            this.quanlykhoDataSet = new FinalProject_quanlykho.quanlykhoDataSet();
            this.quanlykhoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteReceipt = new System.Windows.Forms.Button();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.btnUpdateReciept = new System.Windows.Forms.Button();
            this.importDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPhieuNhap = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTenPhieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_Product = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.btnXoaHang = new System.Windows.Forms.Button();
            this.btnSuaHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.iNPUTINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNPUTINFOTableAdapter = new FinalProject_quanlykho.quanlykhoDataSetTableAdapters.INPUTINFOTableAdapter();
            this.dgvInputInfo = new System.Windows.Forms.DataGridView();
            this.ID_INPUTINFO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_INPUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_INPUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNPUTINFOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNPUTINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNPUTINFOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlykhoDataSet
            // 
            this.quanlykhoDataSet.DataSetName = "quanlykhoDataSet";
            this.quanlykhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanlykhoDataSetBindingSource
            // 
            this.quanlykhoDataSetBindingSource.DataSource = this.quanlykhoDataSet;
            this.quanlykhoDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(301, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "GOODS RECEIVED";
            // 
            // btnDeleteReceipt
            // 
            this.btnDeleteReceipt.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReceipt.Location = new System.Drawing.Point(109, 190);
            this.btnDeleteReceipt.Name = "btnDeleteReceipt";
            this.btnDeleteReceipt.Size = new System.Drawing.Size(75, 41);
            this.btnDeleteReceipt.TabIndex = 17;
            this.btnDeleteReceipt.Text = "Xóa";
            this.btnDeleteReceipt.UseVisualStyleBackColor = false;
            this.btnDeleteReceipt.Click += new System.EventHandler(this.btnDeleteReceipt_Click);
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAddReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReceipt.Location = new System.Drawing.Point(11, 190);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(75, 41);
            this.btnAddReceipt.TabIndex = 16;
            this.btnAddReceipt.Text = "Thêm";
            this.btnAddReceipt.UseVisualStyleBackColor = false;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // btnUpdateReciept
            // 
            this.btnUpdateReciept.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdateReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReciept.Location = new System.Drawing.Point(209, 190);
            this.btnUpdateReciept.Name = "btnUpdateReciept";
            this.btnUpdateReciept.Size = new System.Drawing.Size(73, 41);
            this.btnUpdateReciept.TabIndex = 18;
            this.btnUpdateReciept.Text = "Sửa";
            this.btnUpdateReciept.UseVisualStyleBackColor = false;
            this.btnUpdateReciept.Click += new System.EventHandler(this.btnUpdateReciept_Click);
            // 
            // importDatePicker
            // 
            this.importDatePicker.Location = new System.Drawing.Point(6, 246);
            this.importDatePicker.Name = "importDatePicker";
            this.importDatePicker.Size = new System.Drawing.Size(255, 22);
            this.importDatePicker.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Thời gian nhập:";
            // 
            // cbPhieuNhap
            // 
            this.cbPhieuNhap.FormattingEnabled = true;
            this.cbPhieuNhap.Location = new System.Drawing.Point(123, 53);
            this.cbPhieuNhap.Name = "cbPhieuNhap";
            this.cbPhieuNhap.Size = new System.Drawing.Size(141, 24);
            this.cbPhieuNhap.TabIndex = 13;
            this.cbPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbPhieuNhap_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(123, 94);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(102, 22);
            this.txtID.TabIndex = 14;
            // 
            // txtTenPhieu
            // 
            this.txtTenPhieu.Location = new System.Drawing.Point(125, 135);
            this.txtTenPhieu.Name = "txtTenPhieu";
            this.txtTenPhieu.Size = new System.Drawing.Size(102, 22);
            this.txtTenPhieu.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tên Phiếu Nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mã Phiếu Nhập ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Phiếu Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTenPhieu);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.cbPhieuNhap);
            this.groupBox2.Controls.Add(this.btnUpdateReciept);
            this.groupBox2.Controls.Add(this.btnAddReceipt);
            this.groupBox2.Controls.Add(this.btnDeleteReceipt);
            this.groupBox2.Location = new System.Drawing.Point(762, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 237);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // txtID_Product
            // 
            this.txtID_Product.Location = new System.Drawing.Point(116, 21);
            this.txtID_Product.Name = "txtID_Product";
            this.txtID_Product.Size = new System.Drawing.Size(171, 22);
            this.txtID_Product.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(116, 56);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(171, 22);
            this.txtNameProduct.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giá nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Giá bán:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(116, 138);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(117, 22);
            this.txtGiaNhap.TabIndex = 6;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(116, 174);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(117, 22);
            this.txtGiaBan.TabIndex = 7;
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemHang.Location = new System.Drawing.Point(6, 333);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(75, 36);
            this.btnThemHang.TabIndex = 9;
            this.btnThemHang.Text = "Thêm";
            this.btnThemHang.UseVisualStyleBackColor = false;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHang.Location = new System.Drawing.Point(116, 333);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(75, 36);
            this.btnXoaHang.TabIndex = 10;
            this.btnXoaHang.Text = "Xóa";
            this.btnXoaHang.UseVisualStyleBackColor = false;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnSuaHang
            // 
            this.btnSuaHang.BackColor = System.Drawing.Color.LightGreen;
            this.btnSuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHang.Location = new System.Drawing.Point(225, 333);
            this.btnSuaHang.Name = "btnSuaHang";
            this.btnSuaHang.Size = new System.Drawing.Size(75, 36);
            this.btnSuaHang.TabIndex = 11;
            this.btnSuaHang.Text = "Sửa";
            this.btnSuaHang.UseVisualStyleBackColor = false;
            this.btnSuaHang.Click += new System.EventHandler(this.btnSuaHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txtMaDonHang);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.nudCount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnSuaHang);
            this.groupBox1.Controls.Add(this.btnXoaHang);
            this.groupBox1.Controls.Add(this.btnThemHang);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.importDatePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNameProduct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtID_Product);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(450, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(116, 98);
            this.nudCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(60, 22);
            this.nudCount.TabIndex = 32;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Hộp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "VND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "VND";
            // 
            // iNPUTINFOBindingSource
            // 
            this.iNPUTINFOBindingSource.DataMember = "INPUTINFO";
            this.iNPUTINFOBindingSource.DataSource = this.quanlykhoDataSetBindingSource;
            // 
            // iNPUTINFOTableAdapter
            // 
            this.iNPUTINFOTableAdapter.ClearBeforeFill = true;
            // 
            // dgvInputInfo
            // 
            this.dgvInputInfo.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvInputInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_INPUTINFO,
            this.IDSANPHAM,
            this.TENSANPHAM,
            this.ID_INPUT,
            this.SOLUONG,
            this.DATE_INPUT,
            this.GIANHAP,
            this.GIABAN});
            this.dgvInputInfo.Location = new System.Drawing.Point(12, 103);
            this.dgvInputInfo.Name = "dgvInputInfo";
            this.dgvInputInfo.RowHeadersWidth = 51;
            this.dgvInputInfo.RowTemplate.Height = 24;
            this.dgvInputInfo.Size = new System.Drawing.Size(419, 316);
            this.dgvInputInfo.TabIndex = 11;
            // 
            // ID_INPUTINFO
            // 
            this.ID_INPUTINFO.DataPropertyName = "ID_INPUTINFO";
            this.ID_INPUTINFO.HeaderText = "Mã Đơn Nhập";
            this.ID_INPUTINFO.MinimumWidth = 6;
            this.ID_INPUTINFO.Name = "ID_INPUTINFO";
            this.ID_INPUTINFO.Width = 125;
            // 
            // IDSANPHAM
            // 
            this.IDSANPHAM.DataPropertyName = "IDSANPHAM";
            this.IDSANPHAM.HeaderText = "Mã Sản Phẩm";
            this.IDSANPHAM.MinimumWidth = 6;
            this.IDSANPHAM.Name = "IDSANPHAM";
            this.IDSANPHAM.Width = 125;
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.DataPropertyName = "TENSANPHAM";
            this.TENSANPHAM.HeaderText = "Tên Sản Phẩm";
            this.TENSANPHAM.MinimumWidth = 6;
            this.TENSANPHAM.Name = "TENSANPHAM";
            this.TENSANPHAM.Width = 125;
            // 
            // ID_INPUT
            // 
            this.ID_INPUT.DataPropertyName = "ID_INPUT";
            this.ID_INPUT.HeaderText = "Mã Phiếu Nhập";
            this.ID_INPUT.MinimumWidth = 6;
            this.ID_INPUT.Name = "ID_INPUT";
            this.ID_INPUT.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // DATE_INPUT
            // 
            this.DATE_INPUT.DataPropertyName = "DATE_INPUT";
            this.DATE_INPUT.HeaderText = "Thời Gian Nhập";
            this.DATE_INPUT.MinimumWidth = 6;
            this.DATE_INPUT.Name = "DATE_INPUT";
            this.DATE_INPUT.Width = 125;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "Giá Nhập";
            this.GIANHAP.MinimumWidth = 6;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Width = 125;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá Bán";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 125;
            // 
            // iNPUTINFOBindingSource1
            // 
            this.iNPUTINFOBindingSource1.DataMember = "INPUTINFO";
            this.iNPUTINFOBindingSource1.DataSource = this.quanlykhoDataSetBindingSource;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Enabled = false;
            this.txtMaDonHang.Location = new System.Drawing.Point(116, 274);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(47, 22);
            this.txtMaDonHang.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Mã đơn hàng:";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1076, 510);
            this.Controls.Add(this.dgvInputInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuNhap";
            this.Text = "Phiếu Nhập";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhoDataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNPUTINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNPUTINFOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource quanlykhoDataSetBindingSource;
        private quanlykhoDataSet quanlykhoDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteReceipt;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.Button btnUpdateReciept;
        private System.Windows.Forms.DateTimePicker importDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPhieuNhap;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTenPhieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID_Product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Button btnXoaHang;
        private System.Windows.Forms.Button btnSuaHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource iNPUTINFOBindingSource;
        private quanlykhoDataSetTableAdapters.INPUTINFOTableAdapter iNPUTINFOTableAdapter;
        private System.Windows.Forms.DataGridView dgvInputInfo;
        private System.Windows.Forms.BindingSource iNPUTINFOBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_INPUTINFO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_INPUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_INPUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label label16;
    }
}