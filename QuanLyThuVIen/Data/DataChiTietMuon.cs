using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataChiTietMuon
    {
        /// <summary>
        /// Lấy danh sách chi tiết mượn
        /// </summary>
        /// <returns></returns>
        public List<ChiTietMuon> GetListChiTietMuon()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from ChiTietMuon";
                var lstChiTietMuon = cnn.Query<ChiTietMuon>(sql).ToList();
                return lstChiTietMuon;
            }
        }
        /// <summary>
        /// Lấy thông tin chi tiết mượn theo mã chi tiết mượn
        /// </summary>
        /// <param name="MaChiTietMuon"></param>
        /// <returns></returns>
        public ChiTietMuon GetChiTietMuon(int MaChiTietMuon)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from ChiTietMuon where MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    @MaChiTietMuon = MaChiTietMuon
                };
                var lstChiTietMuon = cnn.Query<ChiTietMuon>(sql, param).ToList();
                return lstChiTietMuon[0];
            }
        }
    }
}
