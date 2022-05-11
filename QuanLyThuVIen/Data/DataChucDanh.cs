using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataChucDanh
    {
        public List<ChucDanh> GetListChucDanh()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from ChucDanh";
                var lstCD = cnn.Query<ChucDanh>(sql).ToList();
                return lstCD;
            }
        }
    }
}
