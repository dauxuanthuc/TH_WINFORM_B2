using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._4
{
     class TaiKhoan
    {
        private String soTaiKhoan;
        private String tenKhachHang;
        private String diaChi;
        private double soTien;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string soTaiKhoan, string tenKhachHang, string diaChi, double soTien)
        {
            this.soTaiKhoan = soTaiKhoan;
            this.tenKhachHang = tenKhachHang;
            this.diaChi = diaChi;
            this.soTien = soTien;
        }

        public String SOTK {  get => soTaiKhoan;set => soTaiKhoan = value;}

        public String TEN {  get => tenKhachHang;set => tenKhachHang = value;}

        public String DC { get => diaChi; set => diaChi = value;}

        public double ST { get => soTien; set => soTien = value;}
    }
}
