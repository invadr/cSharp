internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your triangle's base measurement?");
        string b = Console.ReadLine();
        double triangleBase = Convert.ToDouble(b);

        Console.WriteLine("What is your triangle's height measurement?");
        string h = Console.ReadLine();
        double triangleHeight = Convert.ToDouble(h);

        double area = triangleBase * triangleHeight / 2;
        Console.WriteLine($"Your triangle's area is {area} square inches.");

        Console.ReadKey();
    }
}