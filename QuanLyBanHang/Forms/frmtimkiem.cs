using QuanLyBanHang.Classes;
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
    public partial class frmTimKiem : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        Trangchu tc;
        public frmTimKiem()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmTimKiem(Trangchu tc)
        {
            InitializeComponent();
            this.tc = tc;
        }

        void CreateColumnForDataGridView()
        {

        }

        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (this.tc != null) tc.Show();
            else
            {
                Trangchu f = new Trangchu();
                f.Show();
            }
            this.Close();
         }

        private void frmTimKiem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cBox_LoaiHang_Click(object sender, EventArgs e)
        {
            DataTable dtNV = dtBase.DocBang("Select MaNhanVien, TenNhanVien from [dbo].[tblNhanVien]");
            cBox_LoaiHang.DataSource = dtNV;
            cBox_LoaiHang.DisplayMember = "TenNhanVien";
            cBox_LoaiHang.ValueMember = "MaNhanVien";
        }
    }
}
