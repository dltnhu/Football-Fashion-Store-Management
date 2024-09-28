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
    public partial class ChatLieuModule : Form
    {
        ChatLieuBUS chatLieuBUS = new ChatLieuBUS();
        public int MaChatLieu { get; set; }
        public ChatLieuModule()
        {
            InitializeComponent();
        }
        public ChatLieuModule(int maChatLieu)
        {
            InitializeComponent();
            this.MaChatLieu = maChatLieu;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChatLieu chatLieu = new ChatLieu();
            chatLieu.TenChatLieu = txtTenChatLieu.Text;
            chatLieu.TrangThai = 1;

            if (string.IsNullOrWhiteSpace(txtTenChatLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (chatLieuBUS.ThemChatLieu(chatLieu))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChatLieu chatLieu = new ChatLieu();
            chatLieu.MaChatLieu = this.MaChatLieu;
            chatLieu.TenChatLieu = txtTenChatLieu.Text;
            chatLieu.TrangThai = 1;
            if (string.IsNullOrWhiteSpace(txtTenChatLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (chatLieuBUS.SuaChatLieu(chatLieu))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
    }
}
