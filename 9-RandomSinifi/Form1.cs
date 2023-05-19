namespace _9_RandomSinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int Sayi1 = rand.Next(1, 10);
            int Sayi2 = rand.Next(1, 10);
            int Sayi3 = rand.Next(1, 10);
            int Sayi4 = rand.Next(1, 10);
            int Sayi5 = rand.Next(1, 10);


            label1.Text = Sayi1.ToString();
            label2.Text = Sayi2.ToString();
            label3.Text = Sayi3.ToString();
            label4.Text = Sayi4.ToString();
            label5.Text = Sayi5.ToString();


            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (textBox5.Text == label5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }





        }
    }
}