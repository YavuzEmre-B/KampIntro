using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emre Baycan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Emre";
            musteri1.Soyadi = "Baycan";
            musteri1.TcNo = "22222222222";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);          

        }
    }
}