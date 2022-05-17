using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
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
    public partial class UserXemThongTin : Form
    {
        private int MaDocGia;
        public UserXemThongTin()
        {
            InitializeComponent();
        }
        public UserXemThongTin(int MaDocGia)
        {
            InitializeComponent();
            this.MaDocGia = MaDocGia;
            var DataDG = new DataDocGia();
            DocGia DG = DataDG.GetDocGia(this.MaDocGia);
            textBox1.Text = DG.MaDocGia.ToString();
            textBox2.Text = DG.TenDocGia;
            textBox3.Text = DG.NgaySinh.ToString();
            textBox4.Text = DG.Email;
            textBox5.Text = DG.DiaChi;
            textBox6.Text = DG.SoDienThoai;
            textBox7.Text = DG.NgayDangKy.ToString();
            textBox8.Text = DG.NgayHetHan.ToString();
            textBox9.Text = DG.Lop;
            textBox10.Text = DG.MaKhoa.ToString();
            textBox11.Text = DG.GioiTinh.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttMuonTra_Click(object sender, EventArgs e)
        {
            var frm = new UserLichSuMuonTra(MaDocGia);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
 }

