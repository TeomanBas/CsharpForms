namespace _5_TimerUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //program a��l�r a��lmaz timer ba�lar
            //timer.start();
        }

        int sayac = 0;
        int saat = 0; int dakika = 0; int saniye = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            // buras� timer fonksiyonu her d�nd���nde ger�ekle�ecek i�lemlerin bulundu�u yerdir 
            // timer interval de�eri milisaniye cinsinden dir 1000 ms bir saniye oldu�undan interval
            // de�eri 1000 oldu�undan buradaki kodlar bir kere �al���r 
            // timer bu �ekilde �al��maktad�r.
            sayac++;
            if (sayac == 1)
            {
                saniye++;
                progressBar1.Value++;
                label3.Text = Convert.ToString(saniye);
                sayac = 0;
                

            }
            if (saniye == 60)
            {
                dakika++;
                label2.Text = Convert.ToString(dakika);
                sayac = 0;
                saniye = 0;
                progressBar1.Value=0;
                label6.BackColor = Color.FromArgb(255, 0, 0);
                

            }
            if (dakika == 60)
            {
                saat++;
                label1.Text = Convert.ToString(saat);
                sayac = 0;
                saniye = 0;
                dakika = 0;
                label5.BackColor = Color.FromArgb(255, 170, 0);
                label4.BackColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("zaman doldu");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            

        }


    }
}