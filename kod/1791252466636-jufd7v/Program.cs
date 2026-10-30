using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace zadatak_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ucenici = { "Ana", "Marko", "Jovana", "Petar", "Milica" };
            //pravim niz sa stringovima
            StreamWriter fajl = new StreamWriter("ucenici.txt");
            //za svaki string promenljivu ime koje citas iz niza ucenici
            foreach (string ime in ucenici)
            {
                //upisi taj string u fajl
                fajl.WriteLine(ime);
            }
            fajl.Close();
            Console.WriteLine("Unesi jos jednog ucenika : ");
            string s = Console.ReadLine();
            StreamWriter dodaj = new StreamWriter("ucenici.txt", true);
            dodaj.WriteLine(s);
            dodaj.Close();
            Console.WriteLine("Imena ucenika su upisana u datoteku ucenici.txt");
            Console.ReadKey();
        }
    }
}
