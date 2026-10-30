using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = { 4, 8, 15, 16, 23 };

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine((i + 1) + ". element niza je: " + niz[i]);
            }
            Console.ReadKey();
        }
    }
}
