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
    public partial class ThemDuLieu : Form
    {
        int LuaChon;
        Classes.ProcessDatabase database = new Classes.ProcessDatabase();
        public ThemDuLieu()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public ThemDuLieu(int n)
        {
            LuaChon = n;
            InitializeComponent();
            if(LuaChon == 0) { this.ThemKH(); }
            if(LuaChon == 1) { this.ThemNV(); }
            CenterToScreen();
        }

        private void ThemNV()
        {
            this.lb1.Text = "Mã nhân viên:";
            this.lb2.Text = "Tên nhân viên:";
            this.lb3.Text = "Giới tính:";
            this.lb4.Text = "Địa chỉ:";
            this.lb5.Text = "Ngày sinh:";
        }

        private void ThemKH()
        {
            this.lb1.Text = "Mã khách hàng:";
            this.lb2.Text = "Tên khách hàng:";
            this.lb3.Text = "Địa chỉ:";
            this.lb4.Text = "Số điện thoại:";
            this.lb5.Text = "Ngày sinh:";
        }

        private void ThemDuLieu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (LuaChon == 0) { this.ThemKH_DB(); }
            if (LuaChon == 1) { this.ThemNV_DB(); }
        }

        private void ThemNV_DB()
        {
            string maNV = this.txt1.Text;
            string tenNV = this.txt2.Text;
            string GT = this.txt3.Text;
            string DC = this.txt4.Text;
            string NS = this.dateTimePicker1.Value.ToString();

            DataTable data;

            data = database.DocBang("Select * from tblNhanVien where [MaNhanVien] = N'" + maNV + "'");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại mã NV này");
                this.ClearData();
                return;
            }

            string sql = "insert into tblNhanVien values (N'" + maNV +
                "',N'" + tenNV +
                "',N'" + GT +
                "',N'" + DC +
                "',N'" + NS +
                "')";
            database.CapNhatDuLieu(sql);
            MessageBox.Show("Thêm thành công");
            this.ClearData();
        }

        private void ThemKH_DB()
        {
            string maNV = this.txt1.Text;
            string tenNV = this.txt2.Text;
            string GT = this.txt3.Text;
            string DC = this.txt4.Text;
            string NS = this.dateTimePicker1.Value.ToString();

            DataTable data;

            data = database.DocBang("Select * from [tblKhach] where [MaKhach] = N'" + maNV + "'");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại mã KH này");
                this.ClearData();
                return;
            }

            string sql = "insert into [tblKhach] values (N'" + maNV +
                "',N'" + tenNV +
                "',N'" + GT +
                "',N'" + DC +
                "',N'" + NS +
                "')";
            database.CapNhatDuLieu(sql);
            MessageBox.Show("Thêm thành công");
            this.ClearData();
        }

        private void ClearData()
        {
            this.txt1.Text = "";
            this.txt2.Text = "";
            this.txt3.Text = "";
            this.txt4.Text = "";
           
        }
    }
}
