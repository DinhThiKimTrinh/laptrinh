using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhThiKimTrinh_2121110242
{
    public partial class Menu : Form
    {
        Admin frmadmin = new Admin();
        XemDiem frmdiem = new XemDiem();
        Sinhvien frmsv = new Sinhvien();
        Giangvien frmgv = new Giangvien();
        
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
           
            frmsv.ShowDialog();
            frmgv.Hide();
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            
            frmgv.ShowDialog();
            frmsv.Hide();
        }

        private void btnPhuHuynh_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn đăng xuất không!");
            this.Close();
        }

        private void btndiem_Click(object sender, EventArgs e)
        {
            frmdiem.ShowDialog();
            frmdiem.Hide();
        }

        private void btnquantri_Click(object sender, EventArgs e)
        {
            frmadmin.ShowDialog();
            frmadmin.Hide();
        }
    }
}
