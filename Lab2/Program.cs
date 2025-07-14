namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Operator Practice

        int a = 10, b = 5, c = 15;
        Console.WriteLine("Integers: a = 10, b = 5, and c = 15.");
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < c: " + (a < c));
        Console.WriteLine("a > b && a > c: " + (a > b && a > c));
        Console.WriteLine("a = b || b < c: " + (a == b || b < c));
        Console.WriteLine("a >= b && c > b: " + (a >= b && c > b));

        // Part 2: Boolean Logic

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umberella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Part 3: Conditional Logic
        
        

        // Part 4: Using a Switch Statement

    }
}
