using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DinhThiKimTrinh_2121110242
{
    public partial class Giangvien : Form
    {
        GiangVienBAL GV = new GiangVienBAL();
        AreaBAL ml = new AreaBAL();
        public Giangvien()
        {
            InitializeComponent();
        }

        private void Giangvien_Load(object sender, EventArgs e)
        {
            List<GiangVienBEL> lstCus = GV.ReadGV();
            foreach (GiangVienBEL cus in lstCus)
            {
                dgvGiangVien.Rows.Add(cus.id, cus.name, cus.TenGT);
            }
            List<GenderBEL> lstArea = ml.ReadGenderList();
            foreach (GenderBEL area in lstArea)
            {
                cbgt.Items.Add(area);
            }
            cbgt.DisplayMember = "gioitinh";
        }

        private void btnnhap_Click_1(object sender, EventArgs e)
        {

            GiangVienBEL cus = new GiangVienBEL();
            cus.id = int.Parse(tbid.Text);
            cus.name = tbname.Text;
            cus.GT = (GenderBEL)cbgt.SelectedItem;
            GV.NewGV(cus);

            dgvGiangVien.Rows.Add(cus.id, cus.name, cus.GT.gioitinh);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGiangVien.CurrentRow;

            if (row != null)
            {
                GiangVienBEL gv = new GiangVienBEL();

                gv.id = int.Parse(tbid.Text);
                gv.name = tbname.Text;
                gv.GT = (GenderBEL)cbgt.SelectedItem;

                GV.EditGV(gv);

                row.Cells[0].Value = gv.id;
                row.Cells[1].Value = gv.name;
                row.Cells[2].Value = gv.TenGT;

            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
        }
        private void dgvGiangVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int idx = e.RowIndex;
            DataGridViewRow row = dgvGiangVien.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbid.Text = row.Cells[0].Value.ToString();
                tbname.Text = row.Cells[1].Value.ToString();
                cbgt.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            GiangVienBEL gv = new GiangVienBEL();
            gv.id = int.Parse(tbid.Text);
            gv.name = tbname.Text;
            gv.GT = (GenderBEL)cbgt.SelectedItem;

            int idx = dgvGiangVien.CurrentCell.RowIndex;
            GV.DeleteGV(gv);
            dgvGiangVien.Rows.RemoveAt(idx);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dgvGiangVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvGiangVien.Columns[i].HeaderText;

            }
            for (int i = 0; i < dgvGiangVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgvGiangVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvGiangVien.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;



        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }
            }

        }

        private void btnout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
