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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Loai = new System.Windows.Forms.TextBox();
            this.text_Ten = new System.Windows.Forms.TextBox();
            this.text_Giatien = new System.Windows.Forms.TextBox();
            this.text_CS = new System.Windows.Forms.TextBox();
            this.dtgvTimkiem = new System.Windows.Forms.DataGridView();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.text_hangsp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Công suất:";
            // 
            // text_Loai
            // 
            this.text_Loai.Location = new System.Drawing.Point(106, 26);
            this.text_Loai.Name = "text_Loai";
            this.text_Loai.Size = new System.Drawing.Size(100, 22);
            this.text_Loai.TabIndex = 4;
            // 
            // text_Ten
            // 
            this.text_Ten.Location = new System.Drawing.Point(658, 26);
            this.text_Ten.Name = "text_Ten";
            this.text_Ten.Size = new System.Drawing.Size(100, 22);
            this.text_Ten.TabIndex = 5;
            // 
            // text_Giatien
            // 
            this.text_Giatien.Location = new System.Drawing.Point(658, 84);
            this.text_Giatien.Name = "text_Giatien";
            this.text_Giatien.Size = new System.Drawing.Size(100, 22);
            this.text_Giatien.TabIndex = 6;
            // 
            // text_CS
            // 
            this.text_CS.Location = new System.Drawing.Point(106, 81);
            this.text_CS.Name = "text_CS";
            this.text_CS.Size = new System.Drawing.Size(100, 22);
            this.text_CS.TabIndex = 7;
            // 
            // dtgvTimkiem
            // 
            this.dtgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimkiem.Location = new System.Drawing.Point(12, 138);
            this.dtgvTimkiem.Name = "dtgvTimkiem";
            this.dtgvTimkiem.RowHeadersWidth = 51;
            this.dtgvTimkiem.RowTemplate.Height = 24;
            this.dtgvTimkiem.Size = new System.Drawing.Size(656, 300);
            this.dtgvTimkiem.TabIndex = 8;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(691, 147);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(97, 43);
            this.btn_Timkiem.TabIndex = 9;
            this.btn_Timkiem.Text = "Tư vấn";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(691, 376);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(97, 43);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // text_hangsp
            // 
            this.text_hangsp.Location = new System.Drawing.Point(367, 29);
            this.text_hangsp.Name = "text_hangsp";
            this.text_hangsp.Size = new System.Drawing.Size(100, 22);
            this.text_hangsp.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hãng sản phẩm:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Khu vực:";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_hangsp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.dtgvTimkiem);
            this.Controls.Add(this.text_CS);
            this.Controls.Add(this.text_Giatien);
            this.Controls.Add(this.text_Ten);
            this.Controls.Add(this.text_Loai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm Sản Phẩm";
            this.Load += new System.EventHandler(this.frmtimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Loai;
        private System.Windows.Forms.TextBox text_Ten;
        private System.Windows.Forms.TextBox text_Giatien;
        private System.Windows.Forms.TextBox text_CS;
        private System.Windows.Forms.DataGridView dtgvTimkiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox text_hangsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}