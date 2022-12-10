internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What kind of thing are we talking about?");
        /*
         * This comment describes the variable below which is a string that
         * stores the string input by the user
         */
        string a = Console.ReadLine();
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        //another variable holding another string put in by the user
        string b = Console.ReadLine();
        //hardoded string being stored
        string c = "Doom";
        //hardcoded string being stored
        string d = "3000";
        Console.WriteLine($"The {b} {a} of {c} {d}!");
    }
}