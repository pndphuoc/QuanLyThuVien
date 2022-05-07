﻿namespace QuanLyThuVIen
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatisticsReport = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnBookManager = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategoryManage = new System.Windows.Forms.Button();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBorrowGiveBack = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 0);
            this.panel1.TabIndex = 0;
            // 
            // btnStatisticsReport
            // 
            this.btnStatisticsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStatisticsReport.Location = new System.Drawing.Point(503, 3);
            this.btnStatisticsReport.Name = "btnStatisticsReport";
            this.btnStatisticsReport.Size = new System.Drawing.Size(94, 51);
            this.btnStatisticsReport.TabIndex = 22;
            this.btnStatisticsReport.Text = "Thống kê - báo cáo";
            this.btnStatisticsReport.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccount.Location = new System.Drawing.Point(603, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(100, 51);
            this.btnAccount.TabIndex = 23;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnBookManager
            // 
            this.btnBookManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookManager.Location = new System.Drawing.Point(103, 3);
            this.btnBookManager.Name = "btnBookManager";
            this.btnBookManager.Size = new System.Drawing.Size(94, 51);
            this.btnBookManager.TabIndex = 19;
            this.btnBookManager.Text = "Quản lý sách";
            this.btnBookManager.UseVisualStyleBackColor = true;
            this.btnBookManager.Click += new System.EventHandler(this.btnBookManager_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 51);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnCategoryManage
            // 
            this.btnCategoryManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryManage.Location = new System.Drawing.Point(203, 3);
            this.btnCategoryManage.Name = "btnCategoryManage";
            this.btnCategoryManage.Size = new System.Drawing.Size(94, 51);
            this.btnCategoryManage.TabIndex = 20;
            this.btnCategoryManage.Text = "Quản lý danh mục";
            this.btnCategoryManage.UseVisualStyleBackColor = true;
            // 
            // btnUserManage
            // 
            this.btnUserManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserManage.Location = new System.Drawing.Point(303, 3);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(94, 51);
            this.btnUserManage.TabIndex = 21;
            this.btnUserManage.Text = "Quản lý người dùng";
            this.btnUserManage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnBookManager);
            this.flowLayoutPanel1.Controls.Add(this.btnCategoryManage);
            this.flowLayoutPanel1.Controls.Add(this.btnUserManage);
            this.flowLayoutPanel1.Controls.Add(this.btnMuonTra);
            this.flowLayoutPanel1.Controls.Add(this.btnStatisticsReport);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(852, 57);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // btnBorrowGiveBack
            // 
            this.btnBorrowGiveBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrowGiveBack.Location = new System.Drawing.Point(413, 6);
            this.btnBorrowGiveBack.Name = "btnBorrowGiveBack";
            this.btnBorrowGiveBack.Size = new System.Drawing.Size(94, 51);
            this.btnBorrowGiveBack.TabIndex = 24;
            this.btnBorrowGiveBack.Text = "Quản lý mượn - trả";
            this.btnBorrowGiveBack.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 57);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(852, 475);
            this.mainPanel.TabIndex = 25;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMuonTra.Location = new System.Drawing.Point(403, 3);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(94, 51);
            this.btnMuonTra.TabIndex = 24;
            this.btnMuonTra.Text = "Quản lý mượn trả";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 532);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBorrowGiveBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatisticsReport;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBookManager;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategoryManage;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBorrowGiveBack;
        private System.Windows.Forms.Panel mainPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMuonTra;
    }
}

