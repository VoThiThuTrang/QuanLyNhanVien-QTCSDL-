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
    public partial class fmLichLam : Form
    {
        string sCon = "Data Source=LAPTOP-LBNH44DN;Initial Catalog=QLNS;Integrated Security=True";
        public fmLichLam()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            string sQuery = "select * from LichLam";
            string sQueryL = "select * from LichLamNV";

            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQueryL, con);

            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();

            adapter.Fill(ds, "LichLam");
            adapter1.Fill(ds1, "LichLamNV");

            BangLichLam.DataSource = ds.Tables["LichLam"];
            BangLichLamNV.DataSource = ds1.Tables["LichLamNV"];

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMB.Text) || string.IsNullOrEmpty(txtCaLam.Text)  || string.IsNullOrEmpty(txtNL.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                return;
            }

            string sMDN = txtMDN.Text;
            string sMB = txtMB.Text;
            string sCaLam = txtCaLam.Text;
            string sNgayNghi = txtNN.Text;
            string sNgayLam = txtNL.Text;

            string sQuery = "update LichLam set NgayLam = @NgayLam, CaLam = @CaLam, NgayNghi = @NgayNghi where MaBang = @MaBang";
            string sQuery1 = "update LichLamNV set MaDangNhap = @MaDangNhap where MaBang = @MaBang";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            SqlCommand cmd1 = new SqlCommand(sQuery1, con);

            cmd.Parameters.AddWithValue("@MaBang", sMB);
            cmd.Parameters.AddWithValue("@NgayLam", sNgayLam);
            cmd.Parameters.AddWithValue("@CaLam", sCaLam);
            cmd.Parameters.AddWithValue("@NgayNghi", sNgayNghi);
            cmd1.Parameters.AddWithValue("@MaBang", sMB);
            cmd1.Parameters.AddWithValue("@MaDangNhap", sMDN);

            try
            {
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật lỗi: " + ex.Message);
            }
            con.Close();
        }


        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMB.Text) || string.IsNullOrEmpty(txtCaLam.Text)  || string.IsNullOrEmpty(txtNL.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                return;
            }

            string sMDN = txtMDN.Text;
            string sMB = txtMB.Text;
            string sCaLam = txtCaLam.Text;
            string sNgayNghi = txtNN.Text;
            string sNgayLam = txtNL.Text;

            string sQuery = "insert into LichLam (MaBang, NgayLam, CaLam, NgayNghi) values (@MaBang, @NgayLam, @CaLam, @NgayNghi)";
            string sQuery1 = "insert into LichLamNV (MaBang, MaDangNhap) values (@MaBang, @MaDangNhap)";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            SqlCommand cmd1 = new SqlCommand(sQuery1, con);

            cmd.Parameters.AddWithValue("@MaBang", sMB);
            cmd.Parameters.AddWithValue("@NgayLam", sNgayLam);
            cmd.Parameters.AddWithValue("@CaLam", sCaLam);
            cmd.Parameters.AddWithValue("@NgayNghi", sNgayNghi);
            cmd1.Parameters.AddWithValue("@MaBang", sMB);
            cmd1.Parameters.AddWithValue("@MaDangNhap", sMDN);

            try
            {
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới lỗi: " + ex.Message);
            }
            con.Close();
        }




        private void BangLichLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra có chọn dòng hợp lệ không
            {
                txtMB.Text = BangLichLam.Rows[e.RowIndex].Cells["MaBang"].Value.ToString();
                txtCaLam.Text = BangLichLam.Rows[e.RowIndex].Cells["CaLam"].Value.ToString();
                txtNN.Text = BangLichLam.Rows[e.RowIndex].Cells["NgayNghi"].Value.ToString();
                txtNL.Text = BangLichLam.Rows[e.RowIndex].Cells["NgayLam"].Value.ToString();
                txtMB.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.");
            }
        }


        private void buttonXoa_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                    return;
                }

                string sMDN = txtMDN.Text;
                string sMB = txtMB.Text;

                string sQuery1 = "delete from LichLamNV where MaBang = @MaBang";
                string sQuery = "delete from LichLam where MaBang = @MaBang";

                SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                SqlCommand cmd = new SqlCommand(sQuery, con);

                cmd1.Parameters.AddWithValue("@MaBang", sMB);
                cmd.Parameters.AddWithValue("@MaBang", sMB);
                

                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lỗi: " + ex.Message);
                }
                con.Close();
            }
        }

    }
}
