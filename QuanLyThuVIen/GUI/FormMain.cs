using QuanLyThuVIen.Data;
using QuanLyThuVIen.GUI;
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

namespace QuanLyThuVIen
{
    public partial class FormMain : Form
    {
        int MaSachGlobal { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }
       
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Size = this.mainPanel.Size;
            f.Show();
        }

        private void btnBookManager_Click(object sender, EventArgs e)
        {
            loadForm(new BookManagerForm());
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            loadForm(new MuonTraForm());
        }



        //private void gridSach_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    SachResponse currentObject = (SachResponse)gridSach.CurrentRow.DataBoundItem;
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        var dataSach = new DataSach();
        //        var dataNXB = new DataNXB();
        //        var dataNgonNgu = new DataNgonNgu();
        //        var dataLoaiSach = new DataLoaiSach();
        //        var dataTacGia = new DataTacGia();

        //        var lstNgonNgu = dataNgonNgu.GetListNgonNgu();

        //        DataGridViewRow row = gridSach.Rows[e.RowIndex];
        //        MaSachGlobal = Convert.ToInt32(row.Cells["colMaSach"].Value);

        //        btnDelete.Enabled = true;
        //        txtBookName.Enabled = true;
        //        txtGiaBia.Enabled = true;
        //        txtLanTaiBan.Enabled = true;
        //        txtSoLuong.Enabled = true;
        //        cbNXB.Enabled = true;
        //        cbNgonNgu.Enabled = true;
        //        lbTacGia.Enabled = true;
        //        cbLoaiSach.Enabled = true;

        //        Sach currentSach = dataSach.GetSach(Convert.ToInt32(row.Cells[0].Value));
        //        txtBookName.Text = currentSach.TenSach;

        //        EditAuthorButton.Enabled = true;

        //        if (currentSach.Anh != null)
        //        {
        //            BookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        //            BookPicture.Image = Image.FromFile(currentSach.Anh);
        //        }
        //        else
        //            BookPicture.Image = null;

        //        cbNgonNgu.DataSource = lstNgonNgu;
        //        cbNgonNgu.DisplayMember = "TenNgonNgu";
        //        cbNgonNgu.Text = dataNgonNgu.GetNgonNgu(currentSach.MaNgonNgu).TenNgonNgu;
        //        cbNgonNgu.SelectedItem = dataNgonNgu.GetNgonNgu(currentSach.MaNgonNgu);

        //        cbNXB.DataSource = dataNXB.GetListNXB();
        //        cbNXB.DisplayMember = "TenNgonNgu";
        //        cbNXB.Text = dataNXB.GetNXB(currentSach.MaNhaXuatBan).TenNhaXuatBan;
        //        cbNXB.SelectedItem = dataNXB.GetNXB(currentSach.MaNhaXuatBan).TenNhaXuatBan;

        //        List<TacGia> lstTacGia = dataTacGia.GetListTacGia(Convert.ToInt32(row.Cells[0].Value));
        //        lbTacGia.DataSource = lstTacGia;
        //        lbTacGia.DisplayMember = "TenTacGia";
        //        lbTacGia.Text = "-- Danh sách tác giả --";
        //        lbTacGia.SelectedItem = null;

        //        cbLoaiSach.DataSource = dataLoaiSach.GetListLoaiSach();
        //        cbLoaiSach.DisplayMember = "TenLoai";
        //        cbLoaiSach.SelectedItem = currentSach.MaLoaiSach;

        //        txtGiaBia.Text = currentSach.DonGia.ToString();
        //        txtLanTaiBan.Text = currentSach.SoTaiBan.ToString();
        //        txtSoLuong.Text = currentSach.SoLuong.ToString();
        //    }
        //}


        //private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (TabControl.SelectedIndex)
        //    {
        //        case 0:
        //            break;
        //        case 1:
        //            int currentTab = TabControl.SelectedIndex;
        //            string tabText = TabControl.TabPages[currentTab].Text;
        //            btnRefresh.Show();
        //            btnRefresh.PerformClick();
        //            btnRefresh.Hide();
        //            break;
        //    }
        //}

        //private void cbTacGia_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = true;
        //}





        //private void EditAuthorButton_Click(object sender, EventArgs e)
        //{
        //    var lst = (IEnumerable<TacGia>)lbTacGia.DataSource;
        //    var frm = new EditTacGia(ref lst);
        //    frm.StartPosition = FormStartPosition.CenterParent;

        //    frm.Show();
        //}


        //private void btnThemSach_Click(object sender, EventArgs e)
        //{
        //    var frm = new FormThemSach();
        //    frm.StartPosition = FormStartPosition.CenterParent;
        //    frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
        //    frm.Show();
        //}
        //private void ChildFormClosing(object sender, FormClosingEventArgs e)
        //{
        //    btnRefresh.Show();
        //    btnRefresh.PerformClick();
        //    btnRefresh.Hide();
        //}

        //private void refresh_Click(object sender, EventArgs e)
        //{
        //    var dataSach = new DataSach();
        //    var dataNXB = new DataNXB();
        //    var dataNgonNgu = new DataNgonNgu();
        //    var dataLoaiSach = new DataLoaiSach();
        //    var dataTacGia = new DataTacGia();

        //    var lstNXB = dataNXB.GetListNXB();
        //    var lstSach = dataSach.GetListSachResponse();

        //    txtBookName.Enabled = false;
        //    txtGiaBia.Enabled = false;
        //    txtLanTaiBan.Enabled = false;
        //    txtSoLuong.Enabled = false;
        //    btnDelete.Enabled = false;

        //    cbLoaiSach.Text = "-- Chọn thể loại --";
        //    cbLoaiSach.Enabled = false;

        //    cbNgonNgu.Enabled = false;

        //    lbTacGia.Text = "-- Chọn tác giả --";
        //    lbTacGia.Enabled = false;
        //    EditAuthorButton.Enabled = false;

        //    cbNXB.Text = "-- Chọn nhà xuất bản --";
        //    cbNXB.Enabled = false;

        //    bsSach.DataSource = lstSach;
        //    bsNXB.DataSource = lstNXB;

        //    gridSach.DataSource = bsSach;

        //    gridSach.AutoGenerateColumns = false;
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    var frm = new FormXacNhanXoa();
        //    frm.StartPosition = FormStartPosition.CenterParent;

        //    if (frm.ShowDialog() == DialogResult.OK)
        //    {
        //        var dataSach = new DataSach();
        //        bool result = dataSach.Delete(MaSachGlobal);
        //    }
        //    btnRefresh.Show();
        //    btnRefresh.PerformClick();
        //    btnRefresh.Hide();
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    var TenSach = txtBookName.Text.Trim();
        //    var LoaiSach = ((LoaiSach)cbLoaiSach.SelectedItem).MaLoai;
        //    var NgonNgu = ((NgonNgu)cbNgonNgu.SelectedItem).MaNgonNgu;
        //    var GiaBia = txtGiaBia.Text.Trim();
        //    var NXB = ((NhaXuatBan)cbNXB.SelectedItem).MaNhaXuatBan;
        //    var SoLuong = txtSoLuong.Text.Trim();
        //    var LanTaiBan = txtLanTaiBan.Text.Trim();

        //}
    }
}
