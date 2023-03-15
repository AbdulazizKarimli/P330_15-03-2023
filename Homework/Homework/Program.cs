using Core.Entities;

bool check = true;
while (check)
{
    Console.WriteLine("1. Square\n2. Rectangular\n0. Quit");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Side:");
            int side = int.Parse(Console.ReadLine());

            Square square = new(side);
            Console.WriteLine(square.CalcArea());
            break;
        case 2:
            Console.WriteLine("Width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Length:");
            int length = int.Parse(Console.ReadLine());

            Rectangular rectangular = new(width, length);
            Console.WriteLine(rectangular.CalcArea());
            break;
        case 0:
            check = false;
            Console.WriteLine("Sonlandi.");
            break;
        default:
            Console.WriteLine("Bele bir emeliyyat yoxdur.");
            break;
    }
}