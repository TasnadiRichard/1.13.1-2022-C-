using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIO
{
    internal class Program
    {
        #region Egész fájl olvasása
        private static void fileReadFull(StreamReader sp)
        {
            using (StreamReader sr = sp)
            {
                // Dolgozunk a fájllal
                // Egészet kiolvassa
                Console.WriteLine("Egyszerre olvassa a fájlt");
                string s = sr.ReadToEnd();
                Console.WriteLine(s);

                Console.WriteLine();    // Emelünk egy üres sort
            }
        }
        #endregion Egész fájl olvasása

        static void Main(string[] args)
        {
            FileInpOut f = new FileInpOut();

            fileReadFull(f.getFile());

            fileReadLine(f.getFile());

            f.closeFile();

            Console.ReadKey();
        }

        #region Soronkénti olvasás
        private static void fileReadLine(StreamReader streamReader)
        {
            using (StreamReader sr = streamReader)
            {
                // Dolgozunk a fájllal
                Console.WriteLine("Soronként olvassa a fájlt");
                // Soronként olvas
                while (!sr.EndOfStream) // s != null
                {
                    string s = sr.ReadLine();
                    Console.WriteLine(s);
                }

            }
        }
        #endregion Soronkénti olvasás

    }
}