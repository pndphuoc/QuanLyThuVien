using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataDocGia_MuonSach
    {
        /// <summary>
        /// Lấy danh sách các độc giả đang mượn sách
        /// </summary>
        /// <returns></returns>
        public List<DocGia_MuonSach> GetListDocGiaMuonSach()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra, ctm.TrangThai 
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia";
                var lstSach = cnn.Query<DocGia_MuonSach>(sql).ToList();
                return lstSach;
            }
        }
        /// <summary>
        /// Tìm kiếm 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public List<DocGia_MuonSach> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"select s.MaSach, s.TenSach, nxb.TenNhaXuatBan from Sach as s join NhaXuatBan as nxb on s.MaNhaXuatBan = nxb.MaNhaXuatBan
                where TenSach like @TenSach";

                var param = new
                {
                    TenSach = search
                };

                var lstSach = cnn.Query<DocGia_MuonSach>(sql, param).ToList();
                return lstSach;
            }
        }
    }


}
