using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTL_QUANLYTHUVIEN
{
    public partial class frmLogin : Form
    {
        public int chucVu = -1;
        public string maNV = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (NhanVien_BUS.login(tbUserName.Text, tbPassWord.Text).Rows.Count > 0)
            {
                // Form1 f = new Form1();
                // f.userName = tbUserName.Text;
                //   NhanVien_BUS.Login(tbUserName.Text, tbPassWord.Text);
                chucVu = 0;
                maNV = tbUserName.Text;
                //   MessageBox.Show(chucVu.ToString());
                //  f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
                tbUserName.Clear();
                tbPassWord.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
