using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace zadatak_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int max = 0;
            StreamWriter fajl = new StreamWriter("brojevi.txt");
            Random x = new Random();
            for (int i = 0; i < 15; i++)
            {
                int z = x.Next() % 100;
                fajl.WriteLine(z);
            }
            fajl.Close();

            StreamReader citaj = new StreamReader("brojevi.txt");
            while ((s = citaj.ReadLine()) != null)
            {
                int z = Convert.ToInt32(s);
                if (z > max) max = z;
                Console.WriteLine(s);
            }
            citaj.Close();
            Console.WriteLine("Najveci je: " + max);
            Console.ReadKey();
        }
    }
}
