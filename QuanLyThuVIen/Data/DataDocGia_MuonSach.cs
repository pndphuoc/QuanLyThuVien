using Dapper;
using System;
using System.Collections.Generic;
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
                var sql = "select * from Sach";
                var lstSach = cnn.Query<DataDocGia_MuonSach>(sql).ToList();
                return lstSach;
            }
        }
    }
}
