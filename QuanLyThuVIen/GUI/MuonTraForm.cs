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
        private List<int> listMaSach;
        private int MaDocGiaGlobal;
        public MuonTraForm()
        {
            InitializeComponent();
            DataDocGia_MuonSach dataDGMS = new DataDocGia_MuonSach();
            ///Lấy danh sách các độc giả đang mượn cách
            var lstDGMS = dataDGMS.GetListDocGiaMuonSach();

            //Gán dữ liệu cho GridDataView
            bsMuonSach.DataSource = lstDGMS;
            gridMuon.DataSource = bsMuonSach;
            gridMuon.AutoGenerateColumns = false;


        }

        private void Reload()
        {
            DataDocGia_MuonSach dataDGMS = new DataDocGia_MuonSach();
            var lstDGMS = dataDGMS.GetListDocGiaMuonSach();

            //Gán dữ liệu cho GridDataView
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
        /// <summary>
        /// Xử lý khi chọn đối tượng trong GridDataView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnTraSach.Enabled = true;
                DataGridViewRow row = gridMuon.Rows[e.RowIndex];
                DataDocGia dtDocGia = new DataDocGia();
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                DataSach dtSach = new DataSach();

                MaDocGiaGlobal = Convert.ToInt32(row.Cells[0].Value.ToString());
                var MaDocGia = Convert.ToInt32(row.Cells[0].Value.ToString());
                var DocGia = (DocGia)dtDocGia.GetDocGia((int)MaDocGia);

                //Hiển thị thông tin độc giả
                txtTenDocGia.Text = DocGia.TenDocGia;
                txtChucDanh.Text = DocGia.MaChucDanh.ToString();
                txtEmail.Text = DocGia.Email;
                txtDienThoai.Text = DocGia.SoDienThoai;
                DataChucDanh dataChucDanh = new DataChucDanh();
                txtChucDanh.Text = dataChucDanh.GetChucDanh(Convert.ToInt32(DocGia.MaChucDanh)).TenChucDanh;
                txtMaPhieuMuon.Text = row.Cells["MaChiTietMuon"].Value.ToString();

                //Xử lý DateTime
                ChiTietMuon ctm = new ChiTietMuon();
                ctm = dtCTM.GetChiTietMuon(Convert.ToInt32(txtMaPhieuMuon.Text));
                txtHanTra.Text = ctm.HanTra.ToString("dd/MM/yyyy");
                txtNgayMuon.Text = ctm.NgayMuon.ToString("dd/MM/yyyy");
                if (DateTime.Now.Date > ctm.HanTra)
                {
                    labelQuaHan.Visible = true;
                }
                else
                {
                    labelQuaHan.Visible = false;
                }

                //Lấy danh sách sách mượn của độc giả
                var lstSach = dtSach.GetListSach(Convert.ToInt32(txtMaPhieuMuon.Text));
                lbDangMuon.DataSource = lstSach;
                lbDangMuon.DisplayMember = "TenSach";
                labelCount.Text = lstSach.Count().ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataDocGia_MuonSach dtDocGiaMuonSach = new DataDocGia_MuonSach();
            var s = dtDocGiaMuonSach.Search(txtSearch.Text);
            if (s.Count == 0)
                bsMuonSach.DataSource = null;
            else
            {
                bsMuonSach.DataSource = dtDocGiaMuonSach.Search(txtSearch.Text);
                gridMuon.DataSource = bsMuonSach;
            }
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
                bsMuonSach.DataSource = dtDocGiaMuonSach.GetListDocGiaMuonSach();
                gridMuon.DataSource = bsMuonSach;
            }
        }

        private void btnDongY_MUON_Click(object sender, EventArgs e)
        {
            ChiTietMuon ctm = new ChiTietMuon();
            if (string.IsNullOrWhiteSpace(txtMaDocGia_MUON.Text)|| string.IsNullOrWhiteSpace(txtTenDocGia_Muon.Text) || listMaSach == null)
                lbNotify.Visible = true;
            else
            {
                ctm.SoLuongMuon = Convert.ToInt32(labelSoLuongSachChon.Text);
                ctm.MaDocGia = Convert.ToInt32(txtMaDocGia_MUON.Text);
                ctm.NgayMuon = dtNgayMuon.Value;
                ctm.HanTra = dtNgayTra.Value;
                ctm.TrangThai = false;
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                if (dtCTM.GetSoLuongDangMuon(ctm.MaDocGia) + Convert.ToInt32(labelSoLuongSachChon.Text) > 5)
                {
                    MessageBox.Show("Mỗi độc giả chỉ được mượn tối đa 5 quyển sách 1 lúc");
                }
                else
                {
                    int MaChiTietMuon = dtCTM.InsertChiTietMuon(ctm);
                    dtCTM.InsertSach_ChiTietMuon(MaChiTietMuon, listMaSach);
                    MessageBox.Show("Thêm thành công!");
                    txtMaDocGia_MUON.Text = null;
                    dtNgayMuon.Value = DateTime.Now.Date;
                    dtNgayMuon.Value = DateTime.Now.Date;
                    txtNhanVien_MUON.Text = null;
                    lbChonSach.DataSource = null;
                    Reload();
                }
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

        void LoadData(List<int> lstMaSach)
        {
            DataSach dtSach = new DataSach();
            List<Sach> listSach = new List<Sach>();
            foreach (int i in lstMaSach)
            {
                listSach.Add(dtSach.GetSach(i));
            }
            lbChonSach.DataSource = listSach;
            lbChonSach.DisplayMember = "TenSach";
            labelSoLuongSachChon.Text = lbChonSach.Items.Count.ToString();

            ///Gán danh sách mã sách được nhập từ form Thêm sách vào biến toàn cục listSach
            listMaSach = lstMaSach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lstSach = new List<Sach>();
            foreach (var item in lbChonSach.Items)
            {
                lstSach.Add((Sach)item);
            }
            var lstMaSach = new List<int>();
            foreach (var item in lstSach)
            {
                lstMaSach.Add((int)item.MaSach);
            }
            if (lstMaSach.Count > 0)
            {
                ChonSachForm f = new ChonSachForm(lstMaSach);
                f.truyenData = new ChonSachForm.TruyenChoMuonTraForm(LoadData);
                f.ShowDialog();
            }
            else
            {
                ChonSachForm f = new ChonSachForm();
                f.truyenData = new ChonSachForm.TruyenChoMuonTraForm(LoadData);
                f.ShowDialog();
            }


        }

        private void  btnTraSach_Click(object sender, EventArgs e)
        {
            if (gridMuon.SelectedRows != null)
            {
                if (!string.IsNullOrWhiteSpace(txtMaPhieuMuon.Text))
                {
                    FormTraSach f = new FormTraSach(Convert.ToInt32(txtMaPhieuMuon.Text));
                    DialogResult dr = f.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        Reload();
                        txtTenDocGia.Text = null;
                        txtChucDanh.Text = null;
                        txtEmail.Text = null;
                        txtDienThoai.Text = null;
                        DataChucDanh dataChucDanh = new DataChucDanh();
                        txtChucDanh.Text = null;
                        txtMaPhieuMuon.Text = null;
                        txtNgayMuon.Text = null;
                        txtHanTra.Text = null;
                        lbDangMuon.DataSource = null;
                    }
                }

            }

        }

        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            FormGiaHan f = new FormGiaHan(Convert.ToInt32(txtMaPhieuMuon.Text), MaDocGiaGlobal, lbDangMuon);
            f.ShowDialog();
        }
    }
}
