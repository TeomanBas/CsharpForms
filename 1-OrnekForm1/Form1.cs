namespace OrnekForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // butona t�kland���nda bir mesaj kutusu a��l�r ve show i�erisine tan�mlanan mesaj yazd�r�l�r
            MessageBox.Show("merhaba d�nya");
            // butona t�kland���nda label1 objesinin i�indeki text �zelli�inin de�eri de�i�tirilir.
            label1.Text = "butona t�klad�n�z.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // textbox i�erisine girilen string ifadeyi label1 i�erisine atar.
            var yeni_deger = textBox1.Text;
            label1.Text = yeni_deger;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // t�kland���nda combobox i�erisine item ekler 
            comboBox1.Items.Add(textBox2.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(" ad�n�z : " + textBox3.Text + " " + " Soyad�n�z " + textBox4.Text);
        }
    }
}