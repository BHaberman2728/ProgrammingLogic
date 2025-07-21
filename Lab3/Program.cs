namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple For Loop

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)

        for (int i = 1; i <= 20; i++)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Problem 3: While Loop Countdown

        int num = 5;
        while (num >= 1)
        {
            Console.WriteLine(num);
            --num;
        }

        // Problem 4: While Loop – Multiples of 10 from 10 to 1000

        int count = 10;
        while (count <= 1000)
        {
            Console.WriteLine(count);
            count *= 10;
        }

        // Problem 5: Seasons of the Year

        string[] seasons = new string[4];
        seasons[0] = "Fall";
        seasons[1] = "Winter";
        seasons[2] = "Spring";
        seasons[3] = "Summer";

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(seasons[i]);
        }

        // Problem 6: Days of the Week (1–7)

        string[] daysofweek = new string[7];
        daysofweek[0] = "Monday";
        daysofweek[1] = "Tuesday";
        daysofweek[2] = "Wednesday";
        daysofweek[3] = "Thursday";
        daysofweek[4] = "Friday";
        daysofweek[5] = "Saturday";
        daysofweek[6] = "Sunday";

        Console.WriteLine("Please enter a number 1-7: ");
        
    }   
}
