using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace zadatak_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            StreamReader citaj = new StreamReader("poruka.txt");
            //spremio sam fajl za citanje
            while ((s = citaj.ReadLine()) != null)
            //s je red koji je procitan iz fajla
            //petlja radi dok god je s razlicit od null-a, null predstavlja kraj fajla
            {
                Console.WriteLine(s);
            }
            citaj.Close();
            Console.WriteLine("Podaci su uspesno procitani");
            Console.ReadKey();
        }
    }
}
