
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> presidents = new MyDictionary<int, string>();

            presidents.Add(1, "Mustafa Kemal Atatürk");
            presidents.Add(2,"İsmet İnönü");
            presidents.Add(3,"Celal Bayar");
            presidents.Add(4,"Cemal Gürsel");
                      
            Console.WriteLine(presidents.Count);
        }
    }
}
