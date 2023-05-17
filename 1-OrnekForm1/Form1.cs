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
            // butona týklandýðýnda bir mesaj kutusu açýlýr ve show içerisine tanýmlanan mesaj yazdýrýlýr
            MessageBox.Show("merhaba dünya");
            // butona týklandýðýnda label1 objesinin içindeki text özelliðinin deðeri deðiþtirilir.
            label1.Text = "butona týkladýnýz.";

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
            // týklandýðýnda combobox içerisine item ekler 
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
            listBox1.Items.Add(" adýnýz : " + textBox3.Text + " " + " Soyadýnýz " + textBox4.Text);
        }
    }
}