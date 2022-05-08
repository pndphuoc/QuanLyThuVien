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
    public partial class MuonTraForm : Form
    {
        public MuonTraForm()
        {
            InitializeComponent();
            DataDocGia_MuonSach dataDGMS = new DataDocGia_MuonSach();

            var lstDGMS = dataDGMS.GetListDocGiaMuonSach();

            bsMuonSach.DataSource = lstDGMS;
            gridMuon.DataSource = bsMuonSach;
            gridMuon.AutoGenerateColumns = false;


        }

        private void MuonTraForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridMuon.Rows[e.RowIndex];
                DataDocGia dtDocGia = new DataDocGia();
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                DataSach dtSach = new DataSach();


                var MaDocGia = Convert.ToInt32(row.Cells[0].Value.ToString());
                var DocGia = (DocGia)dtDocGia.GetDocGia((int)MaDocGia);
                

                txtTenDocGia.Text = DocGia.TenDocGia;
                txtChucDanh.Text = DocGia.MaChucDanh.ToString();
                txtEmail.Text = DocGia.Email;
                txtDienThoai.Text = DocGia.SoDienThoai;
                DataChucDanh dataChucDanh = new DataChucDanh();
                txtChucDanh.Text = dataChucDanh.GetChucDanh(Convert.ToInt32(DocGia.MaChucDanh)).TenChucDanh;
                txtMaPhieuMuon.Text = row.Cells["MaChiTietMuon"].Value.ToString();


                txtHanTra.Text = dtCTM.GetChiTietMuon(Convert.ToInt32(txtMaPhieuMuon.Text)).HanTra.ToString("dd/MM/yyyy");
                txtNgayMuon.Text = dtCTM.GetChiTietMuon(Convert.ToInt32(txtMaPhieuMuon.Text)).NgayMuon.ToString("dd/MM/yyyy");
                
                var lstSach = dtSach.GetListSach(Convert.ToInt32(txtMaPhieuMuon.Text));
                lbDangMuon.DataSource = lstSach;
                lbDangMuon.DisplayMember = "TenSach";
                labelCount.Text = lstSach.Count().ToString();
            }
        }
    }
}
