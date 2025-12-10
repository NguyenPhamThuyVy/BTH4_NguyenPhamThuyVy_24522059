using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; // Tìm kiếm
using System.Windows.Forms;
namespace BTH4_BT5
{
    public partial class Bai05 : Form
    {
        StudentContext db = new StudentContext();
        public Bai05()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
        }
        // Xử lý sự kiện Form load
        private void Bai05_Load(object sender, EventArgs e)
        {
            var listData = db.SinhViens.ToList();
            BindGrid(listData);

        }
        // Hàm hiển thị danh sách lên GridView
        private void BindGrid(List<SinhVien> l)
        {
            dgvSV.Rows.Clear();
            int stt = 1;
            foreach (var s in l)
            {
                dgvSV.Rows.Add(stt++, s.MSSV, s.HoTen, s.Khoa, s.DiemTB);
            }
        }
        // Xử lý sự kiện mở form 
        private void OpenInputForm()
        {
            NhapLieuSinhVien nhap = new NhapLieuSinhVien();
            // Sự kiện nhận dữ liệu từ form con
            nhap.OnStudentAdded += SinhVien_ReceiveData;
            nhap.ShowDialog();
        }
        // Hàm xử lý sự kiện khi nhấn nút Thêm Mới
        private void SinhVien_ReceiveData(SinhVien sv)
        {
            try
            {

                db.SinhViens.Add(sv); 
                db.SaveChanges();     
                BindGrid(db.SinhViens.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }
        // Xử lý sự kiện nhấn Thêm Mới trong Menu Chức Năng
        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenInputForm();
        }
        // Xử lý sự kiện nhấn Thoát trong Menu Chức Năng 
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Hàm tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                BindGrid(db.SinhViens.ToList());
            }
            else
            {
                var allStudents = db.SinhViens.ToList();
                var result = allStudents.Where(sv => sv.HoTen.ToLower().Contains(keyword)).ToList();
                BindGrid(result);
            }
        }
        // Định dạng DataGridView

        private void dgvSV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSV.Columns[e.ColumnIndex].Name == "stt")
            {
                e.Value = (e.RowIndex + 1).ToString();
            }
        }
    }
}
