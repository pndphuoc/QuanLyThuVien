﻿using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataChucDanh
    {
        /// <summary>
        /// Lấy danh sách các chức danh
        /// </summary>
        /// <returns></returns>
        public List<ChucDanh> GetListChucDanh()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from ChucDanh";
                var lstChucDanh = cnn.Query<ChucDanh>(sql).ToList();
                return lstChucDanh;
            }
        }
        /// <summary>
        /// Lấy thông tin 1 chức danh
        /// </summary>
        /// <param name="MaChucDanh"></param>
        /// <returns></returns>
        public ChucDanh GetChucDanh(int MaChucDanh)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from ChucDanh where MaChucDanh = @MaChucDanh";
                var param = new
                {
                    MaChucDanh = MaChucDanh
                };
                var lstChucDanh = cnn.Query<ChucDanh>(sql, param).ToList();
                return lstChucDanh[0];
            }
        }
    }
}
