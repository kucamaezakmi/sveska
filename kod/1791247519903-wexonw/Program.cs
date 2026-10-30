using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Unesite drugi broj:");
            int b = Convert.ToInt32(Console.ReadLine());

            bool prviJeVeci = a > b;
            bool drugiJeVeci = b > a;
            bool Jednaki = a == b;

            if( prviJeVeci )
                Console.WriteLine("Prvi broj je veci od drugog:" + prviJeVeci);
            if (drugiJeVeci)
                Console.WriteLine("Drugi broj je veci od prvog:" + drugiJeVeci);
            if (Jednaki)
                Console.WriteLine("Brojevi su jednaki:" + Jednaki);
            Console.ReadKey();
        }
    }
}
