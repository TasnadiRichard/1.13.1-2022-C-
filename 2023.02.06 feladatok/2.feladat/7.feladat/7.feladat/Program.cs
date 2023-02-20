using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace I_1_pelda
{
    class I_1_pelda
    {
        static void Main(string[] args)
        {
            int osztalyzat;
            Console.Write("Kérem az elért pontszámot: ");
            int pont = int.Parse(Console.ReadLine());

            if (pont >= 0 && pont < 50) osztalyzat = 1;
            else if (pont >= 50 && pont < 65) osztalyzat = 2;
            else if (pont >= 65 && pont < 80) osztalyzat = 3;
            else if (pont >= 80 && pont < 90) osztalyzat = 4;
            else if (pont >= 90 && pont <= 100) osztalyzat = 5;
            else osztalyzat = 0;

            if (osztalyzat > 0)
                Console.WriteLine("A kapott érdemjegy: {0}.", osztalyzat);
            else Console.WriteLine("Hibás az adat!");

            Console.ReadLine();
        }
    }
}
