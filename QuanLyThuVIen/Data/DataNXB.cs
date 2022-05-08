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
        /// <summary>
        /// Lấy danh sách nhà xuất bản
        /// </summary>
        /// <returns></returns>
        public List<NhaXuatBan> GetListNXB()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NhaXuatBan";
                var lstNXB = cnn.Query<NhaXuatBan>(sql).ToList();
                return lstNXB;
            }
        }
        /// <summary>
        /// Lấy thông tin 1 nhà xuất bản
        /// </summary>
        /// <param name="MaNXB"></param>
        /// <returns></returns>
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
