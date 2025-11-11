using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        Console.WriteLine("=== Mortgage Calculator (Bangladesh) ===\n");

        Console.WriteLine("You can type 'exit' anytime to close the program.\n");

        
        double salary = ReadDouble("Enter your monthly salary: ");
        int creditScore = ReadInt("Enter your credit score (0 - 500): ");
        bool criminalRecord = ReadBool("Do you have any criminal record? (true/false): ");
        double loanAmount = ReadDouble("Enter loan amount: ");

        
        double annualRate = 10; 
        int years = 3;          

        double monthlyRate = annualRate / 100 / 12;
        int months = years * 12;

        
        double monthlyPayment = (loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, months))
                               / (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - loanAmount;

       
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        
        Console.WriteLine("\n=== Mortgage Summary ===");
        Console.WriteLine($"Monthly Salary: {salary.ToString("C", bdCulture)}");
        Console.WriteLine($"Credit Score: {creditScore}");
        Console.WriteLine($"Criminal Record: {criminalRecord}");
        Console.WriteLine($"Loan Amount: {loanAmount.ToString("C", bdCulture)}");
        Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Payment: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }

    
    static double ReadDouble(string text)
    {
        while (true)
        {
            Console.Write(text);
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit") Environment.Exit(0);

            if (double.TryParse(input, out double value) && value > 0)
                return value;

            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static int ReadInt(string text)
    {
        while (true)
        {
            Console.Write(text);
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit") Environment.Exit(0);

            if (int.TryParse(input, out int value) && value >= 0)
                return value;

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static bool ReadBool(string text)
    {
        while (true)
        {
            Console.Write(text);
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "exit") Environment.Exit(0);

            if (input == "true")
                return true;
            else if (input == "false")
                return false;
            else
                Console.WriteLine("Invalid input. Please type 'true' or 'false'.");
        }
    }
}
