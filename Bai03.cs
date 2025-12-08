using System;
using System.Windows.Forms;
using System.Globalization;

namespace BTH4_BT3
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            this.Load += Bai03_Load;
        }
        // Xử lý sự kiện Form load
        private void Bai03_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            UpdateTime();
        }
        // Xử lý sự kiện Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
        // Hàm cập nhật thời gian
        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            string s = String.Format("Hôm nay là ngày {0:dd/MM/yyyy} - Bây giờ là {0:hh:mm:ss tt}", now);
            lblStatus.Text = s;
        }
        // Xử lý sự kiện nhấn mở Open trong Menu File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media Files|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|All Files|*.*";
            ofd.Title = "Chọn tập tin Media";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
            }
        }
        // Xử lý sự kiện nhấn mở Exit trong Menu File
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
