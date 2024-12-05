namespace bai2._2
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
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            cbbChuyenNganh = new ComboBox();
            rbtnNu = new RadioButton();
            rbtnNam = new RadioButton();
            txtDiemTB = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvQLSV = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            ChuyenNganh = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            txtTongNam = new TextBox();
            txtTongNu = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLSV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cbbChuyenNganh);
            groupBox1.Controls.Add(rbtnNu);
            groupBox1.Controls.Add(rbtnNam);
            groupBox1.Controls.Add(txtDiemTB);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(200, 270);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(50, 270);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm/Sửa";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cbbChuyenNganh
            // 
            cbbChuyenNganh.FormattingEnabled = true;
            cbbChuyenNganh.Items.AddRange(new object[] { "QTKD", "CNTT", "NMA" });
            cbbChuyenNganh.Location = new Point(129, 228);
            cbbChuyenNganh.Name = "cbbChuyenNganh";
            cbbChuyenNganh.Size = new Size(177, 28);
            cbbChuyenNganh.TabIndex = 10;
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(200, 144);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(49, 24);
            rbtnNu.TabIndex = 9;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nu";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Location = new Point(114, 144);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(62, 24);
            rbtnNam.TabIndex = 8;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(104, 182);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(202, 27);
            txtDiemTB.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(104, 92);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(202, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(104, 42);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(202, 27);
            txtMaSV.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 236);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "ChuyenNganh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 189);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "DiemTB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 141);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "GioiTinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 92);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "HoTen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 45);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "MaSV";
            // 
            // dgvQLSV
            // 
            dgvQLSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLSV.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, GioiTinh, DiemTB, ChuyenNganh });
            dgvQLSV.Location = new Point(370, 74);
            dgvQLSV.Name = "dgvQLSV";
            dgvQLSV.RowHeadersWidth = 51;
            dgvQLSV.RowTemplate.Height = 29;
            dgvQLSV.Size = new Size(647, 297);
            dgvQLSV.TabIndex = 1;
            dgvQLSV.CellClick += dgvQLSV_CellClick;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "Mã SV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // DiemTB
            // 
            DiemTB.HeaderText = "Điểm TB";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.Width = 125;
            // 
            // ChuyenNganh
            // 
            ChuyenNganh.HeaderText = "Chuyên Ngành";
            ChuyenNganh.MinimumWidth = 6;
            ChuyenNganh.Name = "ChuyenNganh";
            ChuyenNganh.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 395);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 13;
            label6.Text = "tongSoNam";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(807, 395);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 14;
            label7.Text = "tongSoNu";
            // 
            // txtTongNam
            // 
            txtTongNam.Location = new Point(674, 392);
            txtTongNam.Name = "txtTongNam";
            txtTongNam.ReadOnly = true;
            txtTongNam.Size = new Size(91, 27);
            txtTongNam.TabIndex = 13;
            // 
            // txtTongNu
            // 
            txtTongNu.Location = new Point(904, 392);
            txtTongNu.Name = "txtTongNu";
            txtTongNu.ReadOnly = true;
            txtTongNu.Size = new Size(91, 27);
            txtTongNu.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(355, 9);
            label8.Name = "label8";
            label8.Size = new Size(258, 41);
            label8.TabIndex = 13;
            label8.Text = "Quản Lý Sinh Viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 481);
            Controls.Add(label8);
            Controls.Add(txtTongNu);
            Controls.Add(txtTongNam);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvQLSV);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cbbChuyenNganh;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private TextBox txtDiemTB;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvQLSV;
        private Label label6;
        private Label label7;
        private TextBox txtTongNam;
        private TextBox txtTongNu;
        private Label label8;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiemTB;
        private DataGridViewTextBoxColumn ChuyenNganh;
    }
}
