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
    public partial class XemDiem : Form
    {
        DiemBAL diem = new DiemBAL();
        AreaBAL ml = new AreaBAL();
        public XemDiem()
        {
            InitializeComponent();
        }

        private void dgvXemDiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvXemDiem_Load(object sender, EventArgs e)
        {
            List<SinhVienBEL> lstCus = diem.ReadDSV();
            foreach (SinhVienBEL cus in lstCus)
            {
                dgvXemDiem.Rows.Add(cus.id, cus.name, cus.TenML,cus.diem);
            }
            List<GenderBEL> lstArea = ml.ReadGenderList();
            foreach (GenderBEL area in lstArea)
            {
                cbGT.Items.Add(area);
            }
            cbGT.DisplayMember = "gioitinh";
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            SinhVienBEL cus = new SinhVienBEL();

            cus.id = int.Parse(tbid.Text);
            cus.name = tbname.Text;
            cus.ML = (GenderBEL)cbGT.SelectedItem;
            cus.diem = txbdiem.Text;

            diem.Newdiem(cus);

            dgvXemDiem.Rows.Add(cus.id, cus.name, cus.ML.gioitinh,cus.diem);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvXemDiem.CurrentRow;

            if (row != null)
            {
                SinhVienBEL sv = new SinhVienBEL();

                sv.id = int.Parse(tbid.Text);
                sv.name = tbname.Text;
                sv.ML = (GenderBEL)cbGT.SelectedItem;
                sv.diem = txbdiem.Text;

                diem.Editdiem(sv);

                row.Cells[0].Value = sv.id;
                row.Cells[1].Value = sv.name;
                row.Cells[2].Value = sv.TenML;
                row.Cells[3].Value = sv.diem;

            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVienBEL sv = new SinhVienBEL();
            sv.id = int.Parse(tbid.Text);
            sv.name = tbname.Text;
            sv.diem = txbdiem.Text;
            sv.ML = (GenderBEL)cbGT.SelectedItem;

            int idx = dgvXemDiem.CurrentCell.RowIndex;
            diem.Deletediem(sv);
            dgvXemDiem.Rows.RemoveAt(idx);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void dgvXemDiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvXemDiem.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbid.Text = row.Cells[0].Value.ToString();
                tbname.Text = row.Cells[1].Value.ToString();
                cbGT.Text = row.Cells[2].Value.ToString();
                txbdiem.Text = row.Cells[3].Value.ToString();

            }
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dgvXemDiem.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvXemDiem.Columns[i].HeaderText;

            }
            for (int i = 0; i < dgvXemDiem.Rows.Count; i++)
            {
                for (int j = 0; j < dgvXemDiem.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvXemDiem.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;



        }

        private void Excel_Click(object sender, EventArgs e)
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
    }
}
