namespace Checkbox_Radiobutton_Richtexbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // groupbox bir kutu i�erisindeki eklenen nesnelerin bir grup gibi kullan�lmas�n� ve g�r�nmesini sa�lar
            // i�erisine eklenne checkbox lar i�aretli ise true de�ilse false de�er d�nd�r�rler.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // paneller  genelde tasar�m i�in s�ks�k kullan�l�r
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // richtexbox �n text yazmak i�in kullan�l�r normal textboxdan fark� alt sat�rlara ge�ilebilmeisidir
            // textbox lardan tek sat�rda yaz�m yap�l�r ancak richtexbox da alt sat�ra inilerek birden �ok sat�rda 
            // yaz�m yap�labilir
        }
    }
}