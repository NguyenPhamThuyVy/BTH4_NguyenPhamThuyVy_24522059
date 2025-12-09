using System;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace BTH4_BT6
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnCopy, "Nhấn để sao chép toàn bộ file");
            toolTip1.SetToolTip(btnSource, "Chọn thư mục chứa file nguồn");
            toolTip1.SetToolTip(btnDest, "Chọn thư mục lưu trữ file đích");
        }
        // Xử lý sự kiện chọn thư mục nguồn
        private void btnSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog  dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = dialog.SelectedPath;
                }
            }
        }
        // Xử lý sự kiện chọn thư mục đích
        private void btnDest_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDest.Text = dialog.SelectedPath;
                }
            }
        }
        // Xử lý sự kiện nút Sao Chép
        private async void btnCopy_Click(object sender, EventArgs e)
        {
            string sourceDir = txtSource.Text;
            string destDir = txtDest.Text;
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(sourceDir) || string.IsNullOrEmpty(destDir))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thư mục nguồn và đích!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string[] files = Directory.GetFiles(sourceDir);
                int totalFiles = files.Length;
                if (totalFiles == 0)
                {
                    MessageBox.Show("Thư mục nguồn trống!", "Thông báo");
                    return;
                }
                // Xử lý ProgressBar
                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalFiles;
                progressBar1.Value = 0;
                btnCopy.Enabled = false;

                // Sao chép
                for (int i = 0; i < totalFiles; i++)
                {
                    string sourceFile = files[i];
                    string fileName = Path.GetFileName(sourceFile);
                    string destFile = Path.Combine(destDir, fileName);
                    lblStatus.Text = $"Đang sao chép: {fileName}";
                    toolTip1.SetToolTip(progressBar1, $"Đang xử lý: {sourceFile}");

                    await Task.Run(() =>
                    {
                        File.Copy(sourceFile, destFile, true); // true = ghi đè nếu file đã tồn tại
                    });
                    progressBar1.Value = i + 1;
                }
                MessageBox.Show("Sao chép hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                statusBar.Text = "Sẵn sàng";
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCopy.Enabled = true;
            }
        }
    }
}
