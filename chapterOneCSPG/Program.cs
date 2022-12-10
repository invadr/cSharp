internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is my first C# app!");


        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();

        Console.WriteLine($"Hi there, {name}! It's great to meet you!");
    }
}