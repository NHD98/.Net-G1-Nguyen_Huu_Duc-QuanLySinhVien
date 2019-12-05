using QuanLySinhVien.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class SinhVienDbContext : DbContext
    {
        public SinhVienDbContext() : base("Data Source=.;Initial Catalog=QuanLySinhVien-.Net;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<SinhVien> SinhVienDbSet { get; set; }
        public DbSet<DiemHocTap> DiemHocTapDbSet { get; set; }
        public DbSet<Nganh> NganhDbSet { get; set; }

    }
}
