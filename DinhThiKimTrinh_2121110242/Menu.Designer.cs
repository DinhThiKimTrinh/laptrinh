namespace DinhThiKimTrinh_2121110242
{
    partial class Menu
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
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnquantri = new System.Windows.Forms.Button();
            this.btndiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSinhVien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnSinhVien.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.sinhvien;
            this.btnSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 3);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(219, 112);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGiangVien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangVien.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.teacher;
            this.btnGiangVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiangVien.Location = new System.Drawing.Point(0, 238);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(219, 103);
            this.btnGiangVien.TabIndex = 1;
            this.btnGiangVien.Text = "Giảng Viên";
            this.btnGiangVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiangVien.UseVisualStyleBackColor = false;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnthoat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.logout;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(0, 448);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(219, 95);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Đăng Xuất";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnquantri);
            this.panel1.Controls.Add(this.btndiem);
            this.panel1.Controls.Add(this.btnSinhVien);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnGiangVien);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 551);
            this.panel1.TabIndex = 3;
            // 
            // btnquantri
            // 
            this.btnquantri.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnquantri.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquantri.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.profile__1_;
            this.btnquantri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquantri.Location = new System.Drawing.Point(0, 347);
            this.btnquantri.Name = "btnquantri";
            this.btnquantri.Size = new System.Drawing.Size(219, 95);
            this.btnquantri.TabIndex = 4;
            this.btnquantri.Text = "Quản Trị";
            this.btnquantri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquantri.UseVisualStyleBackColor = false;
            this.btnquantri.Click += new System.EventHandler(this.btnquantri_Click);
            // 
            // btndiem
            // 
            this.btndiem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndiem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiem.ForeColor = System.Drawing.Color.Black;
            this.btndiem.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.book;
            this.btndiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndiem.Location = new System.Drawing.Point(0, 121);
            this.btndiem.Name = "btndiem";
            this.btndiem.Size = new System.Drawing.Size(219, 112);
            this.btndiem.TabIndex = 3;
            this.btndiem.Text = "Nhập Điểm";
            this.btndiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndiem.UseVisualStyleBackColor = false;
            this.btndiem.Click += new System.EventHandler(this.btndiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DinhThiKimTrinh_2121110242.Properties.Resources.Thiet_ke_Truong_Cao_Dang_Bach_Khoa_Sai_Gon_TPHCM_1920x1080;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(228, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 546);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.Nen_xanh_duong_pastel;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(398, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DinhThiKimTrinh_2121110242.Properties.Resources.Nen_xanh_duong_pastel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquantri;
    }
}