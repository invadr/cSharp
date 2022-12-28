namespace fourSistersAndTheDuckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chocolate eggs were gathered today?");
            string eggs = Console.ReadLine();
            int eggsInt = Convert.ToInt32(eggs);

            int allotment = eggsInt / 4;
            int leftover = eggsInt % 4;

            Console.WriteLine($"The four sisters get {allotment} eggs each. And Duckbear gets {leftover} eggs.");


        }
    }
}