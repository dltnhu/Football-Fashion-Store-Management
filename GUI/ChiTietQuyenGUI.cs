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
    public partial class ChiTietQuyenGUI : Form
    {
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        public ChiTietQuyenGUI()
        {
            InitializeComponent();
            LoadDataChiTietQuyen();

        }

        public void LoadDataChiTietQuyen()
        {
            danhSachChiTietQuyen.Rows.Clear();
            foreach (var i in chiTietQuyenBUS.LayDanhSachChiTietQuyen())
            {
                if (chucNangBUS.LayChucNangQuaMa(i.MaChucNang) == null)
                {

                }
                else
                {
                    danhSachChiTietQuyen.Rows.Add(i.MaChiTietQuyen, nhomQuyenBUS.LayNhomQuyenQuaMa(i.MaNhomQuyen).TenNhomQuyen, chucNangBUS.LayChucNangQuaMa(i.MaChucNang).TenChucNang, i.HanhDong);
                }
            }
            danhSachChiTietQuyen.ClearSelection();
        }

        public void LoadDataChiTietQuyen(string text)
        {
            danhSachChiTietQuyen.Rows.Clear();
            foreach (var i in chiTietQuyenBUS.TimKiemChiTietQuyen(text))
            {
                danhSachChiTietQuyen.Rows.Add(i.MaChiTietQuyen, nhomQuyenBUS.LayNhomQuyenQuaMa(i.MaNhomQuyen).TenNhomQuyen, chucNangBUS.LayChucNangQuaMa(i.MaChucNang).TenChucNang, i.HanhDong);
            }
            danhSachChiTietQuyen.ClearSelection();
        }

        private void danhSachChiTietQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = danhSachChiTietQuyen.Rows[e.RowIndex];

            int maChiTietQuyen = Convert.ToInt32(row.Cells[0].Value.ToString());
            ChiTietQuyen chiTietQuyen = chiTietQuyenBUS.LayChiTietQuyenQuaMa(maChiTietQuyen);

            string selectedColumnName = danhSachChiTietQuyen.Columns[e.ColumnIndex].Name;

            if (selectedColumnName == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (chiTietQuyenBUS.XoaChiTietQuyen(maChiTietQuyen))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        LoadDataChiTietQuyen();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            else if (selectedColumnName == "Sua")
            {
                ChiTietQuyenModule chiTietQuyenModule = new ChiTietQuyenModule(maChiTietQuyen);
                chiTietQuyenModule.comboBoxNhomQuyen.DataSource = nhomQuyenBUS.LayDanhSachTenNhomQuyen();
                chiTietQuyenModule.comboBoxChucNang.DataSource = chucNangBUS.LayDanhSachTenChucNang();
                chiTietQuyenModule.comboBoxNhomQuyen.Text = row.Cells[1].Value.ToString();
                chiTietQuyenModule.comboBoxChucNang.Text = row.Cells[2].Value.ToString();
                chiTietQuyenModule.comboBoxHanhDong.Text = row.Cells[3].Value.ToString();
                ShowDialogSua(chiTietQuyenModule);
                chiTietQuyenModule.ShowDialog();
                LoadDataChiTietQuyen();
            }
            else if (selectedColumnName == "ChiTiet")
            {
                ChiTietQuyenModule chiTietQuyenModule = new ChiTietQuyenModule(maChiTietQuyen);
                chiTietQuyenModule.comboBoxNhomQuyen.Text = row.Cells[1].Value.ToString();
                chiTietQuyenModule.comboBoxChucNang.Text = row.Cells[2].Value.ToString();
                chiTietQuyenModule.comboBoxHanhDong.Text = row.Cells[3].Value.ToString();
                ShowDialogChiTiet(chiTietQuyenModule);
                chiTietQuyenModule.ShowDialog();
            }
        }


        // hàm hiển thị dialog chi tiết
        public void ShowDialogChiTiet(ChiTietQuyenModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = false;
            module.btnThoat.Size = new Size(320, 51);


        }

        // hàm hiển thị dialog thêm
        public void ShowDialogThem(ChiTietQuyenModule module)
        {
            module.btnThem.Visible = true;
            module.btnSua.Visible = false;
            module.comboBoxNhomQuyen.DataSource = nhomQuyenBUS.LayDanhSachTenNhomQuyen();
            module.comboBoxChucNang.DataSource = chucNangBUS.LayDanhSachTenChucNang();
        }
        // hàm hiển thị dialog sửa
        public void ShowDialogSua(ChiTietQuyenModule module)
        {
            module.btnThem.Visible = false;
            module.btnSua.Visible = true;


        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ChiTietQuyenModule chiTietQuyenModule = new ChiTietQuyenModule();
            chiTietQuyenModule.btnSua.Visible = false;
            ShowDialogThem(chiTietQuyenModule);
            chiTietQuyenModule.ShowDialog();
            LoadDataChiTietQuyen();


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string text = txtTimKiem.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                LoadDataChiTietQuyen();
            }
            else
            {
                LoadDataChiTietQuyen(text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
