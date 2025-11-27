using System;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main(string[] args)
    {
        // Object with empty constructor
        Car c1 = new Car();
        Console.WriteLine("Default car:");
        Console.WriteLine(c1.ToString());
        Console.WriteLine();

        // Object with parameterized constructor
        Car c2 = new Car("Toyota", 2018);
        Console.WriteLine("Custom car:");
        Console.WriteLine(c2.ToString());
        Console.WriteLine("Car age: " + c2.GetCarAge());
        Console.WriteLine();

        // Updating values using properties
        c1.Brand = "BMW";
        c1.Year = 2020;

        Console.WriteLine("Updated first car:");
        Console.WriteLine(c1.ToString());
        Console.WriteLine("Car age: " + c1.GetCarAge());
    }
}
