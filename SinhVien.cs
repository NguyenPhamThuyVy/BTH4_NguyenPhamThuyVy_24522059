using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH4_BT5
{
    public class SinhVien
    {
        // Khai báo thuộc tính
        [Key]
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Khoa { get; set; }
        public float DiemTB { get; set; }
        // Constructor 
        public SinhVien() { }
        public SinhVien(string mssv, string ht, string k, float dTB)
        {
            MSSV = mssv;
            HoTen = ht;
            Khoa = k;
            DiemTB = dTB;
        }
    }
}
