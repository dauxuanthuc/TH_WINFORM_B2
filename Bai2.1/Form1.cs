using System;
using System.Windows.Forms;
namespace Bai2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtSoA.Text);
                double b = double.Parse(txtSoB.Text);
                string phepToan = (sender as Button).Name; // Lấy phép toán từ Name của nút

                double ketQua = 0;

                switch (phepToan)
                {
                    case "btnCong":
                        ketQua = a + b;
                        break;
                    case "btnTru":
                        ketQua = a - b;
                        break;
                    case "btnNhan":
                        ketQua = a * b;
                        break;
                    case "btnChia":
                        if (b == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ketQua = a / b;
                        break;
                }

                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


