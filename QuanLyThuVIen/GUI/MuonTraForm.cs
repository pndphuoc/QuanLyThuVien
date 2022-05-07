using QuanLyThuVIen.Data;
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
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = gridMuon.Rows[e.RowIndex];
                txtMaPhieuMuon.Text = Convert.ToString(row.Cells["MaChiTietMuon"].Value);
            }
        }
    }
}
