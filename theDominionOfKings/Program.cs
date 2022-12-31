namespace theDominionOfKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many provinces does your kingdom have?");
            int provinces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many duchies does your kingdom have?");
            int duchies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many estates does your kingdom have?");
            int estates = Convert.ToInt32(Console.ReadLine());

            int points = (provinces * 6) + (duchies * 3) + (estates);
            Console.WriteLine($"Your kingdom has {points} total points.");
        }
    }
}