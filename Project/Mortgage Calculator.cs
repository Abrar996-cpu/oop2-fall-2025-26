using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Mortgage Calculator (Bangladesh) ===\n");

        
        Console.Write("Enter loan amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

       
        double r = annualRate / 100 / 12;  
        int n = years * 12;                 

        
        double M;
        if (r == 0)
        {
            M = principal / n;  
        }
        else
        {
            M = principal * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1);
        }

       
        double totalPaid = M * n;
        double totalInterest = totalPaid - principal;

       
        Console.WriteLine();
        Console.WriteLine($"Monthly Payment: {M:N2}৳");
        Console.WriteLine($"Total Paid: {totalPaid:N2}৳");
        Console.WriteLine($"Total Interest: {totalInterest:N2}৳");
    }
}

