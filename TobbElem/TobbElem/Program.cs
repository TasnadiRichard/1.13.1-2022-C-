using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            int paros = 0;
            int paratlan = 0;
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot: ");
                int szam = int.Parse(Console.ReadLine());
                osszeg = osszeg + szam;
                if (szam % 2 == 0) paros++;
                if (szam % 2 != 0) paratlan++;
                if (osszeg >= 100) break;
            }
            Console.WriteLine("{0} páros és {1} páratlan,", paros, paratlan);
            Console.ReadLine();
        }
    }
}
