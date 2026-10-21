using System;

class Program
{
    static void Main()
    {
        int primeira = 10;
        int segunda = primeira;

        segunda = 20;

        Console.WriteLine("Primeira variável: " + primeira);
        Console.WriteLine("Segunda variável: " + segunda);
    }
}
