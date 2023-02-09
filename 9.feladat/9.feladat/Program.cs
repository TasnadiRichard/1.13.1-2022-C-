using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace feladat1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kerem az elso szamot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kerem a masodik szamot: ");
            int szam2 = int.Parse(Console.ReadLine());

            Random veletlen = new Random();

            Console.WriteLine("A generalt szamok: {0}, {1}, {2}.",
               veletlen.Next(szam1, szam2),
               veletlen.Next(szam1, szam2),
               veletlen.Next(szam1, szam2));

            Console.ReadLine();
        }
    }
}