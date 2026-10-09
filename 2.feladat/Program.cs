using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 10; i < 30; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}

            for (int i = 0; i <= 30; i=i+2)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
