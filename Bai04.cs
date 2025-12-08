using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BTH4_BT4
{
    public partial class Bai04 : Form
    {
        private string currentFile = "";
        public Bai04()
        {
            InitializeComponent();
        }
        // Xử lý sự kiện Form load
        private void Bai04_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }
            int[] sizes = { 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                cbSize.Items.Add(s);
            }
            cbFont.SelectedItem = "Tahoma";
            cbSize.SelectedItem = 14;
            ApplyFont();
        }
        // Hàm áp dụng Font
        private void ApplyFont()
        {
            if (cbFont.SelectedItem == null || cbSize.SelectedItem == null) return;
            string fontName = cbFont.SelectedItem.ToString();
            float fontSize = float.Parse(cbSize.SelectedItem.ToString());
            FontStyle style = FontStyle.Regular;
            if (btnBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (btnItalic.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (btnUnderline.Checked)
            {
                style |= FontStyle.Underline;
            }
            rtbEdit.SelectionFont = new Font(fontName, fontSize, style);
        }
        // Xử lý sự kiện khi thay đổi lựa chọn trong ComboBox Font
        private void cbFont_SelectedIndexChanged(object sender, EventArgs e) {
            ApplyFont();
        }
        // Xử lý sự kiện khi thay đổi lựa chọn trong ComboBox Size
        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
        // Xử lý sự kiện nhấn nút Bold
        private void btnBold_Click(object sender, EventArgs e)
        {
            btnBold.Checked = !btnBold.Checked;
            ApplyFont();
        }
        // Xử lý sự kiện nhấn nút Italic
        private void btnItalic_Click(object sender, EventArgs e)
        {
            btnItalic.Checked = !btnItalic.Checked;
            ApplyFont();
        }
        // Xử lý sự kiện nhấn nút Underline
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            btnUnderline.Checked = !btnUnderline.Checked;
            ApplyFont();
        }
        // Xử lý sự kiện nhấn mở Tạo văn bản mới trong Menu Hệ thống
        private void menuNew_Click(object sender, EventArgs e)
        {
            rtbEdit.Clear();
            cbFont.SelectedItem = "Tahoma";
            cbSize.SelectedItem = 14;
            currentFile = "";
        }
        // Xử lý sự kiện nhấn mở Mở tập tin trong Menu Hệ thống
        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF File|*.rtf|Text File|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".rtf"))
                {
                    rtbEdit.LoadFile(openFileDialog.FileName);
                }
                else
                {
                    rtbEdit.Text = File.ReadAllText(openFileDialog.FileName);
                }
                currentFile = openFileDialog.FileName;
            }
        }
        // Xử lý sự kiện nhấn mở Lưu nội dung văn bản trong Menu Hệ thống
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "RTF File|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtbEdit.SaveFile(saveFileDialog.FileName);
                    currentFile = saveFileDialog.FileName;
                    MessageBox.Show("Đã lưu thành công!");
                }
            }
            else
            {
                rtbEdit.SaveFile(currentFile);
                MessageBox.Show("Đã lưu thành công!");
            }
        }
        // Xử lý sự kiện nhấn mở Thoát trong Menu Hệ thống
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý sự kiện nhấn Menu Định dạng
        private void menuFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = rtbEdit.SelectionFont;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtbEdit.SelectionFont = dlg.Font;
            }
        }
    }
}
