namespace QuanLyBanHang.Forms
{
    partial class frmTimKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvTimkiem = new System.Windows.Forms.DataGridView();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_LoaiHang = new System.Windows.Forms.ComboBox();
            this.cBox_HangSanPham = new System.Windows.Forms.ComboBox();
            this.cBox_KhuVuc = new System.Windows.Forms.ComboBox();
            this.cBox_CongSuat = new System.Windows.Forms.ComboBox();
            this.cBox_GiaTien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Công suất:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtgvTimkiem
            // 
            this.dtgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimkiem.Location = new System.Drawing.Point(15, 172);
            this.dtgvTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvTimkiem.Name = "dtgvTimkiem";
            this.dtgvTimkiem.RowHeadersWidth = 51;
            this.dtgvTimkiem.RowTemplate.Height = 24;
            this.dtgvTimkiem.Size = new System.Drawing.Size(820, 375);
            this.dtgvTimkiem.TabIndex = 8;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(864, 184);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(121, 54);
            this.btn_Timkiem.TabIndex = 9;
            this.btn_Timkiem.Text = "Tư vấn";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(864, 470);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(121, 54);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hãng sản phẩm:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Khu vực:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cBox_LoaiHang
            // 
            this.cBox_LoaiHang.FormattingEnabled = true;
            this.cBox_LoaiHang.Location = new System.Drawing.Point(132, 26);
            this.cBox_LoaiHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_LoaiHang.Name = "cBox_LoaiHang";
            this.cBox_LoaiHang.Size = new System.Drawing.Size(150, 28);
            this.cBox_LoaiHang.TabIndex = 15;
            this.cBox_LoaiHang.Click += new System.EventHandler(this.cBox_LoaiHang_Click);
            // 
            // cBox_HangSanPham
            // 
            this.cBox_HangSanPham.FormattingEnabled = true;
            this.cBox_HangSanPham.Location = new System.Drawing.Point(468, 26);
            this.cBox_HangSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_HangSanPham.Name = "cBox_HangSanPham";
            this.cBox_HangSanPham.Size = new System.Drawing.Size(150, 28);
            this.cBox_HangSanPham.TabIndex = 16;
            // 
            // cBox_KhuVuc
            // 
            this.cBox_KhuVuc.FormattingEnabled = true;
            this.cBox_KhuVuc.Location = new System.Drawing.Point(468, 91);
            this.cBox_KhuVuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_KhuVuc.Name = "cBox_KhuVuc";
            this.cBox_KhuVuc.Size = new System.Drawing.Size(150, 28);
            this.cBox_KhuVuc.TabIndex = 17;
            // 
            // cBox_CongSuat
            // 
            this.cBox_CongSuat.FormattingEnabled = true;
            this.cBox_CongSuat.Location = new System.Drawing.Point(132, 95);
            this.cBox_CongSuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_CongSuat.Name = "cBox_CongSuat";
            this.cBox_CongSuat.Size = new System.Drawing.Size(150, 28);
            this.cBox_CongSuat.TabIndex = 18;
            // 
            // cBox_GiaTien
            // 
            this.cBox_GiaTien.FormattingEnabled = true;
            this.cBox_GiaTien.Location = new System.Drawing.Point(789, 26);
            this.cBox_GiaTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_GiaTien.Name = "cBox_GiaTien";
            this.cBox_GiaTien.Size = new System.Drawing.Size(150, 28);
            this.cBox_GiaTien.TabIndex = 19;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.cBox_GiaTien);
            this.Controls.Add(this.cBox_CongSuat);
            this.Controls.Add(this.cBox_KhuVuc);
            this.Controls.Add(this.cBox_HangSanPham);
            this.Controls.Add(this.cBox_LoaiHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.dtgvTimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimKiem_FormClosed);
            this.Load += new System.EventHandler(this.frmtimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvTimkiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_LoaiHang;
        private System.Windows.Forms.ComboBox cBox_HangSanPham;
        private System.Windows.Forms.ComboBox cBox_KhuVuc;
        private System.Windows.Forms.ComboBox cBox_CongSuat;
        private System.Windows.Forms.ComboBox cBox_GiaTien;
    }
}