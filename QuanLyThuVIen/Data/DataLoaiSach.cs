using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataLoaiSach
    {
        public List<LoaiSach> GetListLoaiSach()
        {

            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from LoaiSach";
                var lstLoaiSach = cnn.Query<LoaiSach>(sql).ToList();
                return lstLoaiSach;
            }
        }
    }
}
