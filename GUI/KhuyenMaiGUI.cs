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
    public partial class KhuyenMaiGUI : Form
    {
        KhuyenMaiBUS khuyenMaiBUS = new KhuyenMaiBUS();
        public KhuyenMaiGUI()
        {
            InitializeComponent();
            LoadDataKhuyenMai();
        }


        public void LoadDataKhuyenMai()
        {
            danhSachKhuyenMai.RowCount = 0;
            foreach (var item in khuyenMaiBUS.LayToanBoKhuyenMai())
            {
                danhSachKhuyenMai.Rows.Add(item.MaKhuyenMai, item.MucKhuyenMai, item.DieuKien, item.ThoiGianBatDau, item.ThoiGianKetThuc);

            }
            
        }

        public void LoadDataKhuyenMai(string text)
        {
            danhSachKhuyenMai.RowCount = 0;
            foreach (var item in khuyenMaiBUS.TimKiemKhuyenMai(text))
            {
                danhSachKhuyenMai.Rows.Add(item.MaKhuyenMai, item.MucKhuyenMai, item.DieuKien, item.ThoiGianBatDau, item.ThoiGianKetThuc);

            }

        }

        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(KhuyenMaiModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);
        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(KhuyenMaiModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;

        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(KhuyenMaiModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;

        }



        private void danhSachKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = danhSachKhuyenMai.Rows[e.RowIndex];

            int maKhuyenMai = Convert.ToInt32(row.Cells[0].Value.ToString());
            KhuyenMai khuyenMai = khuyenMaiBUS.LayKhuyenMaiQuaMa(maKhuyenMai);


            string selectedColumnName = danhSachKhuyenMai.Columns[e.ColumnIndex].Name;

            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (khuyenMaiBUS.XoaKhuyenMai(khuyenMai))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataKhuyenMai();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                KhuyenMaiModule khuyenMaiModule = new KhuyenMaiModule(maKhuyenMai);
                khuyenMaiModule.txtMucKhuyenMai.Text = khuyenMai.MucKhuyenMai + "";
                khuyenMaiModule.txtDieuKien.Text = khuyenMai.DieuKien;
                khuyenMaiModule.dateBatDau.Value = khuyenMai.ThoiGianBatDau;
                khuyenMaiModule.dateKetThuc.Value = khuyenMai.ThoiGianKetThuc;
                ShowDialogSua(khuyenMaiModule);
                khuyenMaiModule.ShowDialog();
                LoadDataKhuyenMai();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                KhuyenMaiModule khuyenMaiModule = new KhuyenMaiModule(maKhuyenMai);
                khuyenMaiModule.txtMucKhuyenMai.Text = khuyenMai.MucKhuyenMai + "";
                khuyenMaiModule.txtDieuKien.Text = khuyenMai.DieuKien;
                khuyenMaiModule.dateBatDau.Value = khuyenMai.ThoiGianBatDau;
                khuyenMaiModule.dateKetThuc.Value = khuyenMai.ThoiGianKetThuc;
                ShowDialogChiTiet(khuyenMaiModule);
                khuyenMaiModule.ShowDialog();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            KhuyenMaiModule khuyenMaiModule = new KhuyenMaiModule();
            ShowDialogThem(khuyenMaiModule);
            khuyenMaiModule.ShowDialog();
            LoadDataKhuyenMai();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataKhuyenMai();
            } 
            else
            {
                LoadDataKhuyenMai(txtTimKiem.Text);
            }
        }
    }
}
