using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Classes;
using QuanLyBanHang.Forms;

namespace QLBanHang.DanhMuc
{
    public partial class frmSanPham : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        Trangchu tc;
        public frmSanPham()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public frmSanPham(Trangchu tc)
        {
            InitializeComponent();
            this.tc = tc;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Nhập đủ dl
            if(txtMa.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải nhập mã SP");
                txtMa.Focus();
                return;
            }    
            if(txtTen.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải nhập tên SP");
                txtTen.Focus();
                return;
            }
            //Kiểm tra trùng mã
            DataTable dtCL = dtBase.DocBang("Select * from [tblHang] where [MaHang]='" + txtMa.Text + "'");
            if (dtCL.Rows.Count>0)
            {
                MessageBox.Show("Mã này đã có, mời bạn nhập mã khac");
                txtMa.Focus();
                return;
            }
            string maSP = txtMa.Text;
            string tenSp = txtTen.Text;
            string soluong = txt_soluong.Text;
            string gianhap = txt_gianhap.Text;
            string giaban = txt_giaban.Text;
            string insertCL = "insert into tblHang values('" + maSP+"',N'"+ tenSp +"', "+ Int32.Parse(soluong)+","+ gianhap +"," + giaban +  ")";
            dtBase.DocBang(insertCL);
            frmChatlieu_Load(sender, e);
        }

        private void frmChatlieu_Load(object sender, EventArgs e)
        {
            DataTable dtCL = new DataTable();
            dtCL = dtBase.DocBang("Select * from tblHang");            
            //Gắn dl vào datagridview
            dgvChatLieu.DataSource = dtCL;

            dgvChatLieu.Columns[0].HeaderText = "Mã sản phẩm";
            dgvChatLieu.Columns[1].HeaderText = "Tên sản phẩm";
            dgvChatLieu.Columns[2].HeaderText = "Số lượng";
            dgvChatLieu.Columns[3].HeaderText = "Đơn giá nhập";
            dgvChatLieu.Columns[4].HeaderText = "Đơn giá bán";

            int size = dgvChatLieu.Width / 5;

            dgvChatLieu.Columns[0].Width = size - 52;
            dgvChatLieu.Columns[1].Width = size;
            dgvChatLieu.Columns[2].Width = size;
            dgvChatLieu.Columns[3].Width = size;
            dgvChatLieu.Columns[4].Width = size;



            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled= false;
           
        }

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvChatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();
            txt_soluong.Text = dgvChatLieu.CurrentRow.Cells[2].Value.ToString();
            txt_gianhap.Text = dgvChatLieu.CurrentRow.Cells[3].Value.ToString();
            txt_giaban.Text = dgvChatLieu.CurrentRow.Cells[4].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMa.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải chọn sản phẩm để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm đang chọn không?", "Yes no", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete tblHang where [MaHang]='" + txtMa.Text + "'");
                frmChatlieu_Load(sender, e);
                txtMa.Text = "";
                txtTen.Text = "";
            }    
                

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMa.Text;
            string tenSp = txtTen.Text;
            string soluong = txt_soluong.Text;
            string gianhap = txt_gianhap.Text;
            string giaban = txt_giaban.Text;

            
            dtBase.CapNhatDuLieu("  update tblHang set TenHang = '"+tenSp
                                +"',[SoLuong] = "+soluong
                                +",[DonGiaNhap] = '"+gianhap
                                +"',[DonGiaBan] = '"+giaban
                                +"'where [MaHang] = '"+maSP+"'");
            frmChatlieu_Load(sender, e);
            /*txtMa.Text = "";
            txtTen.Text = "";*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (this.tc != null) tc.Show();
            else
            {
                Trangchu f = new Trangchu();
                f.Show();
            }
            this.Close();
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.tc != null) tc.Show();
            else
            {
                Trangchu f = new Trangchu();
                f.Show();
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
