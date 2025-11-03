using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After swapping:");
        Console.WriteLine("First number = " + a);
        Console.WriteLine("Second number = " + b);
    }
}


