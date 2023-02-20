using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy hőmérséklet értéket: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write
                ("Válassz opciót: (1) C∘ --> K∘ (2) K∘ --> C∘ : ");
            byte c = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (c)
            {
                case 1:
                    Console.WriteLine("{0} C∘ = {1} K∘", n, n + 273);
                    break;
                case 2:
                    Console.WriteLine("{0} K∘ = {1} C∘", n, n - 273);
                    break;
            }
            Console.ReadLine();
        }
    }
}