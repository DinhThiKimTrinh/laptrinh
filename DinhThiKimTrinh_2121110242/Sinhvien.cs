using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using DTO;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DinhThiKimTrinh_2121110242
{
    public partial class Sinhvien : Form
    {
        SinhVienBAL SV = new SinhVienBAL();
        AreaBAL ml = new AreaBAL();
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            List<SinhVienBEL> lstCus = SV.ReadSV();
            foreach (SinhVienBEL cus in lstCus)
            {
                dgvSinhVien.Rows.Add(cus.id, cus.name, cus.TenML);
            }
            List<GenderBEL> lstArea = ml.ReadGenderList();
            foreach (GenderBEL area in lstArea)
            {
                cbML.Items.Add(area);
            }
            cbML.DisplayMember = "gioitinh";
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            SinhVienBEL cus = new SinhVienBEL();
            cus.id = int.Parse(tbid.Text);
            cus.name = tbname.Text;
            cus.ML = (GenderBEL)cbML.SelectedItem;
            SV.NewSV(cus);

            dgvSinhVien.Rows.Add(cus.id, cus.name, cus.ML.gioitinh);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);

        }
      
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSinhVien.CurrentRow;

            if (row != null)
            {
                SinhVienBEL sv = new SinhVienBEL();

                sv.id= int.Parse(tbid.Text);
                sv.name = tbname.Text;
                sv.ML = (GenderBEL)cbML.SelectedItem;

                SV.EditSV(sv);

                row.Cells[0].Value = sv.id;
                row.Cells[1].Value = sv.name;
                row.Cells[2].Value = sv.TenML;
                
            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVienBEL sv = new SinhVienBEL();
            sv.id= int.Parse(tbid.Text);
            sv.name = tbname.Text;
            sv.ML= (GenderBEL)cbML.SelectedItem;

            int idx = dgvSinhVien.CurrentCell.RowIndex;
            SV.DeleteSV(sv);
            dgvSinhVien.Rows.RemoveAt(idx);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int idx = e.RowIndex;
            DataGridViewRow row = dgvSinhVien.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbid.Text = row.Cells[0].Value.ToString();
                tbname.Text = row.Cells[1].Value.ToString();
                cbML.Text = row.Cells[2].Value.ToString();

            }
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dgvSinhVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvSinhVien.Columns[i].HeaderText;

            }
            for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSinhVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvSinhVien.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;



        }
        private void Excel_Click_1(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

