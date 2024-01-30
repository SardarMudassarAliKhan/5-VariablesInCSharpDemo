using System;

class Program
{
    static void Main()
    {
        // Declare variables
        int age;
        double height;
        string name;

        // Assign values to variables
        age = 30;
        height = 5.8;
        name = "John Doe";

        // Print variables to the console
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height + " feet");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
