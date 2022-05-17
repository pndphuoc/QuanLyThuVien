
namespace QuanLyThuVIen.GUI
{
    partial class UserManagerForm
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
            this.bttDocGia = new System.Windows.Forms.Button();
            this.bttThuThu = new System.Windows.Forms.Button();
            this.bttQuanLy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bttDocGia
            // 
            this.bttDocGia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttDocGia.BackgroundImage = global::QuanLyThuVIen.Properties.Resources.gai;
            this.bttDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttDocGia.Location = new System.Drawing.Point(13, 13);
            this.bttDocGia.Name = "bttDocGia";
            this.bttDocGia.Size = new System.Drawing.Size(75, 23);
            this.bttDocGia.TabIndex = 0;
            this.bttDocGia.Text = "Độc giả";
            this.bttDocGia.UseVisualStyleBackColor = false;
            this.bttDocGia.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttThuThu
            // 
            this.bttThuThu.Location = new System.Drawing.Point(94, 13);
            this.bttThuThu.Name = "bttThuThu";
            this.bttThuThu.Size = new System.Drawing.Size(75, 23);
            this.bttThuThu.TabIndex = 0;
            this.bttThuThu.Text = "Thủ thư";
            this.bttThuThu.UseVisualStyleBackColor = true;
            this.bttThuThu.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttQuanLy
            // 
            this.bttQuanLy.Location = new System.Drawing.Point(175, 13);
            this.bttQuanLy.Name = "bttQuanLy";
            this.bttQuanLy.Size = new System.Drawing.Size(75, 23);
            this.bttQuanLy.TabIndex = 0;
            this.bttQuanLy.Text = "Quản lý";
            this.bttQuanLy.UseVisualStyleBackColor = true;
            this.bttQuanLy.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 401);
            this.panel1.TabIndex = 1;
            // 
            // UserManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(979, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttQuanLy);
            this.Controls.Add(this.bttThuThu);
            this.Controls.Add(this.bttDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttDocGia;
        private System.Windows.Forms.Button bttThuThu;
        private System.Windows.Forms.Button bttQuanLy;
        private System.Windows.Forms.Panel panel1;
    }
}