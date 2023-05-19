namespace _6_MetodOrnegi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj();
        }
        // metodlar private olduðu zaman sadece bu form öðesinden eriþebiliriz 
        // void deðer döndürmeyecekse yazýlmalýdýr
        private void mesaj()
        {
            textBox1.Text = "sizin mesajýnýz";
        }
        private void temizle()
        {
            textBox1.Text = "";
        }
        private int topla(int x, int y)
        {
            int toplam = x + y;
            return toplam;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox2.Text);
            int y = Convert.ToInt16(textBox3.Text);
            label5.Text = Convert.ToString(topla(x, y));
        }
    }
}