

using System;

namespace Szyfr_AtBash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter letter:");
            int letter = Console.Read();
            Console.WriteLine("(ASCII) code : " + letter);
            letter = 97 + (25 - letter + 97) % 26;
            char letternew = (char)letter;
            Console.WriteLine("Chacked: " + letternew);
            Console.ReadKey();
        }
    }
}
