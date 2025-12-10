namespace BTH4_BT5
{
    partial class Bai05
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            themMoiToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txtTimKiem = new ToolStripTextBox();
            dgvSV = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            mssv = new DataGridViewTextBoxColumn();
            tenSV = new DataGridViewTextBoxColumn();
            khoa = new DataGridViewTextBoxColumn();
            diemTB = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSV).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themMoiToolStripMenuItem, thoatToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(96, 24);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // themMoiToolStripMenuItem
            // 
            themMoiToolStripMenuItem.Image = (Image)resources.GetObject("themMoiToolStripMenuItem.Image");
            themMoiToolStripMenuItem.Name = "themMoiToolStripMenuItem";
            themMoiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            themMoiToolStripMenuItem.Size = new Size(212, 26);
            themMoiToolStripMenuItem.Text = "Thêm mới";
            themMoiToolStripMenuItem.Click += themMoiToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(212, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, txtTimKiem });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 32);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(116, 29);
            toolStripButton1.Text = "Thêm Mới";
            toolStripButton1.Click += themMoiToolStripMenuItem_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(136, 29);
            toolStripLabel1.Text = "Tìm Kiếm Theo Tên";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 32);
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvSV
            // 
            dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSV.Columns.AddRange(new DataGridViewColumn[] { stt, mssv, tenSV, khoa, diemTB });
            dgvSV.Dock = DockStyle.Fill;
            dgvSV.Location = new Point(0, 60);
            dgvSV.Name = "dgvSV";
            dgvSV.RowHeadersWidth = 51;
            dgvSV.Size = new Size(800, 390);
            dgvSV.TabIndex = 4;
            dgvSV.CellFormatting += dgvSV_CellFormatting;
            // 
            // stt
            // 
            stt.HeaderText = "Số TT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 125;
            // 
            // mssv
            // 
            mssv.HeaderText = "Mã Số SV";
            mssv.MinimumWidth = 6;
            mssv.Name = "mssv";
            mssv.ReadOnly = true;
            mssv.Width = 125;
            // 
            // tenSV
            // 
            tenSV.HeaderText = "Tên Sinh Viên";
            tenSV.MinimumWidth = 6;
            tenSV.Name = "tenSV";
            tenSV.ReadOnly = true;
            tenSV.Width = 200;
            // 
            // khoa
            // 
            khoa.HeaderText = "Khoa";
            khoa.MinimumWidth = 6;
            khoa.Name = "khoa";
            khoa.ReadOnly = true;
            khoa.Width = 170;
            // 
            // diemTB
            // 
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            diemTB.DefaultCellStyle = dataGridViewCellStyle1;
            diemTB.HeaderText = "Điểm TB";
            diemTB.MinimumWidth = 6;
            diemTB.Name = "diemTB";
            diemTB.ReadOnly = true;
            diemTB.Width = 125;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSV);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Bai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            Load += Bai05_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem themMoiToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTimKiem;
        private DataGridView dgvSV;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn mssv;
        private DataGridViewTextBoxColumn tenSV;
        private DataGridViewTextBoxColumn khoa;
        private DataGridViewTextBoxColumn diemTB;
    }
}
