
namespace FinalProject_quanlykho
{
    partial class frmMain
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
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnRpMonthly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhieuNhap.Location = new System.Drawing.Point(122, 67);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(171, 150);
            this.btnPhieuNhap.TabIndex = 0;
            this.btnPhieuNhap.Text = "Phiếu Nhập";
            this.btnPhieuNhap.UseVisualStyleBackColor = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.BackColor = System.Drawing.Color.LightCyan;
            this.btnPhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhieuXuat.Location = new System.Drawing.Point(299, 67);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(171, 150);
            this.btnPhieuXuat.TabIndex = 1;
            this.btnPhieuXuat.Text = "Phiếu Xuất";
            this.btnPhieuXuat.UseVisualStyleBackColor = false;
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Bisque;
            this.btnProduct.Location = new System.Drawing.Point(122, 223);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(171, 150);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Sản Phẩm";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnRpMonthly
            // 
            this.btnRpMonthly.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRpMonthly.Location = new System.Drawing.Point(299, 223);
            this.btnRpMonthly.Name = "btnRpMonthly";
            this.btnRpMonthly.Size = new System.Drawing.Size(171, 150);
            this.btnRpMonthly.TabIndex = 5;
            this.btnRpMonthly.Text = "Báo Cáo Tháng";
            this.btnRpMonthly.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject_quanlykho.Properties.Resources.background_2203989_960_720;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.btnRpMonthly);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnPhieuXuat);
            this.Controls.Add(this.btnPhieuNhap);
            this.Name = "frmMain";
            this.Text = "Màn hình chính";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnPhieuXuat;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnRpMonthly;
    }
}