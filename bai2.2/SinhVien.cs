using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._2
{
     class SinhVien
    {
        private String MaSV;
        private String HoTen;
        private String ChuyenNganh;
        private float DiemTB;
        private String GioiTinh;

        public SinhVien()
        {
        }

        public SinhVien(string maSV, string hoTen, string chuyenNganh, float diemTB, string gioiTinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            ChuyenNganh = chuyenNganh;
            DiemTB = diemTB;
            GioiTinh = gioiTinh;
        }

        public String MASV {  get => MaSV; set => MaSV = value; }
        public String HOTEN {  get => HoTen; set => HoTen = value; }
        public String CHUYENNGANH { get => ChuyenNganh; set => ChuyenNganh = value; }
        public float DIEMTB {  get => DiemTB; set => DiemTB = value; }
        public String GIOITINH {  get => GioiTinh;set => GioiTinh = value;}
    }
}
