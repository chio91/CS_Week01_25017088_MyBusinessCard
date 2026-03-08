namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo("https://github.com/chio91")
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.KakaoTalk_20260308_182551806;
        }
    }
}
