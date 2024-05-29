namespace QuanLyBanHang.Forms
{
    partial class ThemDuLieu
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
            this.lb1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(62, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 18);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "label1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(213, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(330, 24);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(213, 67);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(330, 24);
            this.txt2.TabIndex = 3;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(62, 67);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(46, 18);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "label1";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(213, 112);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(330, 24);
            this.txt3.TabIndex = 5;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(62, 112);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(46, 18);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "label1";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(213, 160);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(330, 24);
            this.txt4.TabIndex = 7;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(62, 160);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(46, 18);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "label1";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(62, 208);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(46, 18);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "label1";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(374, 247);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(95, 44);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 24);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // ThemDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 306);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThemDuLieu";
            this.Text = "Thêm dữ liệu";
            this.Load += new System.EventHandler(this.ThemDuLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}