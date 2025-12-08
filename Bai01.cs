using System.Windows.Forms;

namespace BTH4_BT1
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Bai01_KeyDown;
            this.MouseDown += Bai01_MouseDown;
        }
        // Xử lý sự kiện nhấn phím 
        private void Bai01_KeyDown(object sender, KeyEventArgs e)
        {
            string message = $"Bạn vừa nhấn phím\n" + $"KeyCode: {e.KeyCode}\n" + $"KeyValue(ASCII): {e.KeyValue}\n" + $"KeyData: {e.KeyData}\n" + $"Modifiers: {e.Modifiers}";
            MessageBox.Show(message, "Thông tin nhấn phím", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Xử lý sự kiện nhấn chuột
        private void Bai01_MouseDown(object sender, MouseEventArgs e)
        {
            string button = e.Button.ToString();
            string message = $"Bạn vừa click chuột\n" + $"Nút: {button}\n" + $"Tọa độ: ({e.X}, {e.Y})";
            MessageBox.Show(message, "Thông tin click chuột", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
