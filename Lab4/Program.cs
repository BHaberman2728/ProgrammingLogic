using System.Diagnostics.CodeAnalysis;

namespace Lab4;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Problem 1: Add a Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Add a Method with Parameters
    public void Drive(int a)
    {
        Console.WriteLine($"The car drove {a} miles.");
    }

    // Problem 3: Add a Method with a Return Value
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    // Problem 4: Add a Method that Updates a Field
    public void Repaint(string newColor)
    {
        string color = newColor;
        Console.WriteLine("The car has been repainted to " + color + ".");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method

        myCar.Start(); // Calling the Start method (Problem 1)

        myCar.Drive(50); // Calling the Drive method (Problem 2)

        Console.WriteLine(myCar.GetDescription()); // Calling the Description method (Problem 3)

        myCar.Repaint("red"); // Calling the Repaint method (Problem 4)
    }
}
