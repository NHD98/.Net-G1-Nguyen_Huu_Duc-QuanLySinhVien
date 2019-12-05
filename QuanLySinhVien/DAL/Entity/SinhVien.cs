using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL.Entity
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoVaTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaNganh { get; set; }
        [ForeignKey("MaNganh")]
        public virtual Nganh nganh { get; set; }
        public virtual ICollection<DiemHocTap> ListDiemHocTap { get; set; }

        public static List<SinhVien> getListSinhVien()
        {
            List<SinhVien> list = new SinhVienDbContext().SinhVienDbSet.Select(e => e).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                //SinhVien temp = list.ElementAt(i);
                string msv = list.ElementAt(i).MaSinhVien;
                list.ElementAt(i).ListDiemHocTap = DiemHocTap.getDiemHocTap(msv);
            }
            return list;
        }
        public static void editSinhVien(string maSinhVien, string hoVaTen, bool gioiTinh, DateTime ngaySinh, double diem1, double diem2)
        {
            var db = new SinhVienDbContext();
            var sinhVien = db.SinhVienDbSet.Where(e => e.MaSinhVien == maSinhVien).FirstOrDefault();
            sinhVien.HoVaTen = hoVaTen;
            sinhVien.GioiTinh = gioiTinh;
            sinhVien.NgaySinh = ngaySinh;
            var diem = db.DiemHocTapDbSet.Where(e => e.MaSinhVien == maSinhVien).ToList();
            diem.ElementAt(0).Diem = diem1;
            diem.ElementAt(1).Diem = diem2;
            db.SaveChanges();
        }

        public static void xoaSinhVien(string maSinhVien)
        {
            var db = new SinhVienDbContext();
            var sinhVien = db.SinhVienDbSet.Where(e => e.MaSinhVien == maSinhVien).FirstOrDefault();
            db.SinhVienDbSet.Remove(sinhVien);
            db.SaveChanges();
        }

        public static void themSinhVien(SinhVien sv)
        {
            var db = new SinhVienDbContext();
            db.SinhVienDbSet.Add(sv);
            db.SaveChanges();
        }

    }
}
