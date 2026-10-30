using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_11
{
    internal class Program
    {
        struct tacka
        {
            public int x, y;
        }

        static void Main(string[] args)
        {
            tacka t;
            t.x = 3;
            t.y = 7;
            Console.WriteLine("Tacka ima koordinate (" + t.x + ", " + t.y + ")");
            Console.ReadKey();
        }
    }
}
