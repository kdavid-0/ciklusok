using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alsó határ: ");
            int also = int.Parse(Console.ReadLine());

            Console.Write("Felső határ: ");
            int felso = int.Parse(Console.ReadLine());

            int csere = also;
            if (also > felso)
            {
                also = csere;
                felso = also;
            }


            for (int i = also; i <= felso; i = i + 2)
            {
                if (i%2==0)
                {
                    Console.Write($"{i} ");
                }
                
            }

            Console.ReadKey();
        }
    }
}
