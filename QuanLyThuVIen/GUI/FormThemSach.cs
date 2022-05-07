using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen.GUI
{
    public partial class FormThemSach : Form
    {
        public FormThemSach()
        {
            InitializeComponent();
            var dataSach = new DataSach();
            var dataNXB = new DataNXB();
            var dataNgonNgu = new DataNgonNgu();
            var dataLoaiSach = new DataLoaiSach();
            var dataTacGia = new DataTacGia();

            var lstNgonNgu = dataNgonNgu.GetListNgonNgu();

            cbNgonNgu.DataSource = lstNgonNgu;
            cbNgonNgu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNgonNgu.DisplayMember = "TenNgonNgu";
            cbNgonNgu.SelectedItem = null;
            cbNgonNgu.Text = "-- Chọn ngôn ngữ --";

            cbNXB.DataSource = dataNXB.GetListNXB();
            cbNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNXB.DisplayMember = "TenNhaXuatBan";
            cbNXB.SelectedItem = null;
            cbNXB.Text = "-- Chọn nhà xuất bản --";

            cbLoaiSach.DataSource = dataLoaiSach.GetListLoaiSach();
            cbLoaiSach.DisplayMember = "TenLoai";
            cbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiSach.SelectedItem = null;
            cbLoaiSach.Text = "-- Chọn loại sách";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            //TODO: up ảnh cho sách
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image files (*.png; *.jpg)|*.png; *.jpg";

            //if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    foreach (string fileName in openFileDialog.FileNames)
            //    {
            //        Process.Start(fileName);
            //    }
            //}
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                        labelPhotoPath.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    //we already define our connection globaly. We are just calling the object of connection.
                    using (var cnn = DbUtils.GetConnection())
                    {
                        //var sql = "insert into Sach (Anh) values(" + filename + ")";
                        SqlCommand cmd = new SqlCommand("insert into Sach (Anh) values(" + filename + ")");
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(openFileDialog.FileName, path + filename);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("Đã tải ảnh lên.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var TenSach = txtBookName.Text.Trim();
            Sach s = new Sach();


            s.TenSach = TenSach;
            s.MaLoaiSach = ((LoaiSach)cbLoaiSach.SelectedItem).MaLoai;
            s.NamXuatBan = Convert.ToInt32(txtNamXB.Text);
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.SoTaiBan = Convert.ToInt32(txtLanTaiBan.Text);
            s.TinhTrang = true;
            s.DonGia = Convert.ToInt32(txtGiaBia.Text.Trim());
            s.MaNgonNgu = ((NgonNgu)cbNgonNgu.SelectedItem).MaNgonNgu;
            s.MaNhaXuatBan = ((NhaXuatBan)cbNXB.SelectedItem).MaNhaXuatBan;

            var dataSach = new DataSach();
            bool result = dataSach.Insert(s);
            if (result == false)
            {
                MessageBox.Show("Thêm sách thất bại.");
            }
            else
            {
                MessageBox.Show("Thêm sách thành công");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormThemSach_Load(object sender, EventArgs e)
        {

        }

        private void EditAuthorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
