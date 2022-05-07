using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class DocGia_MuonSach
    {
        int MaDocGia { get; set; }
        int MaChiTietMuon { get; set; }
        int TenDocGia { get; set; }
        DateTime NgayMuon { get; set; }
        int SoLuongMuon { get; set; }
        DateTime HanTra { get; set; }
        bool TrangThai { get; set; }

    }
}
