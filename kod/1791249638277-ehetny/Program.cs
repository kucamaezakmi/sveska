using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_17
{
    internal class Program
    {
        static int Saberi(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int a = 3, b = 8;
            int rezultat;
            rezultat = Saberi(a, b);
            Console.Write("Rezultat sabiranja " + a + " + " + b);
            Console.WriteLine(" je " + rezultat);
            Console.ReadKey();
        }
    }
}
