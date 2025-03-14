using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class fmGiaoDienChinh : Form
    {
        public fmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhanVien nhanvien = new fmNhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void quảnLýLịchLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmLichLam lichlam = new fmLichLam();
            lichlam.MdiParent = this;
            lichlam.Show();
        }

        private void fmGiaoDienChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
