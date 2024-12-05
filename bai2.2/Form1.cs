using System;
using System.Windows.Forms;
namespace bai2._2
{
    public partial class Form1 : Form
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbChuyenNganh.SelectedIndex = 0;
            rbtnNu.Checked = true;
            txtTongNam.Text = "0";
            txtTongNu.Text = "0";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox, radio button và comboBox
                string maSV = txtMaSV.Text;
                string hoTen = txtHoTen.Text;
                string chuyenNganh = cbbChuyenNganh.SelectedItem.ToString();
                float diemTB;

                if (!float.TryParse(txtDiemTB.Text, out diemTB))
                {
                    MessageBox.Show("Vui lòng nhập điểm trung bình hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gioiTinh = rbtnNam.Checked ? "Nam" : "Nu";

                if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem MSSV đã tồn tại trong danh sách hay chưa
                var sinhVienHienTai = danhSachSinhVien.FirstOrDefault(sv => sv.MASV == maSV);
                if (sinhVienHienTai != null)
                {
                    // Nếu đã tồn tại, cập nhật thông tin sinh viên
                    sinhVienHienTai.HOTEN = hoTen;
                    sinhVienHienTai.CHUYENNGANH = chuyenNganh;
                    sinhVienHienTai.DIEMTB = diemTB;
                    sinhVienHienTai.GIOITINH = gioiTinh;

                    // Cập nhật thông tin trong DataGridView
                    foreach (DataGridViewRow row in dgvQLSV.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == maSV) // Kiểm tra cột MSSV
                        {
                            row.Cells[1].Value = hoTen;         // Cập nhật Họ Tên
                            row.Cells[2].Value = gioiTinh;      // Cập nhật Giới Tính
                            row.Cells[3].Value = diemTB;        // Cập nhật Điểm TB
                            row.Cells[4].Value = chuyenNganh;   // Cập nhật Chuyên Ngành
                            break;
                        }
                    }

                    // Thông báo thành công
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong form nhập liệu
                    ClearInputs();

                    // Cập nhật thống kê
                    CapNhatThongKe();

                    return;
                }

                // Nếu MSSV chưa tồn tại, thêm mới sinh viên
                SinhVien sinhVienMoi = new SinhVien
                {
                    MASV = maSV,
                    HOTEN = hoTen,
                    CHUYENNGANH = chuyenNganh,
                    DIEMTB = diemTB,
                    GIOITINH = gioiTinh
                };

                // Thêm sinh viên vào danh sách
                danhSachSinhVien.Add(sinhVienMoi);

                // Thêm sinh viên vào DataGridView
                dgvQLSV.Rows.Add(sinhVienMoi.MASV, sinhVienMoi.HOTEN, sinhVienMoi.GIOITINH, sinhVienMoi.DIEMTB, sinhVienMoi.CHUYENNGANH);

                // Xóa dữ liệu trong form nhập liệu
                ClearInputs();

                // Cập nhật thống kê
                CapNhatThongKe();

                // Thông báo thêm mới thành công
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiemTB.Text = string.Empty;
            cbbChuyenNganh.SelectedIndex = 0; // Reset về lựa chọn đầu tiên
            rbtnNu.Checked = true; // Reset giới tính mặc định là Nữ
        }
        private void dgvQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng có click vào một dòng hợp lệ (không phải header) không
                if (e.RowIndex >= 0)
                {
                    // Lấy dữ liệu từ các ô trong dòng được chọn
                    string maSV = dgvQLSV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string hoTen = dgvQLSV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string gioiTinh = dgvQLSV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string diemTB = dgvQLSV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string chuyenNganh = dgvQLSV.Rows[e.RowIndex].Cells[4].Value.ToString();

                    // Hiển thị dữ liệu lên các textbox và combobox
                    txtMaSV.Text = maSV;
                    txtHoTen.Text = hoTen;
                    txtDiemTB.Text = diemTB;
                    cbbChuyenNganh.SelectedItem = chuyenNganh; // Chọn chuyên ngành từ combobox

                    // Đặt giới tính từ radio button
                    if (gioiTinh == "Nam")
                        rbtnNam.Checked = true;
                    else
                        rbtnNu.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatThongKe()
        {
            int tongSVNam = danhSachSinhVien.Count(sv => sv.GIOITINH == "Nam");
            int tongSVNu = danhSachSinhVien.Count(sv => sv.GIOITINH == "Nu");

            txtTongNam.Text = tongSVNam.ToString();
            txtTongNu.Text = tongSVNu.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
                if (dgvQLSV.SelectedRows.Count > 0)
                {
                    // Lấy mã sinh viên từ dòng được chọn
                    string maSVToXoa = dgvQLSV.SelectedRows[0].Cells[0].Value.ToString(); // Cột 0 là Mã SV

                    // Tìm sinh viên trong danh sách
                    var sinhVienToXoa = danhSachSinhVien.FirstOrDefault(sv => sv.MASV == maSVToXoa);

                    if (sinhVienToXoa != null)
                    {
                        // Hiển thị hộp thoại xác nhận
                        var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên với MSSV: {maSVToXoa}?",
                                                            "Xác nhận xóa",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Xóa sinh viên khỏi danh sách
                            danhSachSinhVien.Remove(sinhVienToXoa);

                            // Xóa dòng khỏi DataGridView
                            dgvQLSV.Rows.RemoveAt(dgvQLSV.SelectedRows[0].Index);

                            // Cập nhật lại thống kê
                            CapNhatThongKe();

                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
