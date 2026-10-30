using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace zadatak_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Unesi broj koji se dodaje u fajl: ");
            int y = Convert.ToInt32(Console.ReadLine());

            StreamWriter dodaj = new StreamWriter("brojevi.txt", true);
            //true znaci da se upisuje na kraj fajla, postojeci brojevi ostaju
            dodaj.WriteLine(y);
            dodaj.Close();

            StreamReader citaj = new StreamReader("brojevi.txt");
            while ((s = citaj.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            citaj.Close();
            Console.ReadKey();
        }
    }
}
