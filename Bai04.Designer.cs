namespace BTH4_BT4
{
    partial class Bai04
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04));
            menuStrip1 = new MenuStrip();
            menuNew = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNew = new ToolStripButton();
            btnSave = new ToolStripButton();
            cbFont = new ToolStripComboBox();
            cbSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            rtbEdit = new RichTextBox();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuNew, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuNew
            // 
            menuNew.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, menuOpen, menuSave, menuExit });
            menuNew.Name = "menuNew";
            menuNew.Size = new Size(85, 24);
            menuNew.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Image = (Image)resources.GetObject("tạoVănBảnMớiToolStripMenuItem.Image");
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(285, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += menuNew_Click;
            // 
            // menuOpen
            // 
            menuOpen.Image = (Image)resources.GetObject("menuOpen.Image");
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(285, 26);
            menuOpen.Text = "Mở tập tin";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Image = (Image)resources.GetObject("menuSave.Image");
            menuSave.Name = "menuSave";
            menuSave.ShortcutKeys = Keys.Control | Keys.S;
            menuSave.Size = new Size(285, 26);
            menuSave.Text = "Lưu nội dung văn bản";
            menuSave.Click += menuSave_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(285, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(92, 24);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += menuFont_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNew, btnSave, cbFont, cbSize, btnBold, btnItalic, btnUnderline });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(29, 25);
            btnNew.Text = "New";
            btnNew.Click += menuNew_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 25);
            btnSave.Text = "Save";
            btnSave.Click += menuSave_Click;
            // 
            // cbFont
            // 
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(121, 28);
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
            // 
            // cbSize
            // 
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(121, 28);
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.BackColor = SystemColors.AppWorkspace;
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBold.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 25);
            btnBold.Text = "B";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.BackColor = SystemColors.AppWorkspace;
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnItalic.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 25);
            btnItalic.Text = "I";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.BackColor = SystemColors.AppWorkspace;
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUnderline.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(29, 25);
            btnUnderline.Text = "U";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // rtbEdit
            // 
            rtbEdit.Dock = DockStyle.Fill;
            rtbEdit.Location = new Point(0, 56);
            rtbEdit.Name = "rtbEdit";
            rtbEdit.Size = new Size(800, 456);
            rtbEdit.TabIndex = 2;
            rtbEdit.Text = "";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(rtbEdit);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bai04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soạn thảo văn bản";
            Load += Bai04_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private RichTextBox rtbEdit;
        private ToolStripButton btnNew;
        private ToolStripButton btnSave;
        private ToolStripComboBox cbFont;
        private ToolStripComboBox cbSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private ImageList imageList1;
    }
}
