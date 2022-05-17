using Dapper;
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
                try
                {

                var sql = "select * from DocGia where MaDocGia = @MaDocGia";
                var param = new
                {
                    MaDocGia = MaDocGia
                };

                var lstDocGia = cnn.Query<DocGia>(sql, param).ToList();
                return lstDocGia[0];
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Index is out of range", nameof(MaDocGia), ex);
                }
            }
        }

        public int MaxOfMaDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select Max(MaDocGia) from DocGia";

                

                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }

        public int GetMaDocGia(int MaChiTietMuon)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select MaDocGia from ChiTietMuon where MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon
                };
                int MaDocGia = Convert.ToInt32(cnn.ExecuteScalar(sql, param));
                return MaDocGia;
            }
        }
    }
}
