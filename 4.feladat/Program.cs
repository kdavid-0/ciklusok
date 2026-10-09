using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            //string szam = Console.ReadLine();

            //Console.WriteLine($"A szám {szam.Length} jegyű");

            int szam = int.Parse(Console.ReadLine());
            int szamlal = 0;

            while (szam >= 10)
            {
                szam = szam / 10;
                szamlal++;
            }

            Console.WriteLine($"A szám {szamlal+1} jegyű");


            Console.ReadKey();
        }
    }
}
