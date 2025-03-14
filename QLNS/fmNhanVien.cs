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

namespace QLNS
{
    public partial class fmNhanVien : Form
    {
        string sCon = "Data Source=LAPTOP-LBNH44DN;Initial Catalog=QLNS;Integrated Security=True";
        public fmNhanVien()
        {
            InitializeComponent();
        }

        private void fmNhanVien_Load(object sender, EventArgs e)
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

            // BƯớc 2 - lấy dữ liệu về
            string sQuery = "select * from NhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "NhanVien");

            dataGridView1.DataSource = ds.Tables["NhanVien"];

            con.Close(); // Bước 3
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMDNNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDangNhap"].Value.ToString();
            txtHVTNV.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            txtTuoiNV.Text = dataGridView1.Rows[e.RowIndex].Cells["TuoiNV"].Value.ToString();
            txtNoiONV.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtTKNHNV.Text = dataGridView1.Rows[e.RowIndex].Cells["SoTaiKhoanNH"].Value.ToString();
            txtCCCDNV.Text = dataGridView1.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
            txtMKNV.Text = dataGridView1.Rows[e.RowIndex].Cells["Matkhau"].Value.ToString();

            txtSDTNV.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //b1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            //b2
            //laygiatri
            string sMDN = txtMDNNV.Text;
            string sTenNV = txtHVTNV.Text;
            string sTuoiNV = txtTuoiNV.Text;
            string sDiaChi = txtNoiONV.Text;
            string sSoTaiKhoanNH = txtTKNHNV.Text;
            string sCCCD = txtCCCDNV.Text;
            string sMatkhau = txtMKNV.Text;

            string sSDT = txtSDTNV.Text;

            string sQuery = "UPDATE NhanVien " +
                "SET TenNV = @TenNV, " +
                "    TuoiNV = @TuoiNV, " +
                "    DiaChi = @DiaChi, " +
                "    SoTaiKhoanNH = @SoTaiKhoanNH, " +
                "    CCCD = @CCCD, " +
                "    MatKhau = @MatKhau, " +
                "    SDT = @SDT " +
                "WHERE MaDangNhap = @MaDangNhap";


            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaDangNhap", sMDN);
            cmd.Parameters.AddWithValue("@TenNV", sTenNV);
            cmd.Parameters.AddWithValue("@TuoiNV", sTuoiNV);
            cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
            cmd.Parameters.AddWithValue("@SoTaiKhoanNH", sSoTaiKhoanNH);
            cmd.Parameters.AddWithValue("@CCCD", sCCCD);
            cmd.Parameters.AddWithValue("@MatKhau", sMatkhau);
            cmd.Parameters.AddWithValue("@SDT", sSDT);
            
            
            



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật");

            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                }
                string sMDN = txtMDNNV.Text;
                string sCCCD = txtCCCDNV.Text;
                string sTenNV = txtHVTNV.Text;
                string sDiaChi = txtNoiONV.Text;
                string sSDT = txtSDTNV.Text;
                string sMatkhau = txtMKNV.Text;
                string sTuoiNV = txtTuoiNV.Text;
                string sSoTaiKhoanNH = txtTKNHNV.Text;

                string sQuery = "delete NhanVien where MaDangNhap = @MaDangNhap";

                SqlCommand cmd = new SqlCommand(sQuery, con);

                cmd.Parameters.AddWithValue("@MaDangNhap", sMDN);
                cmd.Parameters.AddWithValue("@CCCD", sCCCD);
                cmd.Parameters.AddWithValue("@TenNV", sTenNV);
                cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
                cmd.Parameters.AddWithValue("@SDT", sSDT);
                cmd.Parameters.AddWithValue("@MatKhau", sMatkhau);
                cmd.Parameters.AddWithValue("@TuoiNV", sTuoiNV);
                cmd.Parameters.AddWithValue("@SoTaiKhoanNH", sSoTaiKhoanNH);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lỗi!");
                }
                con.Close();
            }
        }
    }
}
