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
            // butona tıklandığında bir mesaj kutusu açılır ve show içerisine tanımlanan mesaj yazdırılır
            MessageBox.Show("merhaba dünya");
            // butona tıklandığında label1 objesinin içindeki text özelliğinin değeri değiştirilir.
            label1.Text = "butona tıkladınız.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // textbox içerisine girilen string ifadeyi label1 içerisine atar.
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
            // tıklandığında combobox içerisine item ekler 
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
            listBox1.Items.Add(" adınız : " + textBox3.Text + " " + " Soyadınız " + textBox4.Text);
        }
    }
}