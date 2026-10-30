using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace zadatak_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fajl = new StreamWriter("poruka.txt");
            //ovde sam definisao koji fajl otvaram
            //ako fajl ne postoji napravi
            //ako fajl postoji on se prebrise novim
            fajl.WriteLine("Zdravo iz C# programa!");
            fajl.WriteLine("Ovo je druga linija teksta.");
            fajl.WriteLine("Ovo je treca linija teksta.");

            fajl.Close();
            //fajl na kraju mora UVEK da se zatvori
            Console.WriteLine("Podaci su uspesno upisani u datoteku poruka.txt");
            Console.ReadKey();
        }
    }
}
