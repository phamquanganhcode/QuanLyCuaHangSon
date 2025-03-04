using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeGiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }
     
        private void LoadFormIntoPanel(Form frm)
        {
            frm.TopLevel = false;
            pnlChinh.Controls.Clear();
            pnlChinh.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        FormHangHoa childHangHoa = new FormHangHoa();
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(childHangHoa);
        }

        FormDoiTac childDoiTac = new FormDoiTac();
        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(childDoiTac);
        }

        FormHoaDon childHoaDon = new FormHoaDon();
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(childHoaDon);
        }

        FormThongKe childThongKe = new FormThongKe();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(childThongKe);
        }
        
        FormBangGia childBangGia = new FormBangGia();
        private void btnBangGia_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(childBangGia);
        }

        FormTaiKhoan childTaiKhoan = new FormTaiKhoan();
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(childTaiKhoan);
        }

    }
}