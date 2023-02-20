using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dinnyek
{
    class labda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dinnyek atmeroje(cm):!");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dinnyek szama!");
            int n = int.Parse(Console.ReadLine());
            double szalag = ((2 * d * Math.PI) + 60) * n;
            Console.WriteLine();
            Console.WriteLine("A szükséges szalag {0:0.00} cm.", szalag);
            Console.ReadLine();
        }
    }
}
