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

        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child Ticket: $5.00");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard Ticket: $10.00");
        }
        else if (age >= 65)
        {
            Console.WriteLine("Senior Ticket: $6.00");
        }

        // Part 4: Using a Switch Statement

        Console.WriteLine("Please enter a day of the week using numbers 1-7: ");
        int dayofweek = Convert.ToInt32(Console.ReadLine());

        switch (dayofweek)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}
