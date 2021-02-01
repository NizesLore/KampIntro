using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tk,Tv>
    {
        Tk[] Key;
        Tv[] Value;

        public MyDictionary()
        {
            Key = new Tk[0];
            Value = new Tv[0];

        }

        public void Add(Tk Tkey,Tv Tvalue)
        {
            Tk[] temparraykey = Key;
            Key = new Tk[temparraykey.Length + 1];

            Tv[] temparrayvalue = Value;
            Value = new Tv[temparraykey.Length + 1];

            for (int i = 0; i < temparraykey.Length; i++)
            {
                Key[i] = temparraykey[i];
                Value[i] = temparrayvalue[i];

            }

            Key[Key.Length - 1] = Tkey;
            Value[Value.Length - 1] = Tvalue;

            //Console.WriteLine(int + Tkey + string+ Tvalue);
        }

        public int Count
        {
            get { return Key.Length; }
            
        }

    }
}
