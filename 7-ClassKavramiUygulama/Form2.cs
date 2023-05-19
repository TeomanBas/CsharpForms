using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_ClassKavramiUygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Evim ev2 = new Evim();
            ev2.renk = "mavi";
            ev2.kat = 2;
            ev2.odasayisi = 8;
            ev2.fiyat = 1050.1395;
            ev2.durum = 3;
            ev2.m2 = 1500;
            ev2.YAS = -2029;
            ev2.TIPI = "yazlık";
            ev2.Notunuz = "ev2 hakkında notlar";

            label1.Text = ev2.renk;
            label2.Text = Convert.ToString(ev2.kat);
            label3.Text = Convert.ToString(ev2.odasayisi);
            label4.Text = Convert.ToString(ev2.durum);
            label5.Text = Convert.ToString(ev2.fiyat);
            label6.Text = Convert.ToString(ev2.m2);
            label15.Text = Convert.ToString(ev2.TIPI);
            label16.Text = Convert.ToString(ev2.YAS);
            label18.Text = ev2.Notunuz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formlar arası geçiş 
            Form1 evf1 = new Form1();
            evf1.Show();
            this.Hide();


        }
    }
}
