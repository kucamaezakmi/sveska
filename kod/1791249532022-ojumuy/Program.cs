using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_16
{
    internal class Program
    {
        static void Podeli(int x, int y, out int z1, out int z2)
        {
            z1 = x / y;
            z2 = x % y;
        }

        static void Main(string[] args)
        {
            int b1 = 11, b2 = 5;
            int rezkol, rezost;
            Podeli(b1, b2, out rezkol, out rezost);
            Console.Write("Delim " + b1 + " sa " + b2 + " kolicnik je " + rezkol);
            Console.WriteLine(" a ostatak je " + rezost);
            Console.ReadKey();
        }
    }
}
