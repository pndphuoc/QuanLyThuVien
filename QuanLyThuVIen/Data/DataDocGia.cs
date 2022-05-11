using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataDocGia
    {
        public List<DocGia> GetListDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia";
                var lstSach = cnn.Query<DocGia>(sql).ToList();
                return lstSach;
            }
        }
        public List<DocGia> GetListDocGia1(int MaKhoa)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaKhoa=@MaKhoa";
                var param = new
                {
                    MaKhoa = MaKhoa
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }
        public List<DocGia> GetListDocGia2(int MaChucDanh)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaChucDanh=@MaChucDanh";
                var param = new
                {
                    MaChucDanh = MaChucDanh
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }

        public List<DocGia> GetListDocGia3(int MaTrangThai)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaTrangThai=@MaTrangThai";
                var param = new
                {
                    MaTrangThai = MaTrangThai
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }
        public DocGia GetDocGia(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaDocGia=@MaDocGia";
                var param = new
                {
                    MaDocGia = MaDocGia
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach[0];
            }
        }
    }
}
