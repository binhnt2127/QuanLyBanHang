using QLBanHang.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class Trangchu : Form
    {
        Forms.User user;
        Classes.ProcessDatabase processDatabase = new Classes.ProcessDatabase();
        public Trangchu()
        {
            InitializeComponent();
            timer1.Start();
        }
        public Trangchu(Forms.User u)
        {
            InitializeComponent();
            CenterToScreen();
            user = u;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            if (this.user != null) user.Show();
            else
            {
                User f = new User();
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmSanPham sp = new frmSanPham(this);
            this.Hide();
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan(this);
            this.Hide();
            frmHoaDonBan.Show();
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            this.Hide();
            frmTimKiem.Show();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.user != null) user.Show();
            else
            {
                User f = new User();
                f.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1, label1.Text.Length - 1) + label1.Text.Substring(0, 1);
        }

        
    }
}
