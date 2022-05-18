
namespace QuanLyThuVIen.GUI
{
    partial class UserDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbNamSinh = new System.Windows.Forms.ComboBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.GridDocGia = new System.Windows.Forms.DataGridView();
            this.colTenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChucDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttChiTiet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bsDocGia = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐỘC GIẢ";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(17, 37);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(87, 21);
            this.cbbGioiTinh.TabIndex = 1;
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Còn hạn",
            "Hết hạn",
            "Khóa"});
            this.cbbTrangThai.Location = new System.Drawing.Point(119, 37);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(87, 21);
            this.cbbTrangThai.TabIndex = 1;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "--Chọn Khoa--"});
            this.cbbKhoa.Location = new System.Drawing.Point(223, 37);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(87, 21);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // cbbNamSinh
            // 
            this.cbbNamSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNamSinh.FormattingEnabled = true;
            this.cbbNamSinh.Location = new System.Drawing.Point(328, 37);
            this.cbbNamSinh.Name = "cbbNamSinh";
            this.cbbNamSinh.Size = new System.Drawing.Size(87, 21);
            this.cbbNamSinh.TabIndex = 1;
            this.cbbNamSinh.SelectedIndexChanged += new System.EventHandler(this.cbbNamSinh_SelectedIndexChanged);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTimKiem.Location = new System.Drawing.Point(525, 38);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(262, 20);
            this.tbTimKiem.TabIndex = 2;
            this.tbTimKiem.Text = "search..";
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // GridDocGia
            // 
            this.GridDocGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenDocGia,
            this.colTrangThai,
            this.colNgaySinh,
            this.colSDT,
            this.colGioiTinh,
            this.colMaDocGia,
            this.colMaChucDanh,
            this.colEmail,
            this.colDiaChi,
            this.colNgayDangKy,
            this.colNgayHetHan,
            this.colLop,
            this.colMaKhoa,
            this.colKhoaHoc,
            this.colUserName,
            this.colPassword});
            this.GridDocGia.GridColor = System.Drawing.SystemColors.Control;
            this.GridDocGia.Location = new System.Drawing.Point(17, 65);
            this.GridDocGia.Name = "GridDocGia";
            this.GridDocGia.Size = new System.Drawing.Size(770, 280);
            this.GridDocGia.TabIndex = 4;
            this.GridDocGia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridDocGia_CellMouseClick);
            // 
            // colTenDocGia
            // 
            this.colTenDocGia.DataPropertyName = "TenDocGia";
            this.colTenDocGia.HeaderText = "Tên độc giả";
            this.colTenDocGia.MinimumWidth = 150;
            this.colTenDocGia.Name = "colTenDocGia";
            this.colTenDocGia.Width = 270;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "MaTrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 100;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 190;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SoDienThoai";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 100;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 190;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 100;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = false;
            this.colGioiTinh.Width = 150;
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.DataPropertyName = "MaDocGia";
            this.colMaDocGia.HeaderText = "Mã độc giả";
            this.colMaDocGia.Name = "colMaDocGia";
            this.colMaDocGia.Visible = false;
            // 
            // colMaChucDanh
            // 
            this.colMaChucDanh.DataPropertyName = "MaChucDanh";
            this.colMaChucDanh.HeaderText = "Mã Chức Danh";
            this.colMaChucDanh.Name = "colMaChucDanh";
            this.colMaChucDanh.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = false;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = false;
            // 
            // colNgayDangKy
            // 
            this.colNgayDangKy.DataPropertyName = "NgayDangKy";
            this.colNgayDangKy.HeaderText = "Ngày đăng ký";
            this.colNgayDangKy.Name = "colNgayDangKy";
            this.colNgayDangKy.Visible = false;
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.DataPropertyName = "NgayHetHan";
            this.colNgayHetHan.HeaderText = "Ngày hết hạn";
            this.colNgayHetHan.Name = "colNgayHetHan";
            this.colNgayHetHan.Visible = false;
            // 
            // colLop
            // 
            this.colLop.DataPropertyName = "Lop";
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            this.colLop.Visible = false;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "MaKhoa";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = false;
            // 
            // colKhoaHoc
            // 
            this.colKhoaHoc.DataPropertyName = "KhoaHoc";
            this.colKhoaHoc.HeaderText = "Khóa học";
            this.colKhoaHoc.Name = "colKhoaHoc";
            this.colKhoaHoc.Visible = false;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "Username";
            this.colUserName.HeaderText = "Username";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = false;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "Password";
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = false;
            // 
            // bttChiTiet
            // 
            this.bttChiTiet.Location = new System.Drawing.Point(17, 355);
            this.bttChiTiet.Name = "bttChiTiet";
            this.bttChiTiet.Size = new System.Drawing.Size(150, 23);
            this.bttChiTiet.TabIndex = 5;
            this.bttChiTiet.Text = "Xem đầy đủ thông tin";
            this.bttChiTiet.UseVisualStyleBackColor = true;
            this.bttChiTiet.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thêm độc giả mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(712, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Location = new System.Drawing.Point(631, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Chỉnh sửa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm kiếm";
            // 
            // UserDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttChiTiet);
            this.Controls.Add(this.GridDocGia);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.cbbNamSinh);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.label1);
            this.Name = "UserDocGia";
            this.Text = "Độc giả";
            ((System.ComponentModel.ISupportInitialize)(this.GridDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbNamSinh;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView GridDocGia;
        private System.Windows.Forms.Button bttChiTiet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bsDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
    }
}