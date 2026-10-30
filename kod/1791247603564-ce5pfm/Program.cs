using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    internal class Program
    {
        static int brojac = 0;

        static void Pozovi()
        {
            brojac++;
            Console.WriteLine("Funkcija je pozvana " + brojac + " puta");
        }

        static void Main(string[] args)
        {
            Pozovi();
            Pozovi();
            Pozovi();
            Console.ReadKey();
        }
    }
}
