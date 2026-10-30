using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_13
{
    internal class Program
    {
        struct tacka
        {
            public int x, y;
            public double udaljenost;
        }

        static void Main(string[] args)
        {
            Random broj = new Random();
            tacka[] niz = new tacka[10];
            for (int i = 0; i < 10; i++)
            {
                niz[i].x = broj.Next() % 100;
                niz[i].y = broj.Next() % 100;
                double z = Math.Sqrt(niz[i].x * niz[i].x + niz[i].y * niz[i].y);
                niz[i].udaljenost = z;
                Console.WriteLine("X koordinata " + i + ". tacke je: " + niz[i].x);
                Console.WriteLine("Y koordinata " + i + ". tacke je: " + niz[i].y);
                Console.WriteLine("Udaljenost " + i + ". tacke je: " + niz[i].udaljenost);
            }

            // najbliza tacka je ona sa najmanjom udaljenoscu od (0, 0)
            int najbliza = 0;
            for (int i = 1; i < 10; i++)
            {
                if (niz[i].udaljenost < niz[najbliza].udaljenost) najbliza = i;
            }
            Console.WriteLine("Najbliza tacka nuli je " + najbliza + ". tacka (" + niz[najbliza].x + ", " + niz[najbliza].y + ")");
            Console.ReadKey();
        }
    }
}
