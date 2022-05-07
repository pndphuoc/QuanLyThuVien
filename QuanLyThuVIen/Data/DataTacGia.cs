using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataTacGia
    {
        public List<TacGia> GetListTacGia()
        {

            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from TacGia";
                var lstTacGia = cnn.Query<TacGia>(sql).ToList();
                return lstTacGia;
            }
        }

        public List<TacGia> GetListTacGia(int MaSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from Sach_TacGia as stg join TacGia as tg on tg.MaTacGia = stg.MaTacGia where MaSach = @MaSach";
                var param = new { MaSach = MaSach };

                var result = cnn.Query<TacGia>(sql, param).ToList();
                return result;
            }
        }
        public void UpdateListTacGia(int MaSach, List<TacGia> lstTG)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"delete from Sach_TacGia where MaSach = @MaSach";

                var param = new
                {
                    MaSach = MaSach
                };
                cnn.Execute(sql, param);

                int nEffectedRows = cnn.Execute(sql, param);
                foreach (var item in lstTG)
                {
                    sql = "insert into Sach_TacGia values(@MaSach, @MaTacGia)";
                    var p = new { MaSach = MaSach, MaTacGia = item.MaTacGia };
                    cnn.Execute(sql, p);
                }
            }
        }
        public List<TacGia> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"select * from TacGia where TenTacGia like @TenTacGia";

                var param = new
                {
                    TenTacGia = search
                };

                var lstTacGia = cnn.Query<TacGia>(sql, param).ToList();
                return lstTacGia;
            }
        }
    }
}
