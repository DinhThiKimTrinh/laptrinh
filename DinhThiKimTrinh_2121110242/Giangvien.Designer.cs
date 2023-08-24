namespace DinhThiKimTrinh_2121110242
{
    partial class Giangvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giangvien));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPhanloai = new System.Windows.Forms.ComboBox();
            this.cbgt = new System.Windows.Forms.ComboBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Excel = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGiangVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(337, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(938, 464);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGiangVien.Location = new System.Drawing.Point(5, 20);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(928, 439);
            this.dgvGiangVien.TabIndex = 0;
            this.dgvGiangVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã GV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên GV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioitinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPhanloai);
            this.groupBox1.Controls.Add(this.cbgt);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAnh);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.tbid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 460);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboPhanloai
            // 
            this.cboPhanloai.FormattingEnabled = true;
            this.cboPhanloai.Items.AddRange(new object[] {
            "Cơ Hữu",
            "Thỉnh giảng"});
            this.cboPhanloai.Location = new System.Drawing.Point(139, 228);
            this.cboPhanloai.Name = "cboPhanloai";
            this.cboPhanloai.Size = new System.Drawing.Size(173, 24);
            this.cboPhanloai.TabIndex = 6;
            // 
            // cbgt
            // 
            this.cbgt.FormattingEnabled = true;
            this.cbgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgt.Location = new System.Drawing.Point(139, 155);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(173, 24);
            this.cbgt.TabIndex = 3;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(139, 421);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(173, 22);
            this.txtAnh.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "File ảnh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Giới tính:";
            // 
            // btnAnh
            // 
            this.btnAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnh.Location = new System.Drawing.Point(345, 264);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(76, 106);
            this.btnAnh.TabIndex = 33;
            this.btnAnh.Text = "Chọn\r\nẢnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(139, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 106);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ảnh đại diện:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phân loại GV:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(139, 101);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(173, 22);
            this.tbname.TabIndex = 2;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(139, 52);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(173, 22);
            this.tbid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(347, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // Excel
            // 
            this.Excel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.ForeColor = System.Drawing.Color.Black;
            this.Excel.Image = ((System.Drawing.Image)(resources.GetObject("Excel.Image")));
            this.Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Excel.Location = new System.Drawing.Point(897, 542);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(127, 69);
            this.Excel.TabIndex = 31;
            this.Excel.Text = "Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnout
            // 
            this.btnout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.ForeColor = System.Drawing.Color.Black;
            this.btnout.Image = ((System.Drawing.Image)(resources.GetObject("btnout.Image")));
            this.btnout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.Location = new System.Drawing.Point(1061, 542);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(117, 69);
            this.btnout.TabIndex = 19;
            this.btnout.Text = "Thoát ";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(723, 542);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(148, 69);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(549, 542);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(136, 69);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhap.ForeColor = System.Drawing.Color.Black;
            this.btnnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnnhap.Image")));
            this.btnnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhap.Location = new System.Drawing.Point(356, 542);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(140, 69);
            this.btnnhap.TabIndex = 16;
            this.btnnhap.Text = "Thêm";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click_1);
            // 
            // Giangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DinhThiKimTrinh_2121110242.Properties.Resources.Nen_xanh_duong_pastel;
            this.ClientSize = new System.Drawing.Size(1279, 632);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Giangvien";
            this.Text = "Giangvien";
            this.Load += new System.EventHandler(this.Giangvien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPhanloai;
        private System.Windows.Forms.ComboBox cbgt;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}