using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDonBan : Form
    {
        Classes.ProcessDatabase dtBase = new Classes.ProcessDatabase();
        Functions ft = new Functions();
        Function ftt = new Function();
        Trangchu Trangchu;
        public frmHoaDonBan()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public frmHoaDonBan(Trangchu trangchu)
        {
            InitializeComponent();
            CenterToScreen();
            Trangchu = trangchu;
        }

        private void cboMaNV_Click(object sender, EventArgs e)
        {
            DataTable dtNV = dtBase.DocBang("Select MaNhanVien, TenNhanVien from [dbo].[tblNhanVien]");
            cboMaNV.DataSource = dtNV;
            cboMaNV.DisplayMember = "MaNhanVien";
            cboMaNV.ValueMember = "MaNhanVien";
        }

        private void cboMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = dtBase.DocBang("Select MaNhanVien,TenNhanVien from tblNhanVien" +
                    " where MaNhanVien='" + cboMaNV.SelectedValue.ToString() + "'");
                if (dtNV.Rows.Count > 0)
                    txtTenNV.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
            }
            catch
            {

            }
        }

        private void cboMaKhach_Click(object sender, EventArgs e)
        {
            ftt.FillComBox(cboMaKhach, dtBase.DocBang("Select * from tblKhach"), "MaKhach", "MaKhach");
        }

        private void cboMaKhach_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKhach = dtBase.DocBang("Select * from tblKhach where MaKhach='" +
                    cboMaKhach.SelectedValue.ToString() + "'");
                if (dtKhach.Rows.Count > 0)
                {
                    txtTenKH.Text = dtKhach.Rows[0]["TenKhach"].ToString();
                    txtDiaChi.Text = dtKhach.Rows[0]["DiaChi"].ToString();
                    txtDienThoai.Text = dtKhach.Rows[0]["SoDienThoai"].ToString();
                }
            }
            catch
            {

            }
        }

        private void cboMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHang = dtBase.DocBang("Select * from tblHang where MaHang='" +
                    cboMaHang.SelectedValue.ToString() + "'");
                if (dtHang.Rows.Count > 0)
                {
                    txtTenHang.Text = dtHang.Rows[0]["TenHang"].ToString();
                    txtDonGia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();

                }
                this.txtSoLuong.Text = "";
            }
            catch
            {

            }
        }

        private void cboMaHang_Click(object sender, EventArgs e)
        {
            ftt.FillComBox(cboMaHang, dtBase.DocBang("Select * from tblHang"), "MaHang", "MaHang");
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double DonGia, GiamGia, soluong;
                if (txtGiamGia.Text == "")
                    GiamGia = 0;
                else
                    GiamGia = Convert.ToDouble(txtGiamGia.Text);
                if (txtSoLuong.Text == "")
                    soluong = 0;
                else
                    soluong = Convert.ToDouble(txtSoLuong.Text);
                DonGia = Convert.ToDouble(txtDonGia.Text);                
                txtThanhTien.Text = (soluong * DonGia - soluong *DonGia* GiamGia / 100).ToString();

            }
            catch
            {

            }
            
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            this.label18.Visible = false;
            ResetValue();
            
            string str = "HD" + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + ".";
            txtMaHD.Text = ft.SinhMaTuDong("tblHDBan",str,"MaHDBan");

            btnThemHD.Enabled = false;
            btnLuu.Enabled = true;
            btnHuyHD.Enabled = false;
            btnInHD.Enabled = false;

            cboMaNV.Enabled = true;
            cboMaKhach.Enabled = true;
            cboMaHang.Enabled = true;
        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {
            btnThemHD.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyHD.Enabled = false;
           // btnInHD.Enabled = false;
            ResetValue();
        }
        void ResetValue()
        {
            DateTime dt = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day);
            txtMaHD.Text = "";
            dtpNgayBan.Text =  dt.ToShortDateString();
            cboMaNV.Text = "";
            cboMaKhach.Text = "";
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "0";
            //lblSoTien.Text = "Bằng chữ: ";
            dgvHDB.DataSource = null;
        }
        void LayThongTin()
        {
            DataTable dtHDBan = dtBase.DocBang("Select * from tblHDBan where MaHDBan='"+txtMaHD.Text+"'");
            try
            {
                dtpNgayBan.Text = Convert.ToDateTime(dtHDBan.Rows[0]["NgayBan"].ToString()).ToShortDateString();
                cboMaNV.Text = dtHDBan.Rows[0]["MaNhanVien"].ToString();
                cboMaKhach.Text = dtHDBan.Rows[0]["MaKhach"].ToString();
                txtTongTien.Text = dtHDBan.Rows[0]["TongTien"].ToString();
                //lblSoTien.Text = "Bằng chữ: ";
            }
            catch{
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double sl, slcon, tong, tongmoi;
                DataTable dtHD = dtBase.DocBang("Select * from tblHDBan where MaHDBan='" +
                    txtMaHD.Text + "'");
                if (dtHD.Rows.Count == 0) //TH hóa đơn chưa có lưu các thông tin chung
                {
                    if (dtpNgayBan.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập ngày bán");
                        dtpNgayBan.Focus();
                    }
                    else
                    {
                        if (cboMaNV.Text == "")
                        {
                            MessageBox.Show("Bạn phải điền thông tin về nhân viên bán");
                            cboMaNV.Focus();
                        }

                        else
                        {
                            if (cboMaKhach.Text == "")
                            {
                                MessageBox.Show("Bạn phải điền thông tin về khách hàng");
                                cboMaKhach.Focus();
                            }
                            else
                            {
                                DateTime dtNgayBan = Convert.ToDateTime(dtpNgayBan.Text.Trim());
                                dtBase.CapNhatDuLieu("INSERT INTO tblHDBan(MaHDBan,NgayBan,MaNhanVien,MaKhach,TongTien) values('" +
                                                     txtMaHD.Text + "','" + string.Format("{0:MM/dd/yyyy}", dtNgayBan) + "',N'" +
                                                    cboMaNV.SelectedValue.ToString() + "',N'" +
                                                    cboMaKhach.SelectedValue.ToString() + "','" +
                                                    txtTongTien.Text.Trim() + "')");

                            }
                        }

                    }
                }
                //Lưu thông tin các mặt hàng
                if (cboMaHang.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn mã hàng");
                    cboMaHang.Focus();
                }
                else
                {
                    if (txtSoLuong.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập số lượng");
                        txtSoLuong.Focus();
                    }
                    else
                    {
                        if (txtGiamGia.Text == "")
                        {
                            MessageBox.Show("Bạn phải nhập giảm giá");
                        }
                        else
                        {
                            DataTable dtHang = dtBase.DocBang("Select * from tblHang where maHang='" + cboMaHang.SelectedValue.ToString() + "'");
                            if (Convert.ToDouble(dtHang.Rows[0]["SoLuong"].ToString()) < Convert.ToDouble(txtSoLuong.Text))
                            {
                                MessageBox.Show("Số lượng không đủ, chỉ còn " + dtHang.Rows[0]["SoLuong"].ToString());
                            }
                            else
                            {
                                dtBase.CapNhatDuLieu("insert into tblChiTietHDBan(MaHDBan,MaHang,SoLuong,GiamGia,ThanhTien) values ('" +
                                    txtMaHD.Text + "','" + cboMaHang.SelectedValue.ToString() + "'," + txtSoLuong.Text + ",'" +
                                    txtGiamGia.Text + "','" + txtThanhTien.Text + "')");
                                dtHD = dtBase.DocBang("Select * from tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
                                txtTongTien.Text = (Convert.ToDouble(dtHD.Rows[0]["TongTien"].ToString()) + Convert.ToDouble(txtThanhTien.Text)).ToString();
                                slcon = Convert.ToDouble(dtHang.Rows[0]["SoLuong"].ToString()) - Convert.ToDouble(txtSoLuong.Text);
                                dtBase.CapNhatDuLieu("update tblHang set SoLuong=" + slcon + " where MaHang ='" +
                                    cboMaHang.SelectedValue.ToString() + "'");
                                dtBase.CapNhatDuLieu("update tblHDBan set TongTien='" + txtTongTien.Text + "' where MaHDBan='" +
                                    txtMaHD.Text + "'");
                            }
                        }
                    }
                }

                dgvHDB.DataSource = dtBase.DocBang("Select tblChiTietHDBan.MaHang,TenHang,DonGiaBan,tblChiTietHDBan.SoLuong,tblChiTietHDBan.GiamGia,ThanhTien from tblChiTietHDBan inner join tblHang on tblHang.MaHang=tblChiTietHDBan.MaHang where MaHDBan='" + txtMaHD.Text + "'");


                btnInHD.Enabled = true;
                btnHuyHD.Enabled = true;
            }
            catch { }

        }

        private void cboTimKiem_Click(object sender, EventArgs e)
        {
            cboTimKiem.DataSource = null;
            ftt.FillComBox(cboTimKiem, dtBase.DocBang("Select MaHDBan from tblHDBan"), "MaHDBan", "MaHDBan");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.label18.Visible = true;
            DataTable dtHD = dtBase.DocBang("select * from tblHDBan where MaHDBan='"+cboTimKiem.SelectedValue.ToString()+"'");
            if(dtHD.Rows.Count>0)
            {

                txtMaHD.Text = dtHD.Rows[0]["MaHDBan"].ToString();
                cboMaNV.Text  = dtHD.Rows[0]["MaNhanVien"].ToString();
                DataTable dtNV = dtBase.DocBang("Select MaNhanVien,TenNhanVien from tblNhanVien" +
                   " where MaNhanVien='" + dtHD.Rows[0]["MaNhanVien"].ToString() + "'");
                if (dtNV.Rows.Count > 0)
                    txtTenNV.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
               
                DataTable dtKhach = dtBase.DocBang("Select * from tblKhach where MaKhach='" +
                    dtHD.Rows[0]["MaKhach"].ToString() + "'");
                if (dtKhach.Rows.Count > 0)
                {
                    txtTenKH.Text = dtKhach.Rows[0]["TenKhach"].ToString();
                    txtDiaChi.Text = dtKhach.Rows[0]["DiaChi"].ToString();
                    txtDienThoai.Text = dtKhach.Rows[0]["SoDienThoai"].ToString();
                }
               
                txtTongTien.Text = dtHD.Rows[0]["TongTien"].ToString();
                dgvHDB.DataSource = dtBase.DocBang("Select tblChiTietHDBan.MaHang,TenHang,"+
                    "tblHang.DonGiaBan,tblChiTietHDBan.SoLuong,tblChiTietHDBan.GiamGia,ThanhTien from "+
                    "tblChiTietHDBan inner join tblHang on tblHang.MaHang=tblChiTietHDBan.MaHang where MaHDBan='" 
                    + txtMaHD.Text + "'");
                dgvHDB.Columns[0].HeaderText = "Mã hàng";
            }
            btnHuyHD.Enabled = true;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
            
            
            //Đưa dữ liệu vào file Excel
            tenTruong.Range["A1:D1"].MergeCells = true;
            tenTruong.Range["A1"].Value = "CỬA HÀNG BÁN ĐỒ VĂN BÌNH";
            tenTruong.Range["A2"].Value = "Địa chỉ: HÀ ĐÔNG - Hà Nội";
            tenTruong.Range["A3"].Value = "Điện thoại: 0333234148";
            tenTruong.Range["c5:f5"].MergeCells = true ;
            tenTruong.Range["C5:F5"].Font.Size = 18;
            tenTruong.Range["C5:F5"].Font.Color  = System.Drawing.Color.Red ;
            tenTruong.Range["C5"].Value = "HÓA ĐƠN BÁN";
            tenTruong.Range["A7"].Value  = "Mã HĐ: " + txtMaHD.Text ;
            tenTruong.Range["A8"].Value = "Khách hàng: "  + txtTenKH.Text;
            tenTruong.Range["A9"].Value = "Số ĐT Khách: " + txtDienThoai.Text ;
            tenTruong.Range["A10"].Value = "STT ";
            tenTruong.Range["B10"].Value = "Mã Hàng ";
            tenTruong.Range["C10"].Value = "Tên hàng ";
            tenTruong.Range["D10"].Value = "Số lượng ";
            tenTruong.Range["E10"].Value = "Đơn giá bán";
            tenTruong.Range["F10"].Value = "Giảm giá";
            tenTruong.Range["G10"].Value = "Thành tiền ";
            int hang = 10;

            int index = 0;
            foreach(DataGridViewRow data in dgvHDB.Rows)
            {
                hang++;
                tenTruong.Range["A" + hang.ToString()].Value = (index + 1).ToString();
                tenTruong.Range["B" + hang.ToString()].Value = data.Cells[0].Value;
                tenTruong.Range["C" + hang.ToString()].Value = data.Cells[1].Value;
                tenTruong.Range["D" + hang.ToString()].Value = data.Cells[2].Value;
                tenTruong.Range["E" + hang.ToString()].Value = data.Cells[3].Value;
                tenTruong.Range["F" + hang.ToString()].Value = data.Cells[4].Value;
                tenTruong.Range["G" + hang.ToString()].Value = data.Cells[5].Value;
            }
            tenTruong.Range["D" + (hang + 1).ToString()].Value = "Tổng tiền: "+ txtTongTien.Text ;
            tenTruong.Range["C" + (hang+2).ToString()].Value = "Nhân viên bán: " + txtTenNV.Text ;

                exSheet.Name = "HoaDonBan";
            exBook.Activate();
            if(file.ShowDialog()==DialogResult.OK)
                exBook.SaveAs(file.FileName.ToString());
            exApp.Quit();                        
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ban co muon xoa san pham nay?", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                //cong lai so luong
                for(int i = 0; i < dgvHDB.Rows.Count -1; ++i)
                {
                    string maHang = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                    DataTable dtHang = dtBase.DocBang("Select * from tblHang where MaHang = '" + maHang + "'");
                    int slcon = int.Parse(dtHang.Rows[0]["SoLuong"].ToString())
                           + int.Parse(dgvHDB.CurrentRow.Cells[3].Value.ToString());
                    dtBase.CapNhatDuLieu("Update tblHang set SoLuong = " + slcon + " where MaHang = '" + maHang + "'");
                    
                }
                //xoa hoa don
                dtBase.CapNhatDuLieu("Delete tblHDBan where MaHDBan = '" + txtMaHD.Text + "'");
                btnThemHD.Enabled = true;
                ResetValue();
            }
        }

        private void dgvHoaDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa san pham nay?","Yes/No",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                //cap nhat lai so luong trong bang hang
                string maHang = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                DataTable dtHang = dtBase.DocBang("Select * from tblHang where MaHang = '" + maHang + "'");
                int slcon = int.Parse(dtHang.Rows[0]["SoLuong"].ToString())
                            +int.Parse(dgvHDB.CurrentRow.Cells[3].Value.ToString());
                dtBase.CapNhatDuLieu("Update tblHang set SoLuong = " + slcon + " where MaHang = '" + maHang + "'");

                //tinh lai tong tien hoa don
                double tongtien = double.Parse(txtTongTien.Text)
                                - double.Parse(dgvHDB.CurrentRow.Cells[5].Value.ToString());
                dtBase.CapNhatDuLieu("update tblHDBan set TongTien = '" + tongtien.ToString() + "' where MaHDBan = '" + txtMaHD.Text + "'");
                txtTongTien.Text = tongtien.ToString();
                dtBase.CapNhatDuLieu("delete tblChiTietHDBan where MaHDBan = '" + txtMaHD.Text + "' and MaHang = '"+ maHang +"'");
                if(tongtien == 0)
                {
                    dtBase.CapNhatDuLieu("Delete tblHDBan where MaHDBan = '" + txtMaHD.Text + "'");
                }
                //xoa chi tiet
                //load lai dataGridView
                dgvHDB.DataSource = dtBase.DocBang("Select tblChiTietHDBan.MaHang,TenHang,DonGiaBan,tblChiTietHDBan.SoLuong,tblChiTietHDBan.GiamGia,ThanhTien from tblChiTietHDBan inner join tblHang on tblHang.MaHang=tblChiTietHDBan.MaHang where MaHDBan='" + txtMaHD.Text + "'");
                btnThemHD.Enabled = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.Trangchu != null) Trangchu.Show();
            else
            {
                User f = new User();
                f.Show();
            }
        }

        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Trangchu != null) Trangchu.Show();
            else
            {
                User f = new User();
                f.Show();
            }
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            ThemDuLieu them = new ThemDuLieu(1);
            them.Show();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            ThemDuLieu them = new ThemDuLieu(0);
            them.Show();
        }
    }
}
