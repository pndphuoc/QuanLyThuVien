using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen.GUI
{
    public partial class FormGiaHan : Form
    {
        public FormGiaHan()
        {
            InitializeComponent();
        }
        public FormGiaHan(int MaChiTietMuon, int MaDocGia, ListBox lb)
        {
            InitializeComponent();
            txtMaChiTietMuon.Text = MaChiTietMuon.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
