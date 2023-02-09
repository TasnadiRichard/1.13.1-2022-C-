static void Main(string[] args)
{
    Console.WriteLine("A viz halmazallapotanak vizsgalata:");
    Console.Write("Homerseklet: ");

    double t = Convert.ToDouble(Console.ReadLine());

    if (t > 0)
    {
        if (t >= 100) Console.WriteLine("Goz!");
        else Console.WriteLine("Viz!");
    }
    else Console.WriteLine("Jeg!");

    Console.ReadLine();
}
