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
            // groupbox bir kutu içerisindeki eklenen nesnelerin bir grup gibi kullanýlmasýný ve görünmesini saðlar
            // içerisine eklenne checkbox lar iþaretli ise true deðilse false deðer döndürürler.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // paneller  genelde tasarým için sýksýk kullanýlýr
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // richtexbox ýn text yazmak için kullanýlýr normal textboxdan farký alt satýrlara geçilebilmeisidir
            // textbox lardan tek satýrda yazým yapýlýr ancak richtexbox da alt satýra inilerek birden çok satýrda 
            // yazým yapýlabilir
        }
    }
}