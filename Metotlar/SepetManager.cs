using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {   //naming convention
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklnedi : " + urun.Adi );

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklnedi : " + urunAdi);
        }
    }
}
