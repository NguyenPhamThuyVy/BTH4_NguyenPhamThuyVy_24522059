using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Thư viện để làm việc với CSDL
using System.IO;

namespace BTH4_BT5
{
    public class StudentContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CSDL_SinhVien.db");
        }
    }
}
