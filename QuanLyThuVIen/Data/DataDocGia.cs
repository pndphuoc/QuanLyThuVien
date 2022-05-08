﻿using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataDocGia
    {
        /// <summary>
        /// Lấy danh sách độc giả
        /// </summary>
        /// <returns></returns>
        public List<DocGia> GetListDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from DocGia";
                var lstDocGia = cnn.Query<DocGia>(sql).ToList();
                return lstDocGia;
            }
        }
        /// <summary>
        /// Lấy thông tin 1 độc giả theo mã độc giả
        /// </summary>
        /// <param name="MaDocGia"></param>
        /// <returns></returns>
        public DocGia GetDocGia(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from DocGia where MaDocGia = @MaDocGia";
                var param = new
                {
                    MaDocGia = MaDocGia
                };

                var lstDocGia = cnn.Query<DocGia>(sql, param).ToList();
                return lstDocGia[0];
            }
        }
    }
}
