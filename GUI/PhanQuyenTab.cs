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
    public partial class PhanQuyenTab : Form
    {
        Form activeForm = null;


        public PhanQuyenTab(NhomQuyenGUI nhomQuyenGUI, ChucNangGUI chucNangGUI, ChiTietQuyenGUI chiTietQuyenGUI)
        {
            InitializeComponent();
            OpenForm(nhomQuyenGUI, pageNhomQuyen);
            OpenForm(chucNangGUI, pageChucNang);
            OpenForm(chiTietQuyenGUI, pageChiTietQuyen);
        }
        public void OpenForm(Form form, TabPage pageContainer)
        {

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pageContainer.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
    }
}
