namespace _4_AracUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            LboxGoster.Items.Add(new string('-', 20) + " KAYIT BA�LANGI� " + new string('-', 20));
            LboxGoster.Items.Add(new string('-', 10) + " G�ZERGAH " + new string('-', 10));
            LboxGoster.Items.Add("Nereden : " + CboxNereden.Text);
            LboxGoster.Items.Add("Nereden : " + CboxNereye.Text);
            LboxGoster.Items.Add(new string('-', 10) + " ZAMAN " + new string('-', 10));
            LboxGoster.Items.Add("Tarih : " + MtboxTarih.Text);
            LboxGoster.Items.Add("Saat : " + MtboxSaat.Text);
            LboxGoster.Items.Add(new string('-', 10) + " YOLCU B�LG�LER� " + new string('-', 10));
            LboxGoster.Items.Add("Ad� Soyad� : " + TboxAdSoyad.Text);
            LboxGoster.Items.Add("T.C Kimlik Numaras� : " + MtboxTc.Text);
            LboxGoster.Items.Add("Telefon NUmaras� : " + MtboxTel.Text);
            LboxGoster.Items.Add(new string('-', 20) + " KAYIT SONU " + new string('-', 20));










        }

        private void BtnDegistir_Click(object sender, EventArgs e)
        {   // bir label olu�turup de�eri onun i�erisinde de tutabilirdik label g�r�nmemesi i�in ise visible �zelli�i false yap�labilirdi.
            // LblDegistir.Text = CboxNereden.Text;
            // CboxNereden.Text = CboxNereye.Text;
            // CboxNereye.Text = LblDegistir.Text;


            var swp = CboxNereden.Text;
            CboxNereden.Text = CboxNereye.Text;
            CboxNereye.Text = swp;

        }

        private void LblDegistir_Click(object sender, EventArgs e)
        {

        }
    }
}