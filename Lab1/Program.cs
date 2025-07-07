using System.Reflection.Metadata.Ecma335;

namespace Lab1;

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
        




    }
}
