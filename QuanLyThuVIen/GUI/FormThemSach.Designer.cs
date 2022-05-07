namespace QuanLyThuVIen.GUI
{
    partial class FormThemSach
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
            this.lbTacGia = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.txtLanTaiBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaBia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNgonNgu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiSach = new System.Windows.Forms.ComboBox();
            this.EditAuthorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.Label();
            this.BookPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.labelPhotoPath = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTacGia
            // 
            this.lbTacGia.FormattingEnabled = true;
            this.lbTacGia.ItemHeight = 16;
            this.lbTacGia.Location = new System.Drawing.Point(169, 108);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(206, 84);
            this.lbTacGia.TabIndex = 51;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(280, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 34);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(393, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(23, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbNXB
            // 
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(264, 303);
            this.cbNXB.Margin = new System.Windows.Forms.Padding(4);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(218, 24);
            this.cbNXB.TabIndex = 47;
            // 
            // txtLanTaiBan
            // 
            this.txtLanTaiBan.Location = new System.Drawing.Point(264, 435);
            this.txtLanTaiBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanTaiBan.Name = "txtLanTaiBan";
            this.txtLanTaiBan.Size = new System.Drawing.Size(218, 22);
            this.txtLanTaiBan.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 414);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Lần tái bản";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(264, 368);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(218, 22);
            this.txtSoLuong.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Số lượng còn trong thư viện:";
            // 
            // txtGiaBia
            // 
            this.txtGiaBia.Location = new System.Drawing.Point(21, 435);
            this.txtGiaBia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBia.Name = "txtGiaBia";
            this.txtGiaBia.Size = new System.Drawing.Size(216, 22);
            this.txtGiaBia.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Giá bìa";
            // 
            // cbNgonNgu
            // 
            this.cbNgonNgu.FormattingEnabled = true;
            this.cbNgonNgu.Location = new System.Drawing.Point(21, 368);
            this.cbNgonNgu.Margin = new System.Windows.Forms.Padding(4);
            this.cbNgonNgu.Name = "cbNgonNgu";
            this.cbNgonNgu.Size = new System.Drawing.Size(216, 24);
            this.cbNgonNgu.TabIndex = 40;
            this.cbNgonNgu.Text = "-- Ngôn ngữ --";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ngôn ngữ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Loại sách";
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Location = new System.Drawing.Point(21, 303);
            this.cbLoaiSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(216, 24);
            this.cbLoaiSach.TabIndex = 37;
            this.cbLoaiSach.Text = "-- Thể loại --";
            // 
            // EditAuthorButton
            // 
            this.EditAuthorButton.Location = new System.Drawing.Point(382, 108);
            this.EditAuthorButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditAuthorButton.Name = "EditAuthorButton";
            this.EditAuthorButton.Size = new System.Drawing.Size(100, 28);
            this.EditAuthorButton.TabIndex = 36;
            this.EditAuthorButton.Text = "Chỉnh sửa";
            this.EditAuthorButton.UseVisualStyleBackColor = true;
            this.EditAuthorButton.Click += new System.EventHandler(this.EditAuthorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tác giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nhà xuất bản";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(169, 61);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(313, 22);
            this.txtBookName.TabIndex = 33;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(166, 41);
            this.BookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(71, 17);
            this.BookName.TabIndex = 32;
            this.BookName.Text = "Tên sách:";
            // 
            // BookPicture
            // 
            this.BookPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookPicture.Location = new System.Drawing.Point(21, 123);
            this.BookPicture.Margin = new System.Windows.Forms.Padding(4);
            this.BookPicture.Name = "BookPicture";
            this.BookPicture.Size = new System.Drawing.Size(0, 236);
            this.BookPicture.TabIndex = 31;
            this.BookPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "THÔNG TIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 150);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Location = new System.Drawing.Point(21, 198);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(138, 34);
            this.btnThemAnh.TabIndex = 53;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // labelPhotoPath
            // 
            this.labelPhotoPath.AutoSize = true;
            this.labelPhotoPath.Location = new System.Drawing.Point(166, 207);
            this.labelPhotoPath.Name = "labelPhotoPath";
            this.labelPhotoPath.Size = new System.Drawing.Size(0, 17);
            this.labelPhotoPath.TabIndex = 54;
            this.labelPhotoPath.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(264, 237);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(218, 22);
            this.txtNamXB.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Năm xuất bản";
            // 
            // FormThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 531);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.labelPhotoPath);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTacGia);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbNXB);
            this.Controls.Add(this.txtLanTaiBan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGiaBia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNgonNgu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLoaiSach);
            this.Controls.Add(this.EditAuthorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.BookPicture);
            this.Controls.Add(this.label1);
            this.Name = "FormThemSach";
            this.Text = "FormThemSach";
            this.Load += new System.EventHandler(this.FormThemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTacGia;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.TextBox txtLanTaiBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaBia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNgonNgu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiSach;
        private System.Windows.Forms.Button EditAuthorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.PictureBox BookPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.Label labelPhotoPath;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label9;
    }
}