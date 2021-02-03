using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {   //Engin Demiroğ
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; Gerçek kişinin böyle bir özelliği yok
            //Gerçek (individual) Musteri-Tüzel (Coorporate-legal entity) Musteri olmak üzere 2 nesne var,sırf birbirlerine benziyor diye birbirinin yerine kullanılamazlar.
            //Farklı musteri tipleridirler.SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);



        }
    }
}
