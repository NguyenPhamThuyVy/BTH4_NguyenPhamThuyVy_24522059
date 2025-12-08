using System;
using System.Globalization;
using System.Windows.Forms;
namespace BTH4_BT2
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            this.Load += Bai02_Load;
        }
        // Xử lý sự kiện Form load
        private void Bai02_Load(object sender, EventArgs e)
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
            lblTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt", new CultureInfo("en-US"));
        }
    }
}
