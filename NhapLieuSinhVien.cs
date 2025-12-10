using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.RegularExpressions;

namespace BTH4_BT5
{
    // Khai báo delegate truyền dữ liệu
    public delegate void SendData(SinhVien sv);
    public partial class NhapLieuSinhVien : Form
    {
        // Sự kiện dùng để gửi dữ liệu về Form cha
        public SendData OnStudentAdded;
        public NhapLieuSinhVien()
        {
            InitializeComponent();
            if (cbKhoa.Items.Count > 0)
            {
                cbKhoa.SelectedIndex = 0;
            }
        }
        // Xử lý sự kiện nhấn nút Thêm Mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtMSSV.Text) || string.IsNullOrEmpty(txtTenSV.Text) || string.IsNullOrEmpty(txtDiemTB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(txtTenSV.Text, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Tên sinh viên không được chứa số hoặc ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenSV.Focus();
                    return;
                }
                if (txtDiemTB.Text.Contains("."))
                {
                    MessageBox.Show("Vui lòng nhập điểm dưới định dạng dấu phẩy (,)", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                float diemTB;
                bool isNumber = float.TryParse(txtDiemTB.Text, out diemTB);

                if (!isNumber)
                {
                    MessageBox.Show("Điểm trung bình phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (diemTB < 0 || diemTB > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra trùng mã trong CSDL
                using (var db = new StudentContext())
                {
                    // Kiểm tra trong bảng SinhViens xem MSSV đã có chưa
                    bool daTonTai = db.SinhViens.Any(s => s.MSSV == txtMSSV.Text);

                    if (daTonTai)
                    {
                        MessageBox.Show("Mã sinh viên này đã tồn tại trong CSDL!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMSSV.Focus(); 
                        return; 
                    }
                }
                SinhVien sv = new SinhVien
                {
                    MSSV = txtMSSV.Text,
                    HoTen = txtTenSV.Text,
                    Khoa = cbKhoa.Text,
                    DiemTB = diemTB 
                };
                if (OnStudentAdded != null)
                {
                    OnStudentAdded(sv);
                }
                txtMSSV.Clear();
                txtTenSV.Clear();
                txtDiemTB.Clear();
                txtMSSV.Focus();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message);
            }
        }
        // Xử lý sự kiện nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
