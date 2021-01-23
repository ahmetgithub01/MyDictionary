using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int,string> city = new MyDictionary<int,string>();

            city.Add(01, "Adana");
            city.Add(02, "Adıyaman");
            city.Add(31, "Hatay");
            city.Add(32, "Isparta");
            city.Add(33, "Mersin");

            foreach (var name in city.Keys)
            {
                Console.WriteLine(name);
            }
            foreach (var number in city.Values)
            {
                Console.WriteLine(number);

            }

            Console.ReadLine();

        }
    }
}
