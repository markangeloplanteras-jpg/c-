
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        Console.Write("What is your name? ");
        string name = Console.ReadLine() ?? "Guest";

        Console.WriteLine($"Welcome, {name}!");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
