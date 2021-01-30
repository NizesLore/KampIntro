using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //class oluşturuyoruz ve referans alıyoruz
            
            MyList <string> isimler = new MyList<string>();
            isimler.Add("Engin");

            
            
            Console.WriteLine("Hello World!");
        }
    }
}
