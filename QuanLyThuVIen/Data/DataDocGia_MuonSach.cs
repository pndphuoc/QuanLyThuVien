using Dapper;
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
        public List<DataDocGia_MuonSach> GetListDocGiaMuonSach()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra, ctm.TrangThai 
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia";
                var lstSach = cnn.Query<DataDocGia_MuonSach>(sql).ToList();
                return lstSach;
            }
        }
    }
}
