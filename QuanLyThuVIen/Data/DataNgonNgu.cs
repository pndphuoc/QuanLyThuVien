using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataNgonNgu
    {
        public List<NgonNgu> GetListNgonNgu()
        {

                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = "SELECT * from NgonNgu";
                    var lstNgonNgu = cnn.Query<NgonNgu>(sql).ToList();
                    return lstNgonNgu;
                }           
        }

        public NgonNgu GetNgonNgu(int MaNgonNgu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"SELECT * from NgonNgu where MaNgonNgu = @MaNgonNgu";
                var param = new { MaNgonNgu = MaNgonNgu };

                var result = cnn.Query<NgonNgu>(sql, param).ToList();
                return result[0];
            }
        }
    }
}
