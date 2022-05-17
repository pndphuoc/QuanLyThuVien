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
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia where ctm.TrangThai = 0";
                var lstSach = cnn.Query<DocGia_MuonSach>(sql).ToList();
                return lstSach;
            }
        }

        public List<DocGia_MuonSach> GetListQuaHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra, ctm.TrangThai 
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia where DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))> ctm.HanTra and ctm.TrangThai = 0";
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
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra, ctm.TrangThai 
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia
                            where ctm.MaChiTietMuon like @searchValue or dg.TenDocGia like @search";

                var param = new
                {
                    searchValue = searchValue,
                    search = search
                };

                var lstSach = cnn.Query<DocGia_MuonSach>(sql, param).ToList();
                return lstSach;
            }
        }
    }


}
