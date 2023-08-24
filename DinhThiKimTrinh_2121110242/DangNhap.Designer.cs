namespace DinhThiKimTrinh_2121110242
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(167, 59);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(221, 28);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(167, 105);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(221, 28);
            this.txtMatKhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogin.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.login__1_;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(51, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 74);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnThoat.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.logout__1_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(238, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 74);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Image = global::DinhThiKimTrinh_2121110242.Properties.Resources.Nen_xanh_duong_pastel;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(122, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng nhâp hệ thống Quản lý \r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.txtTaiKhoan);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(331, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 296);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DinhThiKimTrinh_2121110242.Properties.Resources.profile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(34, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 296);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DinhThiKimTrinh_2121110242.Properties.Resources.Nen_xanh_duong_pastel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Name = "DangNhap";
            this.Text = "user";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}

