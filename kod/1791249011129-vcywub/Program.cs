using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_12
{
    internal class Program
    {
        struct tacka
        {
            public int x, y;
        }

        static void Main(string[] args)
        {
            Random broj = new Random();
            tacka[] niz = new tacka[10];
            for (int i = 0; i < 10; i++)
            {
                niz[i].x = broj.Next() % 100;
                niz[i].y = broj.Next() % 100;
                Console.WriteLine("X koordinata " + i + " tacke je " + niz[i].x);
                Console.WriteLine("Y koordinata " + i + " tacke je " + niz[i].y);
            }
            Console.ReadKey();
        }
    }
}
