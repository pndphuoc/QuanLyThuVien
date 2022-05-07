using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataNXB
    {
        public List<NhaXuatBan> GetListNXB()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NhaXuatBan";
                var lstNXB = cnn.Query<NhaXuatBan>(sql).ToList();
                return lstNXB;
            }
        }

        public NhaXuatBan GetNXB(int MaNXB)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NhaXuatBan where MaNhaXuatBan = @MaNXB";
                var param = new { MaNXB = MaNXB };
                var lstNXB = cnn.Query<NhaXuatBan>(sql, param).ToList();
                return lstNXB[0];
            }
        }
    }
}
