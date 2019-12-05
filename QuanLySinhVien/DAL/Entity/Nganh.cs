using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL.Entity
{
    public class Nganh
    {
        [Key]
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }

       public static List<Nganh> getNganh()
        {
            List<Nganh> list = new SinhVienDbContext().NganhDbSet.Select(e => e).ToList();
            return list;
        }

    }
}
