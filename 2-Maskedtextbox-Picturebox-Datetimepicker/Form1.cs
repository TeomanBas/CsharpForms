namespace Maskedtextbox_Picturebox_Datetimepicker
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("telefon :" + MskTel.Text + "\\"+
                "tc kimlik no :"+MskTc.Text + "\\" +
                "tarih :" + MskTarih.Text + "\\" +
                "saat :" + MskSaat.Text + "\\" +
                "zaman : " + dtpTarih.Text);
        }
    }
}