using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Nizes";
            musteri1.Soyad = "Lore";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Sezin";
            musteri2.Soyad = "Erol";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };

            for (int i = 0; i <musteriler.Length ; i++)
            {

                MusteriManager musteriManager = new MusteriManager();
                musteriManager.Add(musteriler[i]);
                musteriManager.Delete(musteriler[i]);
                musteriManager.Update(musteriler[i]);
                Console.WriteLine(".....................");
                //Console.WriteLine(musteriler[i].Id+ musteriler[i].Ad+musteriler[i].Soyad);

            }



            



            
        }
    }
}
