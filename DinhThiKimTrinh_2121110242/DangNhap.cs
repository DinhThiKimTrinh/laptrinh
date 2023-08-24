using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DinhThiKimTrinh_2121110242
{
    public partial class DangNhap : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            taikhoan.sTaikhoan = txtTaiKhoan.Text;
            taikhoan.sMatkhau = txtMatKhau.Text;

            string getuser = TKBLL.CheckLogic(taikhoan);
            switch(getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Xin chúc mừng đã đăng nhập thành công!");
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }


        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
