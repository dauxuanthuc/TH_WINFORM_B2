namespace bai2._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSoTaiKhoan = new TextBox();
            txtTenKhachHang = new TextBox();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            dgvQLTK = new DataGridView();
            label6 = new Label();
            txtTongTien = new TextBox();
            MATK = new DataGridViewTextBoxColumn();
            TEN = new DataGridViewTextBoxColumn();
            DC = new DataGridViewTextBoxColumn();
            ST = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvQLTK).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(537, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Thông Tin Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 78);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 116);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 153);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 190);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 4;
            label5.Text = "Số Tiền Trong Tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Location = new Point(363, 75);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(424, 27);
            txtSoTaiKhoan.TabIndex = 5;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(363, 113);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(424, 27);
            txtTenKhachHang.TabIndex = 6;
            txtTenKhachHang.TextChanged += textBox2_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(363, 146);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(424, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(363, 187);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(424, 27);
            txtSoTien.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(378, 239);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm/Cập Nhật";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(563, 239);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(721, 239);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvQLTK
            // 
            dgvQLTK.BackgroundColor = SystemColors.ButtonHighlight;
            dgvQLTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLTK.Columns.AddRange(new DataGridViewColumn[] { MATK, TEN, DC, ST });
            dgvQLTK.Location = new Point(98, 270);
            dgvQLTK.Name = "dgvQLTK";
            dgvQLTK.RowHeadersWidth = 51;
            dgvQLTK.RowTemplate.Height = 29;
            dgvQLTK.Size = new Size(942, 198);
            dgvQLTK.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 493);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 13;
            label6.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(627, 486);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(244, 27);
            txtTongTien.TabIndex = 14;
            // 
            // MATK
            // 
            MATK.HeaderText = "Mã Tài Khoản";
            MATK.MinimumWidth = 6;
            MATK.Name = "MATK";
            MATK.Width = 125;
            // 
            // TEN
            // 
            TEN.HeaderText = "Họ và Tên";
            TEN.MinimumWidth = 6;
            TEN.Name = "TEN";
            TEN.Width = 125;
            // 
            // DC
            // 
            DC.HeaderText = "Địa Chỉ";
            DC.MinimumWidth = 6;
            DC.Name = "DC";
            DC.Width = 125;
            // 
            // ST
            // 
            ST.HeaderText = "Số Tiền";
            ST.MinimumWidth = 6;
            ST.Name = "ST";
            ST.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 535);
            Controls.Add(txtTongTien);
            Controls.Add(label6);
            Controls.Add(dgvQLTK);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtSoTien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản Lý Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)dgvQLTK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKhachHang;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridView dgvQLTK;
        private Label label6;
        private TextBox txtTongTien;
        private DataGridViewTextBoxColumn MATK;
        private DataGridViewTextBoxColumn TEN;
        private DataGridViewTextBoxColumn DC;
        private DataGridViewTextBoxColumn ST;
    }
}
