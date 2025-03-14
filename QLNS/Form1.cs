using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QLNS
{
    public partial class fmDangKy : Form
    {
        string sCon = @"Data Source=LAPTOP-LBNH44DN;Initial Catalog=QLNS;Integrated Security=True";
        public fmDangKy()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào, hẹn gặp lại lần sau!", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            // Bước 2
            // Chuẩn bị dữ liệu
            // kiểm tra tính hợp lệ của dữ liệu...
            if (string.IsNullOrWhiteSpace(txtMDN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đăng nhập!", "Thông báo");
                txtMDN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                txtMK.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHVT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên!", "Thông báo");
                txtHVT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tuổi!", "Thông báo");
                txtTuoi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoiO.Text))
            {
                MessageBox.Show("Vui lòng nhập nơi ở!", "Thông báo");
                txtNoiO.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                txtSDT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập số CCCD!", "Thông báo");
                txtCCCD.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTKNH.Text))
            {
                MessageBox.Show("Vui lòng nhập số TKNH!", "Thông báo");
                txtTKNH.Focus();
                return;
            }

            // gán dữ liệu vào biến
            string sMDN  = txtMDN.Text;            
            string sHVT  = txtHVT.Text;
            string sNoiO = txtNoiO.Text;
            string sTKNH = txtTKNH.Text;
            string sCCCD = txtCCCD.Text;
            string sMK = txtMK.Text;
            string sSDT = txtSDT.Text;

            string sQuery = "INSERT INTO NhanVien (MaDangNhap, TenNV, TuoiNV, DiaChi, SoTaiKhoanNH,  CCCD,  MatKhau,SDT) " +
   "VALUES (@MaDangNhap, @TenNV, @TuoiNV, @DiaChi, @SoTKNH, @CCCD, @MatKhau, @SDT)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaDangNhap", sMDN);
            cmd.Parameters.AddWithValue("@TenNV", sHVT);

            int sTuoi;
            if (!int.TryParse(txtTuoi.Text, out sTuoi))
            {
                MessageBox.Show("Tuổi phải là số!", "Thông báo");
                txtTuoi.Focus();
                return;
            }
            cmd.Parameters.AddWithValue("@TuoiNV", sTuoi);
            cmd.Parameters.AddWithValue("@DiaChi", sNoiO);
            cmd.Parameters.AddWithValue("@SoTKNH", sTKNH);
            cmd.Parameters.AddWithValue("@CCCD", sCCCD);
            cmd.Parameters.AddWithValue("@MatKhau", sMK);
            cmd.Parameters.AddWithValue("@SDT", sSDT);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi trong quá trình đăng ký: {ex.Message}", "Thông báo");
            }

            con.Close(); // Bước 3
        }
    }
}
