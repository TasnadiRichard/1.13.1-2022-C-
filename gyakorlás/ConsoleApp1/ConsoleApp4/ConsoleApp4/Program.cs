using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal

{
    internal class Program
    {
        enum Animal {Dog = 2, Cat = 3, Tiger = 4, Wolf = 5};      
        static void Main(string[] args)
        {
            Animal a =Animal.Wolf;
            Animal b = Animal.Dog;
            Animal c = Animal.Cat;
            Animal d = Animal.Tiger;

            if (a != b)
            {
                Console.WriteLine("A farkas nem kutya");
            }
            Console.WriteLine("A macska Indexe: {0}", (int)Animal.Cat);
            Console.WriteLine("A kutya Indexe: {0}", (int)Animal.Dog);
            Console.WriteLine("A tigris Indexe: {0}", (int)Animal.Tiger);
            Console.ReadKey();


        }
}
