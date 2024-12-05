namespace bai2._4
{
    public partial class Form1 : Form
    {
        private List<TaiKhoan> danhsachtaikhoan = new List<TaiKhoan>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string soTK = txtSoTaiKhoan.Text;
                string hoTen = txtTenKhachHang.Text;
                string diaChi = txtDiaChi.Text;
                double soTien;

                if (!double.TryParse(txtSoTien.Text, out soTien))
                {
                    MessageBox.Show("Vui long nhap so tien hop le!!! ", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(soTK) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(diaChi))
                {
                    MessageBox.Show("Vui long nhap day du thong tin!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var taikhoanHienTai = danhsachtaikhoan.FirstOrDefault(tk => tk.SOTK == soTK);
                if (taikhoanHienTai != null)
                {
                    // Nếu tài khoản đã tồn tại, cập nhật thông tin
                    taikhoanHienTai.SOTK = soTK;
                    taikhoanHienTai.TEN = hoTen;
                    taikhoanHienTai.DC = diaChi;
                    taikhoanHienTai.ST = soTien;

                    // Cập nhật thông tin trong DataGridView
                    foreach (DataGridViewRow row in dgvQLTK.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == soTK) // Kiểm tra cột SOTK
                        {
                            row.Cells[1].Value = hoTen;  // Cập nhật Tên
                            row.Cells[2].Value = diaChi; // Cập nhật Địa chỉ
                            row.Cells[3].Value = soTien; // Cập nhật Số tiền
                            break;
                        }
                    }

                    // Thông báo thành công
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong form nhập liệu
                    ClearInputs();

                    // Cập nhật thống kê


                    return;
                }

                // Nếu tài khoản chưa tồn tại, thêm mới
                TaiKhoan taikhoanMoi = new TaiKhoan
                {
                    SOTK = soTK,
                    TEN = hoTen,
                    DC = diaChi,
                    ST = soTien
                };

                // Thêm tài khoản vào danh sách
                danhsachtaikhoan.Add(taikhoanMoi);

                // Thêm tài khoản vào DataGridView
                dgvQLTK.Rows.Add(taikhoanMoi.SOTK, taikhoanMoi.TEN, taikhoanMoi.DC, taikhoanMoi.ST);

                // Xóa dữ liệu trong form nhập liệu
                ClearInputs();

                //cap nhat so Tien
                TongTien();


                // Thông báo thêm mới thành công
                MessageBox.Show("Them tai khoan thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da xay ra loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearInputs()
        {
            txtSoTaiKhoan.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoTien.Text = string.Empty;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
                if (dgvQLTK.SelectedRows.Count > 0)
                {
                    // Lấy mã sinh viên từ dòng được chọn
                    string soTKXoa = dgvQLTK.SelectedRows[0].Cells[0].Value.ToString(); // Cột 0 là Mã SV

                    // Tìm sinh viên trong danh sách
                    var TaiKhoanXoa = danhsachtaikhoan.FirstOrDefault(sv => sv.SOTK == soTKXoa);

                    if (TaiKhoanXoa != null)
                    {
                        // Hiển thị hộp thoại xác nhận
                        var confirmResult = MessageBox.Show($"Ban co chac xoa tai khoan co soTK: {soTKXoa}?",
                                                            "Xac nhan xoa",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Xóa sinh viên khỏi danh sách
                            danhsachtaikhoan.Remove(TaiKhoanXoa);

                            // Xóa dòng khỏi DataGridView
                            dgvQLTK.Rows.RemoveAt(dgvQLTK.SelectedRows[0].Index);

                            //cap nhat so Tien
                            TongTien();


                            MessageBox.Show("Xoa tai khoan thanh cong!", "Tho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khong tim thay tai khoan can xoa!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui long chon mot tai khoan de xoa!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra khi xoa: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TongTien()
        {
            double tongTien = danhsachtaikhoan.Sum(tk => tk.ST);
            txtTongTien.Text = tongTien.ToString() + "   VND";
        }
    }
}
