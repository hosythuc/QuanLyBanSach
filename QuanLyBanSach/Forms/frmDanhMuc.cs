using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSach.Classes;

namespace QuanLyBanSach.Forms
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }


        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            CapNhapTheLoai();
            CapNhapNhaCungCap();
            CapNhapNhaSanXuat();
            CapNhapKhachHang();
            CapNhapNhanVien();
            CapNhapSach();
        }
        private void CapNhapTheLoai()
        {
            DataTable dtBang = DocDuLieu.DocBang("select * from tTheLoai");
            dgvTheLoai.DataSource = dtBang;
            dgvTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns[1].HeaderText = "Tên thể loại";
            dgvTheLoai.Columns[0].Width = 100;
            dgvTheLoai.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnThemTheLoai.Enabled = true;
            btnSuaTheLoai.Enabled = false;
            btnLuuTheLoai.Enabled = false;
            btnXoaTheLoai.Enabled = false;
            btnBoQuaTheLoai.Enabled = false;
        }
        private void CapNhapNhaCungCap()
        {
            DataTable dtBang1 = DocDuLieu.DocBang("select * from tNhaCungCap");
            dgvNhaCungCap.DataSource = dtBang1;
            dgvNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhaCungCap.Columns[0].Width = 100;
            dgvNhaCungCap.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnThemNCC.Enabled = true;
            btnSuaNCC.Enabled = false;
            btnLuuNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnBoQuaNCC.Enabled = false;
        }
        private void CapNhapNhaSanXuat()
        {
            DataTable dtBang2 = DocDuLieu.DocBang("select * from tNhaXuatBan");
            dgvNhaXuatBan.DataSource = dtBang2;
            dgvNhaXuatBan.Columns[0].HeaderText = "Mã nhà xuất bản";
            dgvNhaXuatBan.Columns[1].HeaderText = "Tên nhà xuất bản";
            dgvNhaXuatBan.Columns[0].Width = 100;
            dgvNhaXuatBan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnThemNXB.Enabled = true;
            btnSuaNXB.Enabled = false;
            btnLuuNXB.Enabled = false;
            btnXoaNXB.Enabled = false;
            btnBoQuaNXB.Enabled = false;
        }
        private void CapNhapSach()
        {
            DataTable dtBang = DocDuLieu.DocBang("select tSach.MaSach, tSach.TenSach, tSach.TacGia, tTheLoai.TenTheLoai,tNhaXuatBan.TenNXB, tSach.DonGiaNhap, tSach.DonGiaBan, tSach.SoLuong, tSach.SoTrang, tSach.TrongLuong from (tSach inner join tTheLoai on tSach.MaTheLoai=tTheLoai.MaTheLoai) inner join tNhaXuatBan on tSach.MaNXB=tNhaXuatBan.MaNXB");
            dgvSach.DataSource = dtBang;
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Tác giả";
            dgvSach.Columns[3].HeaderText = "Thể loại";
            dgvSach.Columns[4].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[5].HeaderText = "Đơn giá nhập";
            dgvSach.Columns[6].HeaderText = "Đơn giá bán";
            dgvSach.Columns[7].HeaderText = "Số lượng";
            dgvSach.Columns[8].HeaderText = "Số trang";
            dgvSach.Columns[9].HeaderText = "Trọng lượng";

            DataTable dtBang1 = DocDuLieu.DocBang("select * from tTheLoai");
            cbxTheLoai.DataSource = dtBang1;
            cbxTheLoai.DisplayMember = "TenTheLoai";
            cbxTheLoai.ValueMember = "MaTheLoai";

            DataTable dtBang2 = DocDuLieu.DocBang("select * from tNhaXuatBan");
            cbxNXB.DataSource = dtBang2;

            cbxNXB.DisplayMember = "TenNXB";
            cbxNXB.ValueMember = "MaNXB";

            btnThemSach.Enabled = true;
            btnSuaSach.Enabled = false;
            btnLuuSach.Enabled = false;
            btnXoaSach.Enabled = false;
            btnBoQuaSach.Enabled = false;
        }
        private void CapNhapKhachHang()
        {
            DataTable dtBang3 = DocDuLieu.DocBang("select * from tKhachHang");
            dgvKhachHang.DataSource = dtBang3;
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";

            dgvKhachHang.Columns[0].Width = 150;
            dgvKhachHang.Columns[1].Width = 150;
            dgvKhachHang.Columns[2].Width = 150;
            dgvKhachHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnThemKhachHang.Enabled = true;
            btnSuaKhachHang.Enabled = false;
            btnLuuKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = false;
            btnBoQuaKhachHang.Enabled = false;
        }
        private void CapNhapNhanVien()
        {
            DataTable dtBang4 = DocDuLieu.DocBang("select * from tNhanVien");
            dgvNhanVien.DataSource = dtBang4;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Số điện thoại";

            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[2].Width = 150;
            dgvNhanVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnThemNhanVien.Enabled = true;
            btnSuaNhanVien.Enabled = false;
            btnLuuNhanVien.Enabled = false;
            btnXoaNhanVien.Enabled = false;
            btnBoQuaNhanVien.Enabled = false;
        }
        //Xoa hết dữ liệu trong thông tin
        private void XoaTheLoai()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
        }
        private void XoaNCC()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
        }
        private void XoaNXB()
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
        }
        private void XoaSach()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            cbxNXB.SelectedText = "";
            cbxTheLoai.SelectedText = "";
            txtGiaBan.Text = "$0";
            txtGiaNhap.Text = "$0";
            txtSoLuong.Text = "";
            txtSoTrang.Text = "";
            txtTrongLuong.Text = "";
        }
        private void XoaKhachHang()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChiKhachHang.Text = "";
            txtSoDienThoaiKhachHang.Text = "";
        }
        private void XoaNhanVien()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChiNhanVien.Text = "";
            txtSoDienThoaiNhanVien.Text = "";
        }
        //Xử lý sự kiện click của data grid view
        private void dgvTheLoai_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Text = dgvTheLoai.CurrentRow.Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai.CurrentRow.Cells[1].Value.ToString();

            btnThemTheLoai.Enabled = true;
            btnSuaTheLoai.Enabled = true;
            btnLuuTheLoai.Enabled = false;
            btnXoaTheLoai.Enabled = true;
            btnBoQuaTheLoai.Enabled = true;
        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();

            btnThemNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            btnLuuNCC.Enabled = false;
            btnXoaNCC.Enabled = true;
            btnBoQuaNCC.Enabled = true;
        }

        private void dgvNhaXuatBan_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = dgvNhaXuatBan.CurrentRow.Cells[0].Value.ToString();
            txtTenNXB.Text = dgvNhaXuatBan.CurrentRow.Cells[1].Value.ToString();

            btnThemNXB.Enabled = true;
            btnSuaNXB.Enabled = true;
            btnLuuNXB.Enabled = false;
            btnXoaNXB.Enabled = true;
            btnBoQuaNXB.Enabled = true;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiKhachHang.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoaiKhachHang.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();

            btnThemKhachHang.Enabled = true;
            btnSuaKhachHang.Enabled = true;
            btnLuuKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = true;
            btnBoQuaKhachHang.Enabled = true;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNhanVien.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoaiNhanVien.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();

            btnThemNhanVien.Enabled = true;
            btnSuaNhanVien.Enabled = true;
            btnLuuNhanVien.Enabled = false;
            btnXoaNhanVien.Enabled = true;
            btnBoQuaNhanVien.Enabled = true;
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            txtTacGia.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            cbxTheLoai.SelectedText = dgvSach.CurrentRow.Cells[3].Value.ToString();
            cbxNXB.SelectedText = dgvSach.CurrentRow.Cells[4].Value.ToString();
            txtGiaNhap.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
            txtGiaBan.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            txtSoLuong.Text = dgvSach.CurrentRow.Cells[7].Value.ToString();
            txtSoTrang.Text = dgvSach.CurrentRow.Cells[8].Value.ToString();
            txtTrongLuong.Text = dgvSach.CurrentRow.Cells[9].Value.ToString();

            btnThemSach.Enabled = true;
            btnSuaSach.Enabled = true;
            btnLuuSach.Enabled = false;
            btnXoaSach.Enabled = true;
            btnBoQuaSach.Enabled = true;
        }
        //Xử lý sự kiện các nút thêm
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            XoaTheLoai();
            DataTable dtBang = DocDuLieu.DocBang("select MaTheLoai from tTheLoai order by MaTheLoai desc");
            String ma = dtBang.Rows[0][0].ToString();
            if (ma== "")
            {
                txtMaTheLoai.Text = "TL01";
            }
            else
            {
                String ma1 = ma.Substring(2);
                int dem = Int32.Parse(ma1)+1;
                if (dem <= 8)
                {
                    txtMaTheLoai.Text = "TL0" + dem;
                }
                else
                {
                    txtMaTheLoai.Text = "TL" + dem;
                }
            }
            btnThemTheLoai.Enabled = false;
            btnSuaTheLoai.Enabled = false;
            btnLuuTheLoai.Enabled = true;
            btnXoaTheLoai.Enabled = true;
            btnBoQuaTheLoai.Enabled = true;
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            XoaNCC();
            DataTable dtBang = DocDuLieu.DocBang("select MaNCC from tNhaCungCap order by MaNCC desc");
            String ma = dtBang.Rows[0][0].ToString();
            if (ma == "")
            {
                txtMaNCC.Text = "NCC01";
            }
            else
            {
                String ma1 = ma.Substring(3);
                int dem = Int32.Parse(ma1) + 1;
                if (dem <= 8)
                {
                    txtMaNCC.Text = "NCC0" + dem;
                }
                else
                {
                    txtMaNCC.Text = "NCC" + dem;
                }
            }
            btnThemNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            btnLuuNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
            btnBoQuaNCC.Enabled = true;
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            XoaNXB();
            DataTable dtBang = DocDuLieu.DocBang("select MaNXB from tNhaXuatBan order by MaNXB desc");
            String ma = dtBang.Rows[0][0].ToString();
            if (ma == "")
            {
                txtMaNXB.Text = "NXB01";
            }
            else
            {
                String ma1 = ma.Substring(3);
                int dem = Int32.Parse(ma1) + 1;
                if (dem <= 8)
                {
                    txtMaNXB.Text = "NXB0" + dem;
                }
                else
                {
                    txtMaNXB.Text = "NXB" + dem;
                }
            }
            btnThemNXB.Enabled = false;
            btnSuaNXB.Enabled = false;
            btnLuuNXB.Enabled = true;
            btnXoaNXB.Enabled = true;
            btnBoQuaNXB.Enabled = true;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            XoaSach();
            DataTable dtBang = DocDuLieu.DocBang("select MaSach from tSach order by MaSach desc");
            String ma = dtBang.Rows[0][0].ToString();
            if (ma == "")
            {
                txtMaSach.Text = "S01";
            }
            else
            {
                String ma1 = ma.Substring(1);
                int dem = Int32.Parse(ma1) + 1;
                if (dem <= 8)
                {
                    txtMaSach.Text = "S0" + dem;
                }
                else
                {
                    txtMaSach.Text = "S" + dem;
                }
            }
            btnThemSach.Enabled = false;
            btnSuaSach.Enabled = false;
            btnLuuSach.Enabled = true;
            btnXoaSach.Enabled = true;
            btnBoQuaSach.Enabled = true;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            XoaKhachHang();
            DataTable dtBang = DocDuLieu.DocBang("select MaKH from tKhachHang order by MaKH desc");
            String ma = dtBang.Rows[0][0].ToString();
            if (ma == "")
            {
                txtMaKhachHang.Text = "KH01";
            }
            else
            {
                String ma1 = ma.Substring(2);
                int dem = Int32.Parse(ma1) + 1;
                if (dem <= 8)
                {
                    txtMaKhachHang.Text = "KH0" + dem;
                }
                else
                {
                    txtMaKhachHang.Text = "KH" + dem;
                }
            }
            btnThemKhachHang.Enabled = false;
            btnSuaKhachHang.Enabled = false;
            btnLuuKhachHang.Enabled = true;
            btnXoaKhachHang.Enabled = true;
            btnBoQuaKhachHang.Enabled = true;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
            DataTable dtBang = DocDuLieu.DocBang("select MaNV from tNhanVien order by MaNV desc");
            String ma = dtBang.Rows[0][0].ToString();
            if (ma == "")
            {
                txtMaNhanVien.Text = "NV01";
            }
            else
            {
                String ma1 = ma.Substring(2);
                int dem = Int32.Parse(ma1) + 1;
                if (dem <= 8)
                {
                    txtMaNhanVien.Text = "NV0" + dem;
                }
                else
                {
                    txtMaNhanVien.Text = "NV" + dem;
                }
            }
            btnThemNhanVien.Enabled = false;
            btnSuaNhanVien.Enabled = false;
            btnLuuNhanVien.Enabled = true;
            btnXoaNhanVien.Enabled = true;
            btnBoQuaNhanVien.Enabled = true;
        }
        //Xử lý sự kiện nút sửa
        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Bạn phải điền tên sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
            }
            else
            {
                DocDuLieu.ThucHienLenh("update tTheLoai set TenTheLoai=N'"+txtTenTheLoai.Text+"' where MaTheLoai='"+txtMaTheLoai.Text+"'");
                XoaTheLoai();
                CapNhapTheLoai();
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Bạn phải điền tên nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNCC.Focus();
            }
            else
            {
                DocDuLieu.ThucHienLenh("update tNhaCungCap set TenNCC=N'" + txtTenNCC.Text + "' where MaNCC='" + txtMaNCC.Text + "'");
                XoaNCC();
                CapNhapNhaCungCap();
            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Bạn phải điền tên nhà xuất bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNXB.Focus();
            }
            else
            {
                DocDuLieu.ThucHienLenh("update tNhaXuatBan set TenNXB=N'" + txtTenNXB.Text + "' where MaNCC='" + txtMaNXB.Text + "'");
                XoaNXB();
                CapNhapNhaSanXuat();
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
            {

            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtDiaChiKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChiKhachHang.Focus();
                return;
            }
            if (txtSoDienThoaiKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoaiKhachHang.Focus();
                return;
            }
            DocDuLieu.ThucHienLenh("update tKhachHang set TenKH=N'" + txtTenKhachHang.Text + "',DiaChi=N'" + txtDiaChiKhachHang.Text + "',DienThoai=N'" + txtSoDienThoaiKhachHang.Text.Trim() + "' where MaKH='"+txtMaKhachHang.Text+"'");
            XoaKhachHang();
            CapNhapKhachHang();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChiNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChiNhanVien.Focus();
                return;
            }
            if (txtSoDienThoaiNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoaiNhanVien.Focus();
                return;
            }
            DocDuLieu.ThucHienLenh("update tNhanVien set TenNV=N'" + txtTenNhanVien.Text + "',DiaChi=N'" + txtDiaChiNhanVien.Text + "',DienThoai=N'" + txtSoDienThoaiNhanVien.Text.Trim() + "' where MaNV='" + txtMaNhanVien.Text + "'");
            XoaNhanVien();
            CapNhapNhanVien();
        }
        //Xử lý nút Lưu
        private void btnLuuTheLoai_Click(object sender, EventArgs e)
        {

        }
        


    }
}
