﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bread is ready.\nWho is the bread for?");
        string name = Console.ReadLine();
        Console.WriteLine($"Noted: {name} got bread.");
    }
}