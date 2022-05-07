using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace QuanLyThuVIen.Data
{
    public class DataSach
    {
        public List<Sach> GetListSach()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from Sach";
                var lstSach = cnn.Query<Sach>(sql).ToList();
                return lstSach;
            }
        }

        public List<SachResponse> GetListSachResponse()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"SELECT s.MaSach, s.TenSach,nxb.TenNhaXuatBan
                            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var lstSach = cnn.Query<SachResponse>(sql).ToList();
                return lstSach;
            }
        }

        public Sach GetSach(int MaSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"SELECT * from Sach where MaSach = @MaSach";
                var param = new { MaSach = MaSach };

                var result = cnn.Query<Sach>(sql, param).ToList();
                return result[0];
            }
        }

        public bool Insert(Sach s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"INSERT INTO Sach (TenSach, MaNhaXuatBan, MaNgonNgu, SoLuong, NamXuatBan, DonGia, SoTaiBan, TinhTrang, Anh)
                    VALUES (@TenSach, @MaNhaXuatBan, @MaNgonNgu, @SoLuong, @NamXuatBan, @DonGia, @SoTaiBan, @TinhTrang, @Anh)";

                var param = new
                {
                    TenSach = s.TenSach,
                    MaNhaXuatBan = s.MaNhaXuatBan,
                    MaNgonNgu = s.MaNgonNgu,
                    SoLuong = s.SoLuong,
                    NamXuatBan = s.NamXuatBan,
                    DonGia = s.DonGia,
                    SoTaiBan = s.SoTaiBan,
                    TinhTrang = s.TinhTrang,
                    Anh = s.Anh
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool Delete(int MaSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"delete from Sach where MaSach = @MaSach";

                var param = new
                {
                    MaSach = MaSach
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool Update(Sach s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update Sach set TenSach = @TenSach, MaNhaXuatBan = @MaNhaXuatBan, MaNgonNgu = @MaNgonNgu,
                        SoLuong = @SoLuong, NamXuatBan = @NamXuatBan, DonGia = @DonGia, SoTaiBan = @SoTaiBan,
                        Anh = @Anh, MaLoaiSach = MaLoaiSach where MaSach = @MaSach";

                var param = new
                {
                    MaSach = s.MaSach,
                    TenSach = s.TenSach,
                    MaNhaXuatBan = s.MaNhaXuatBan,
                    MaNgonNgu = s.MaNgonNgu,
                    SoLuong = s.SoLuong,
                    NamXuatBan = s.NamXuatBan,
                    DonGia = s.DonGia,
                    SoTaiBan = s.SoTaiBan,
                    Anh = s.Anh,
                    MaLoaiSach = s.MaLoaiSach
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public List<SachResponse> Search(string tenSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + tenSach + "%";
                var sql = @"select s.MaSach, s.TenSach, nxb.TenNhaXuatBan from Sach as s join NhaXuatBan as nxb on s.MaNhaXuatBan = nxb.MaNhaXuatBan
                where TenSach like @TenSach";

                var param = new
                {
                    TenSach = search
                };

                var lstSach = cnn.Query<SachResponse>(sql, param).ToList();
                return lstSach;
            }
        }
    }
}

