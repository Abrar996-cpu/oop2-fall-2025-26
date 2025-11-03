using System;
class Program
{
    static void Main()
    {
        bool continueCalculation = true;
        do
        {
            
            Console.WriteLine("Select calculation method:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            
            Console.Write("Enter your choice (1-4): ");
            string method = Console.ReadLine();
           
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
           
            double result = 0;
            switch (method)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "4":
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid calculation method!");
                    break;
            }
           
            Console.Write("Do you want to perform another calculation? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                continueCalculation = false;
            }
        } while (continueCalculation);
    }
}