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
    public partial class ChiTietSanPhamModule : Form
    {
        public int MaChiTietSanPham { get; set; }
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();

        public ChiTietSanPhamModule()
        {
            InitializeComponent();
        }
        public ChiTietSanPhamModule(int maChiTietSanPham)
        {
            InitializeComponent();
            this.MaChiTietSanPham = maChiTietSanPham;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
            chiTietSanPham.MaChiTietSanPham = this.MaChiTietSanPham;
            chiTietSanPham.MaMauSac = mauSacBUS.LayMauSacQuaTen(comboxMauSac.Text).MaMauSac;
            chiTietSanPham.MaKichCo = kichCoBUS.LayKichCoQuaTen(comboxKichCo.Text).MaKichCo;

            Image hinhAnh = anhSanPham.Image;
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, hinhAnh.RawFormat);
                chiTietSanPham.HinhAnh = ms.ToArray();
            }
            if (chiTietSanPhamBUS.SuaChiTietSanPham(chiTietSanPham))
            {
                MessageBox.Show("Sửa thành công");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void anhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                anhSanPham.ImageLocation = dialog.FileName.ToString();
            }
        }
    }
}
