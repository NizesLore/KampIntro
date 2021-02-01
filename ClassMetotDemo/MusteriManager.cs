using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +"\n "+ musteri.Ad +"\n "+ musteri.Soyad + "\n "+"  eklendi.");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +"\n"+ musteri.Ad +"\n"+ " "+musteri.Soyad +" \n"+"  silindi.");

        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +"\n "+ musteri.Ad +"\n "+ musteri.Soyad +" \n"+"  güncellendi.");
        }

    }
}
