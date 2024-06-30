namespace zar_cevir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            button1.Enabled = true;
        }
        int sayac = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int zar1, zar2;
            zar1 = random.Next(0, 6);
            zar2 = random.Next(0, 6);
            pictureBox1.Image = ýmageList1.Images[zar1];
            pictureBox2.Image = ýmageList1.Images[zar2];
            sayac++;
            if (sayac == 30)
            {
                timer1.Stop();
                sayac = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
