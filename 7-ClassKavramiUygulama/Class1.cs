using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ClassKavramiUygulama
{
    // inheritance kalıtım 
    // internal class TemelOzellik : EkOzellik
    // Evim sınıfı EkOzellik içerisinde bulunan özelliklerede sahip olmuş oldu.
    internal class Evim : EkOzellik
    {
        public string renk;
        public int kat;
        public double fiyat;
        public int odasayisi;
        public int m2;
        public int durum;
        private int yas;
        private string tipi;

        //kapsülleme getter ve setter metodları
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public string TIPI
        {
            get { return tipi; }
            set { tipi = value.ToUpper(); }
        }

    }
}
