namespace BTH4_BT5
{
    partial class NhapLieuSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnThemMoi = new Button();
            btnThoat = new Button();
            txtMSSV = new TextBox();
            txtTenSV = new TextBox();
            txtDiemTB = new TextBox();
            cbKhoa = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 56);
            label1.Name = "label1";
            label1.Size = new Size(181, 27);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 115);
            label2.Name = "label2";
            label2.Size = new Size(181, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 173);
            label3.Name = "label3";
            label3.Size = new Size(181, 27);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 235);
            label4.Name = "label4";
            label4.Size = new Size(181, 27);
            label4.TabIndex = 3;
            label4.Text = "Điểm TB";
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.LimeGreen;
            btnThemMoi.Cursor = Cursors.Hand;
            btnThemMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(503, 271);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(109, 42);
            btnThemMoi.TabIndex = 4;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkOrange;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(629, 271);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 42);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(260, 56);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(352, 27);
            txtMSSV.TabIndex = 6;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(260, 115);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(463, 27);
            txtTenSV.TabIndex = 7;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(260, 235);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(148, 27);
            txtDiemTB.TabIndex = 8;
            // 
            // cbKhoa
            // 
            cbKhoa.BackColor = SystemColors.AppWorkspace;
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Hệ thống thông tin", "Khoa học máy tính", "Kỹ thuật phần mềm", "Kỹ thuật máy tính", "Mạng máy tính và truyền thông dữ liệu", "An toàn thông tin", "Thương mại điện tử", "Khoa học dữ liệu", "Trí tuệ nhân tạo", "Thiết kế vi mạch", "Truyền thông đa phương tiện" });
            cbKhoa.Location = new Point(260, 179);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(463, 28);
            cbKhoa.TabIndex = 9;
            // 
            // NhapLieuSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 325);
            Controls.Add(cbKhoa);
            Controls.Add(txtDiemTB);
            Controls.Add(txtTenSV);
            Controls.Add(txtMSSV);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "NhapLieuSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnThemMoi;
        private Button btnThoat;
        private TextBox txtMSSV;
        private TextBox txtTenSV;
        private TextBox txtDiemTB;
        private ComboBox cbKhoa;
    }
}