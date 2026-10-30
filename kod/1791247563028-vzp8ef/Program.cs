using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 10;
            if (broj > 0)
            {
                string poruka = "Broj je pozitivan";
                Console.WriteLine(poruka);
            }
            //Console.WriteLine(poruka);
            //GRESKA! Promenljiva "poruka" postoji samo unutar if bloka
            for(int i = 1;  i <= 3; i++)
            {
                int kvadrat = i * i;
                Console.WriteLine(" Kvadrat broja: " + i + " je " + kvadrat);
            }
        }
    }
}
