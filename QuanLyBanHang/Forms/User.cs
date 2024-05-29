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
    public partial class User : Form
    {
        Classes.ProcessDatabase db = new Classes.ProcessDatabase();
        public User()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            
            string password = textBox2.Text;
            
            string query = "select * from tblUser where( [userName] ='" + username + "' and [passWord] = '"
                                    + password + "')";
            DataTable dt = new DataTable();
            dt = db.DocBang(query);

            if (dt.Rows.Count > 0)
            {
                Trangchu f = new Trangchu(this);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ten hoac mat khau ko dung");
                return;
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
