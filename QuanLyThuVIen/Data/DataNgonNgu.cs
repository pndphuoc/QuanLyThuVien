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
        /// <summary>
        /// Lấy danh sách ngôn ngữ
        /// </summary>
        /// <returns></returns>
        public List<NgonNgu> GetListNgonNgu()
        {

                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = "SELECT * from NgonNgu";
                    var lstNgonNgu = cnn.Query<NgonNgu>(sql).ToList();
                    return lstNgonNgu;
                }           
        }
        /// <summary>
        /// Lấy thông tin 1 ngôn ngữ
        /// </summary>
        /// <param name="MaNgonNgu"></param>
        /// <returns></returns>
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
