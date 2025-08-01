﻿namespace Lab3;

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

        string[] daysofweek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satuday", "Sunday" };

        Console.WriteLine("Please enter a number 1-7: ");

        int input = Convert.ToInt32(Console.ReadLine());

        if (input >= 1 && input <= 7)
        {
            Console.WriteLine("The day of the week is: " + daysofweek[input - 1]);
        }

        else
        {
            Console.WriteLine("Invalid input.");
        }

        // Problem 7: Favorite Books and Authors

        string[] booktitles = new string[3] { "Man's Search for Meaning", "The Hunger Games", "The Shallows" };
        string[] authors = new string[3] { "Viktor Frankl", "Suzanne Collins", "Nicholas Carr" };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(booktitles[i] + " by " + authors[i]);
        }

        // Problem 8: Temperature Tracker

        int[] intArray = new int[5] { 35, 27, 81, 72, 53 };
        Array.Sort(intArray);

        Console.WriteLine("Sorted array: ");
        foreach (int order in intArray)
        {
            Console.WriteLine(order + " ");
        }

        Console.WriteLine("The highest temperature is: " + intArray[4]);
        Console.WriteLine("The lowest temperature is: " + intArray[0]);

        // Problem 9: Reverse Countdown

        int[] fiveArray = new int[5] { 5, 4, 3, 2, 1 };

        Array.Reverse(fiveArray);

        Console.WriteLine("Reversed array: ");
        foreach (int placement in fiveArray)
        {
            Console.WriteLine(placement + " ");
        }

    }   
}
