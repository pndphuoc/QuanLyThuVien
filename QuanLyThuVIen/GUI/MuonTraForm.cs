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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataDocGia_MuonSach dtDocGiaMuonSach = new DataDocGia_MuonSach();
            bsMuonSach.DataSource = dtDocGiaMuonSach.Search(txtSearch.Text);
            gridMuon.DataSource = bsMuonSach;
        }

        private void cbQuaHan_CheckedChanged(object sender, EventArgs e)
        {
            DataDocGia_MuonSach dtDocGiaMuonSach = new DataDocGia_MuonSach();
            if (cbQuaHan.Checked)
            {
                bsMuonSach.DataSource = dtDocGiaMuonSach.GetListQuaHan();
                gridMuon.DataSource = bsMuonSach;
            }
            else
            {
                bsMuonSach.DataSource = dtDocGiaMuonSach.Search(txtSearch.Text);
                gridMuon.DataSource = bsMuonSach;
            }
        }

        private void btnDongY_MUON_Click(object sender, EventArgs e)
        {
            ChiTietMuon ctm = new ChiTietMuon();
            if (txtMaDocGia_MUON.Text == null || txtTenDocGia_Muon == null || dtNgayTra.Value > dtNgayMuon.Value || clbChonSach.Items.Count == 0)
                lbNotify.Visible = true;
            else
            {
                ctm.MaDocGia = Convert.ToInt32(txtMaDocGia_MUON.Text);
                ctm.NgayMuon = dtNgayMuon.Value;
                ctm.HanTra = dtNgayTra.Value;
                ctm.SoLuongMuon = clbChonSach.Items.Count;
                ctm.TrangThai = false;
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                bool result = dtCTM.InsertChiTietMuon(ctm);
                if (result)
                {
                    MessageBox.Show("Thêm thành công!");

                }
                else
                    MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại");
            }
        }

        private void txtMaDocGia_MUON_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDocGia_MUON.Text))
                txtTenDocGia_Muon.Text = null;

            DataDocGia dtDocGia = new DataDocGia();
            int max = dtDocGia.MaxOfMaDocGia();
            if (!String.IsNullOrWhiteSpace(txtMaDocGia_MUON.Text) && Convert.ToInt32(txtMaDocGia_MUON.Text) <= max)
            {
                DocGia docGia = new DocGia();
                docGia = dtDocGia.GetDocGia(Convert.ToInt32(txtMaDocGia_MUON.Text));
                if (docGia != null)
                    txtTenDocGia_Muon.Text = docGia.TenDocGia;
            }

        }
    }
}
