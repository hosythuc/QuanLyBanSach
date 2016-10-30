using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSach.Forms;

namespace QuanLyBanSach
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            lblDongHo.Text="Thời gian: "+data.Hour+":"+data.Minute+":"+data.Second;
        }

        private void picDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc danhmuc = new frmDanhMuc();
            danhmuc.ShowDialog();
        }
    }
}
