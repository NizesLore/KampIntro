using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangış için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C#";

            string [] kurslar = new string [] {"Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangış için temel kurs","Java","C#"};

                   
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar [i]);
            }
            Console.WriteLine("for bitti);

            foreach (kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("Sayfa sonu-footer");
        }
    }

}        



