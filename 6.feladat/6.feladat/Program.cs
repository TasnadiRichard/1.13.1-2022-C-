static void Main(string[] args)
{
    Console.Write("Elso pont x kordinátája:");
    int x1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Elso pont y kordinátája:");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Második pont x kordinátája:");
    int x2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Második pont y kordinátája:");
    int y2 = Convert.ToInt32(Console.ReadLine());

    double tavolsag =
    Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1));

    Console.Write("Távolság: {0}", tavolsag);

    Console.ReadLine();
}