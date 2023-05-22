using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int mag;
            int szorzo;
            int hozam;

            Console.Write("Búza mennyisége tonnában: ");
            mag = int.Parse(Console.ReadLine());
            szorzo = rnd.Next(5,16);
            hozam = mag * szorzo;

            Console.WriteLine("A várható mennyiség {0}.", hozam);

            if (szorzo >= 5 && szorzo <= 8)
                Console.WriteLine("Átlag alatti év várható.");
            else if (szorzo >= 9 && szorzo <= 12)
                Console.WriteLine("Átlagos év várható.");
            else if (szorzo >= 13 && szorzo <= 15)
                Console.WriteLine(" Átlag feletti év várható. ");
             Console.ReadLine();

        }
    }
}
