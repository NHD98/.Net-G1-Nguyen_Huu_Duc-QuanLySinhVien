using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace QuanLySinhVien.DAL.Entity
{
    public class DiemHocTap
    {
        [Key]
        [Column(Order =1)]
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public double Diem { get; set; }
        [Key]
        [Column(Order =2)]
        public string MaSinhVien { get; set; }
        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }

        public static List<DiemHocTap> getDiemHocTap(string maSinhVien)
        {
            List<DiemHocTap> temp = new SinhVienDbContext().DiemHocTapDbSet.Where(e => e.MaSinhVien == maSinhVien).ToList();
            return temp;
        }

        public static void editDiemHocTap(string maSinhVien, double diem1, double diem2)
        {
            var db = new SinhVienDbContext();
            var diemHocTap = db.DiemHocTapDbSet.Where(e => e.MaSinhVien == maSinhVien).ToList();
            diemHocTap.ElementAt(0).Diem = diem1;
            diemHocTap.ElementAt(1).Diem = diem2;
            db.SaveChanges();
        }

        public static void xoaDiemHocTap(string maSinhVien)
        {
            var db = new SinhVienDbContext();
            List<DiemHocTap> diemHocTap = db.DiemHocTapDbSet.Where(e => e.MaSinhVien == maSinhVien).ToList();
            db.DiemHocTapDbSet.RemoveRange(diemHocTap);
            db.SaveChanges();
        }

        public static void themDiemHocTap(string maSinhVien,string maMonHoc1, string tenMonHoc1, double diem1, string maMonHoc2, string tenMonHoc2, double diem2)
        {
            var db = new SinhVienDbContext();
            DiemHocTap diemHocTap1 = new DiemHocTap { MaMonHoc = maMonHoc1, Diem = diem1, MaSinhVien = maSinhVien, TenMonHoc = tenMonHoc1 };
            DiemHocTap diemHocTap2 = new DiemHocTap { MaMonHoc = maMonHoc2, Diem = diem2, MaSinhVien = maSinhVien, TenMonHoc = tenMonHoc2 };
            db.DiemHocTapDbSet.Add(diemHocTap1);
            db.DiemHocTapDbSet.Add(diemHocTap2);
            db.SaveChanges();
        }

    }
}