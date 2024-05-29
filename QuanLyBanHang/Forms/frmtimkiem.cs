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
            var colLoaihang = new DataGridTextBoxColumn();
            var colTensp = new DataGridTextBoxColumn();
            var colGiatien = new DataGridTextBoxColumn();
            var colcongsuat = new DataGridTextBoxColumn();

            colLoaihang.HeaderText = "Loại Hàng";
            colTensp.HeaderText = "Tên sản phẩm";
            colGiatien.HeaderText = "Giá tiền";
            colcongsuat.HeaderText = "Công suất";

            dtgvTimkiem.Columns.AddRange(new DataGridViewColumn[] {colLoaihang, colTensp, colGiatien, colcongsuat});
        }

        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            DataTable dtCL = new DataTable();
            dtCL = dtBase.DocBang("Select * from tblHang");
            //Gắn dl vào datagridview
            dtgvTimkiem.DataSource = dtCL;

            dtgvTimkiem.Columns[0].HeaderText = "Loại Hàng";
            dtgvTimkiem.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvTimkiem.Columns[2].HeaderText = "Giá Tiền";
            dtgvTimkiem.Columns[3].HeaderText = "Công suất";
            dtgvTimkiem.Columns[4].HeaderText = "Đơn giá bán";

            int size = dgvChatLieu.Width / 5;

            dtgvTimkiem.Columns[0].Width = size - 52;
            dtgvTimkiem.Columns[1].Width = size;
            dtgvTimkiem.Columns[2].Width = size;
            dtgvTimkiem.Columns[3].Width = size;
            dtgvTimkiem.Columns[4].Width = size;
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
    }
}
