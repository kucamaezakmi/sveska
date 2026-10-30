using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_18
{
    internal class Program
    {
        static int Mnozi(int x, int y)
        {
            return x * y;
        }

        static void Parnost(int z)
        {
            if (z % 2 == 0) Console.WriteLine("Broj je paran!");
            else Console.WriteLine("Broj je neparan!");
        }

        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int rezultat = Mnozi(a, b);
            Console.WriteLine("Mnozenjem dobijam : " + rezultat);
            Parnost(rezultat);
            Console.ReadKey();
        }
    }
}
