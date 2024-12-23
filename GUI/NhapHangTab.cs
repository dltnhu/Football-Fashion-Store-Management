﻿using System;
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
    public partial class NhapHangTab : Form
    {
        Form activeForm = null;

        public NhapHangTab(PhieuNhapGUI phieuNhapGUI, ChiTietPhieuNhapGUI chiTietPhieuNhapGUI)
        {
            InitializeComponent();

            OpenForm(phieuNhapGUI, pagePhieuNhap);

            OpenForm(chiTietPhieuNhapGUI, pageChiTietPhieuNhap);

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
