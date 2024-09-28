using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PhieuNhapModule : Form
    {
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        public int MaNhanVien {  get; set; }

        public PhieuNhapModule(int maNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = maNhanVien;
        }

        private void danhSachChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = danhSachChiTietSanPham.Rows[e.RowIndex];
                int maChiTietSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(maChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                txtTienNhap.Text = sanPham.GiaNhap + "";
                txtMaChiTietSanPham.Text = maChiTietSanPham + "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float tongTien = Convert.ToInt32(txtTongTien.Text);
            if(string.IsNullOrWhiteSpace(txtMaChiTietSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(Convert.ToInt32(txtMaChiTietSanPham.Text));
                if (Convert.ToInt32(slNhap.Value) < 0 || Convert.ToInt32(slNhap.Value) == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                }
                else if (comboxDonVi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    float thanhTien = Convert.ToInt32(slNhap.Value) * Convert.ToInt32(txtTienNhap.Text);
                    tongTien += thanhTien;
                    txtTongTien.Text = tongTien + "";
                    danhSachChiTietPhieuNhap.Rows.Add(txtMaChiTietSanPham.Text, mauSacBUS.LayMauSacQuaMa(chiTietSanPham.MaMauSac).TenMauSac, kichCoBUS.LayKichCoQuaMa(chiTietSanPham.MaKichCo).TenKichCo, slNhap.Value, comboxDonVi.Text, txtTienNhap.Text, thanhTien);
                }
            }
            
        }

        private void danhSachChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = danhSachChiTietPhieuNhap.Rows[e.RowIndex];
                int maChiTietSanPham = Convert.ToInt32(row.Cells[0].Value.ToString());
                ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(maChiTietSanPham);
                SanPham sanPham = sanPhamBUS.LaySanPhamQuaMa(chiTietSanPham.MaSanPham);
                slNhap.Value = Convert.ToInt32(row.Cells[3].Value.ToString());
                comboxDonVi.Text = row.Cells[4].Value.ToString();
                txtTienNhap.Text = sanPham.GiaNhap + "";
                txtMaChiTietSanPham.Text = maChiTietSanPham + "";





            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float tongTien = 0;
            for (int i = 0; i < danhSachChiTietPhieuNhap.Rows.Count; i++)
            {
                if (danhSachChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString() == txtMaChiTietSanPham.Text)
                {
                    float thanhTien = Convert.ToInt32(slNhap.Value) * Convert.ToInt32(txtTienNhap.Text);
                    if (Convert.ToInt32(slNhap.Value) == 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0");
                    }
                    else
                    {
                        danhSachChiTietPhieuNhap.Rows[i].Cells[3].Value = Convert.ToInt32(slNhap.Value) + "";
                        danhSachChiTietPhieuNhap.Rows[i].Cells[4].Value = comboxDonVi.Text;
                        danhSachChiTietPhieuNhap.Rows[i].Cells[6].Value = thanhTien;
                    }


                }
            }

            for (int i = 0; i < danhSachChiTietPhieuNhap.Rows.Count; i++)
            {
                tongTien += Convert.ToSingle(danhSachChiTietPhieuNhap.Rows[i].Cells[6].Value);

            }
            txtTongTien.Text = tongTien + "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPhieuNhap.Text) || comboxNhaCungCap.Text == "" || danhSachChiTietPhieuNhap.RowCount == 0) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            } 
            else
            {
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MaNhaCungCap = nhaCungCapBUS.LayNhaCungCapQuaTen(comboxNhaCungCap.Text).MaNhaCungCap;
                phieuNhap.MaNhanVien = this.MaNhanVien;
                phieuNhap.NgayNhap = Convert.ToDateTime(txtNgayNhap.Text);
                phieuNhap.TenPhieuNhap = txtTenPhieuNhap.Text;
                phieuNhap.TongTienNhap = Convert.ToSingle(txtTongTien.Text);
                phieuNhap.TrangThai = 1;
                if(phieuNhapBUS.ThemPhieuNhap(phieuNhap))
                {
                    for(int i = 0; i < danhSachChiTietPhieuNhap.RowCount; i++)
                    {
                        ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                        chiTietPhieuNhap.MaPhieuNhap = Convert.ToInt32(txtMaPhieuNhap.Text);
                        chiTietPhieuNhap.MaChiTietSanPham = Convert.ToInt32(danhSachChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString());
                        chiTietPhieuNhap.SoLuongNhap = Convert.ToInt32(danhSachChiTietPhieuNhap.Rows[i].Cells[3].Value.ToString());
                        chiTietPhieuNhap.DonVi = danhSachChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString();
                        chiTietPhieuNhap.TienNhap = Convert.ToSingle(danhSachChiTietPhieuNhap.Rows[i].Cells[5].Value.ToString());
                        chiTietPhieuNhap.ThanhTien = Convert.ToSingle(danhSachChiTietPhieuNhap.Rows[i].Cells[6].Value.ToString());
                        if(chiTietPhieuNhapBUS.ThemChiTietPhieuNhap(chiTietPhieuNhap))
                        {
                            ChiTietSanPham chiTietSanPham = chiTietSanPhamBUS.LaySanPhamChiTietQuaMa(chiTietPhieuNhap.MaChiTietSanPham);
                            chiTietSanPhamBUS.CapNhatSoLuong(chiTietPhieuNhap.MaChiTietSanPham, chiTietPhieuNhap.SoLuongNhap);
                            sanPhamBUS.capNhatSoLuong(chiTietSanPham.MaSanPham);
                            MessageBox.Show("Thêm thành công");
                        }
                    }

                }
            }
            this.Dispose();
            
        }
    }
}
