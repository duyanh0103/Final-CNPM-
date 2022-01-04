
namespace FinalProject_quanlykho
{
    partial class frmPhieuXuat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.ID_DAILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDAILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI_DAILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_DAILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE_DAILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TENSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_OUTPUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUSPAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERYSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAgentName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(568, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(92, 131);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(361, 22);
            this.txtAddress.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Địa chỉ";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(93, 63);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(360, 22);
            this.txtContact.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Đại Lý:";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(93, 30);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(360, 22);
            this.txtAgentName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENSANPHAM,
            this.DATE_OUTPUT,
            this.STATUSPAYMENT,
            this.PAYMENT,
            this.DELIVERYSTATUS,
            this.GIABAN,
            this.SOLUONG,
            this.TotalPrice});
            this.dgvReceipt.Location = new System.Drawing.Point(12, 416);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(1156, 291);
            this.dgvReceipt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "GOODS DELIVERY NOTE";
            // 
            // dgvAgents
            // 
            this.dgvAgents.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DAILY,
            this.TENDAILY,
            this.DIACHI_DAILY,
            this.EMAIL_DAILY,
            this.PHONE_DAILY});
            this.dgvAgents.Location = new System.Drawing.Point(12, 91);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.RowHeadersWidth = 51;
            this.dgvAgents.RowTemplate.Height = 24;
            this.dgvAgents.Size = new System.Drawing.Size(550, 233);
            this.dgvAgents.TabIndex = 13;
            this.dgvAgents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickAgents);
            // 
            // ID_DAILY
            // 
            this.ID_DAILY.DataPropertyName = "ID_DAILY";
            this.ID_DAILY.HeaderText = "Mã Đại Lý";
            this.ID_DAILY.MinimumWidth = 6;
            this.ID_DAILY.Name = "ID_DAILY";
            this.ID_DAILY.Width = 125;
            // 
            // TENDAILY
            // 
            this.TENDAILY.DataPropertyName = "TENDAILY";
            this.TENDAILY.HeaderText = "Tên Đại Lý";
            this.TENDAILY.MinimumWidth = 6;
            this.TENDAILY.Name = "TENDAILY";
            this.TENDAILY.Width = 125;
            // 
            // DIACHI_DAILY
            // 
            this.DIACHI_DAILY.DataPropertyName = "DIACHI_DAILY";
            this.DIACHI_DAILY.HeaderText = "Địa Chỉ";
            this.DIACHI_DAILY.MinimumWidth = 6;
            this.DIACHI_DAILY.Name = "DIACHI_DAILY";
            this.DIACHI_DAILY.Width = 125;
            // 
            // EMAIL_DAILY
            // 
            this.EMAIL_DAILY.DataPropertyName = "EMAIL_DAILY";
            this.EMAIL_DAILY.HeaderText = "Email";
            this.EMAIL_DAILY.MinimumWidth = 6;
            this.EMAIL_DAILY.Name = "EMAIL_DAILY";
            this.EMAIL_DAILY.Width = 125;
            // 
            // PHONE_DAILY
            // 
            this.PHONE_DAILY.DataPropertyName = "PHONE_DAILY";
            this.PHONE_DAILY.HeaderText = "Số Điện Thoại";
            this.PHONE_DAILY.MinimumWidth = 6;
            this.PHONE_DAILY.Name = "PHONE_DAILY";
            this.PHONE_DAILY.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 33);
            this.label13.TabIndex = 14;
            this.label13.Text = "AGENTS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(516, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 33);
            this.label14.TabIndex = 15;
            this.label14.Text = "RECEIPT";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(826, 384);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(195, 27);
            this.txtTongTien.TabIndex = 35;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(722, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tổng Tiền:";
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENSANPHAM.DataPropertyName = "TENSANPHAM";
            this.TENSANPHAM.HeaderText = "Tên Sản Phẩm";
            this.TENSANPHAM.MinimumWidth = 6;
            this.TENSANPHAM.Name = "TENSANPHAM";
            // 
            // DATE_OUTPUT
            // 
            this.DATE_OUTPUT.DataPropertyName = "DATE_OUTPUT";
            this.DATE_OUTPUT.HeaderText = "Ngày xuất";
            this.DATE_OUTPUT.MinimumWidth = 6;
            this.DATE_OUTPUT.Name = "DATE_OUTPUT";
            this.DATE_OUTPUT.Width = 125;
            // 
            // STATUSPAYMENT
            // 
            this.STATUSPAYMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STATUSPAYMENT.DataPropertyName = "STATUSPAYMENT";
            this.STATUSPAYMENT.HeaderText = "Tình Trạng Thanh Toán";
            this.STATUSPAYMENT.MinimumWidth = 6;
            this.STATUSPAYMENT.Name = "STATUSPAYMENT";
            // 
            // PAYMENT
            // 
            this.PAYMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PAYMENT.DataPropertyName = "PAYMENT";
            this.PAYMENT.HeaderText = "Phương Thức Thanh Toán";
            this.PAYMENT.MinimumWidth = 6;
            this.PAYMENT.Name = "PAYMENT";
            // 
            // DELIVERYSTATUS
            // 
            this.DELIVERYSTATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DELIVERYSTATUS.DataPropertyName = "DELIVERYSTATUS";
            this.DELIVERYSTATUS.HeaderText = "Tình Trạng Vận Chuyển";
            this.DELIVERYSTATUS.MinimumWidth = 6;
            this.DELIVERYSTATUS.Name = "DELIVERYSTATUS";
            // 
            // GIABAN
            // 
            this.GIABAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Đơn giá";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            // 
            // SOLUONG
            // 
            this.SOLUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOLUONG.DataPropertyName = "Count";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Thành Tiền";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1190, 719);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuXuat";
            this.Text = "Phiếu Xuất ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DAILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDAILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI_DAILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_DAILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE_DAILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_OUTPUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUSPAYMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERYSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}