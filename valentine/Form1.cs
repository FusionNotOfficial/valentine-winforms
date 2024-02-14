using System.Runtime.InteropServices;

namespace valentine
{
    public partial class ValentineDay : Form
    {
        private int x = 0;
        private int y = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public ValentineDay()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(@"..\bg.png");
            gifImage.Image = Image.FromFile(@"..\default.gif");
        }

        private void noButton_MouseEnter(object sender, EventArgs e)
        {
            var random = new Random();
            x = random.Next(150, 3000);
            y = random.Next(100, 1300);

            buttonTimer.Start();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Урааа, спасибо!";
            gifImage.Image = Image.FromFile(@"..\yes.gif");
            yesBtn.Visible = false;
            noBtn.Visible = false;
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            while(noBtn.Location.X != x && noBtn.Location.Y != y)
            {
                noBtn.Location = noBtn.Location.X < x ? new Point(noBtn.Location.X + 1, noBtn.Location.Y) : new Point(noBtn.Location.X - 1, noBtn.Location.Y);
                noBtn.Location = noBtn.Location.Y < y ? new Point(noBtn.Location.X, noBtn.Location.Y + 1) : new Point(noBtn.Location.X, noBtn.Location.Y - 1);
            }       
            buttonTimer.Stop();
        }
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
