namespace _7_ClassKavramiUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Evim ev1 = new Evim();
            ev1.renk = "kýrmýzý";
            ev1.kat = 1;
            ev1.odasayisi = 5;
            ev1.fiyat = 1000.125;
            ev1.durum = 2;
            ev1.m2 = 1500;
            ev1.YAS = -2023;
            ev1.TIPI = "kýþlýk";
            ev1.Notunuz = "ev1 hakkýnda notlar";


            label1.Text = ev1.renk;
            label2.Text = Convert.ToString(ev1.kat);
            label3.Text = Convert.ToString(ev1.odasayisi);
            label4.Text = Convert.ToString(ev1.durum);
            label5.Text = Convert.ToString(ev1.fiyat);
            label6.Text = Convert.ToString(ev1.m2);
            label15.Text = Convert.ToString(ev1.TIPI);
            label16.Text = Convert.ToString(ev1.YAS);
            label18.Text = ev1.Notunuz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formlar arasý geçiþ 
            Form2 evf2 = new Form2();
            evf2.Show();
            this.Hide();
        }
    }
}