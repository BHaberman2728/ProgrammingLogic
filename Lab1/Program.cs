using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Lab1;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        // Step 1
        /* Name: Brianna Haberman
        Course Title: IT-1050 - Lab 1 */

        // Step 2
        Console.WriteLine("Name: Brianna Haberman");
        Console.WriteLine("Course Title: IT-1050 - Lab 1");

        // Step 3 
        int myFavNum = 8;
        string myFavLang = "JavaScript";
        double myProg = 2D;
        bool myExp = true;

        Console.WriteLine("My favorite number is " + myFavNum + ".");
        Console.WriteLine("My favorite programming language is " + myFavLang + ".");
        Console.WriteLine("I have written " + myProg + " programs before this Lab.");
        Console.WriteLine("It is " + myExp + " that I have experience programming.");

        // Step 4
        const string schoolName = "Cleveland State University";
        Console.WriteLine(schoolName);

        // Step 5
        double myDouble = 9.78D;
        int myInt = (int)myDouble;
        int newInt = 250;
        bool newBool = false;

        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("int: " + myInt);
        Console.WriteLine("int to string: " + Convert.ToString(newInt));
        Console.WriteLine("bool to string: " + Convert.ToString(newBool));

        // Step 6
        Console.WriteLine("Please type your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your age is: " + age);

        // Step 7
        int num1 = 5, num2 = 12;
        int addTen = num1 + 10;
        Console.WriteLine("5 + 10 = " + addTen);

        int subTwo = num2 - 2;
        Console.WriteLine("12 - 2 = " + subTwo);

        int timesThree = num2 * 3;
        Console.WriteLine("12 x 3 = " + timesThree);

        int divTwo = num2 / 2;
        Console.WriteLine("12 / 2 = " + divTwo);

        int modTwo = (num1 + num2) % 2;
        Console.WriteLine("The remainder of (5 + 12) / 2 is " + modTwo);

        // Step 8
        float myFloat = 1.123456789;
        double myDouble = 1.123456789;

        Console.WriteLine("Decimal stored as a float: " + myFloat);
        Console.WriteLine("Decimal stored as a double: " + myDouble);

        // Step 9
        int aVar = 10;
        Console.WriteLine("10 + 1 = " + aVar++);
        Console.WriteLine("10 - 1 = " + aVar--);

    }
   
}
