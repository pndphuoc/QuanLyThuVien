﻿using QuanLyThuVIen.Data;
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
    public partial class UserDocGia : Form
    {
        private int MaDocGia;
        public UserDocGia()
        {
            InitializeComponent();
            var dociga = new DataDocGia();
            var lstDG = dociga.GetListDocGia();
            bsDocGia.DataSource = lstDG;
            GridDocGia.DataSource = bsDocGia;

            //Nạp khoa vào combobox
            var dataKhoa = new DataKhoa();
            cbbKhoa.DataSource = dataKhoa.GetListKhoa();
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.SelectedItem = null;
            cbbKhoa.Text = "-- Khoa --";
            

            //Nap chức danh vào combobox
            var dataCD = new DataChucDanh();
            cbbNamSinh.DataSource = dataCD.GetListChucDanh();
            cbbNamSinh.DisplayMember = "TenChucDanh";
            cbbNamSinh.SelectedItem = null;
            cbbNamSinh.Text = "-- Chức danh --";

            //Nạp trạng thái vào combobox
            var dataTT = new DataTrangThai();
            cbbTrangThai.DataSource = dataTT.GetListTrangThai();
            cbbTrangThai.DisplayMember = "TenTrangThai";
            cbbTrangThai.SelectedItem = null;

            if (GridDocGia == null)
            {
                bttChiTiet.Enabled = false;
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            var dociga = new DataDocGia();
            var lstDG = new List<DocGia>();
            if (cbbTrangThai.SelectedItem != null)
            {
                var MaTrangThai = ((TrangThai)cbbTrangThai.SelectedItem).MaTrangThai;
                lstDG = dociga.GetListDocGia2(MaTrangThai);
                bsDocGia.DataSource = lstDG;
                GridDocGia.DataSource = bsDocGia;

            }
            else
            {
                var dociga1 = new DataDocGia();
                var lstDG1 = dociga1.GetListDocGia();
                bsDocGia.DataSource = lstDG1;
                GridDocGia.DataSource = bsDocGia;
            }

        }

        private void cbbNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            var dociga = new DataDocGia();
            var lstDG = new List<DocGia>();
            if (cbbNamSinh.SelectedItem != null)
            {
                var MaChucDanh = ((ChucDanh)cbbNamSinh.SelectedItem).MaChucDanh;
                lstDG = dociga.GetListDocGia2(MaChucDanh);
                bsDocGia.DataSource = lstDG;
                GridDocGia.DataSource = bsDocGia;

            }
            else
            {
                var dociga1 = new DataDocGia();
                var lstDG1 = dociga1.GetListDocGia();
                bsDocGia.DataSource = lstDG1;
                GridDocGia.DataSource = bsDocGia;
            }

        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            var dociga = new DataDocGia();
            var lstDG = new List<DocGia>();
            if (cbbKhoa.SelectedItem != null)
            {
                var MaKhoa = ((Khoa)cbbKhoa.SelectedItem).MaKhoa;
                lstDG = dociga.GetListDocGia1(MaKhoa);
                bsDocGia.DataSource = lstDG;
                GridDocGia.DataSource = bsDocGia;

            }
            else
            {
                var dociga1 = new DataDocGia();
                var lstDG1 = dociga1.GetListDocGia();
                bsDocGia.DataSource = lstDG1;
                GridDocGia.DataSource = bsDocGia;
            }
        }

        private void GridDocGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = GridDocGia.Rows[e.RowIndex];
                MaDocGia = Convert.ToInt32(row.Cells["colMaDocGia"].Value);
            }    

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MaDocGia >0) {
            var frm = new UserXemThongTin(MaDocGia);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
            }


        }

        


    }
}
