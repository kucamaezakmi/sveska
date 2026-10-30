using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = { 4, 8, 15, 16, 23 };

            int zbir = 0;
            int max = niz[0];
            for (int i = 0; i < niz.Length; i++)
            {
                zbir += niz[i];
                if (niz[i] > max) max = niz[i];
            }

            Console.WriteLine("Zbir svih clanova niza je: " + zbir);
            Console.WriteLine("Maksimalna vrednost u nizu je: " + max);
            Console.ReadKey();
        }
    }
}
