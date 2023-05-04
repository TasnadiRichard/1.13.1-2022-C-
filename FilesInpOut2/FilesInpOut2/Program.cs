using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInpOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInpOut f = new FileInpOut();
            
            {
                // Dolgozzunk a fájllal
                //Egészet kiolvassa

                Console.WriteLine("Egyserre olvassa a fájlt!");

                string s = sr.ReadToEnd();
                Console.WriteLine(s);
                Console.WriteLine(); // Emelünk egy üres sort

                Console.WriteLine("Soronként olvass a fájlt!");

                // Soronként olvas
                while (!sr.EndOfStream) // s != null
                {
                    string s2 = sr.ReadLine();
                    Console.WriteLine(s2);
                }
            }
            f.closeFile();
            using (StreamReader sr = f.getFile())
            {
                // Dolgozzunk a fájllal
                //Egészet kiolvassa

                Console.WriteLine("Soronként olvass a fájlt!");

                // Soronként olvas
                while (!sr.EndOfStream) // s != null
                {
                    string s = sr.ReadLine();
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
