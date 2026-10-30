using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[10];
            Random x = new Random();
            for (int i = 0; i < 10; i++)
            {
                niz[i] = x.Next() % 100;
            }
            foreach (int broj in niz)
            {
                Console.WriteLine(broj);
            }
            Console.ReadKey();
        }
    }
}
