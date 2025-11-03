using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Enter score of first student: ");
        double score1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter score of second student: ");
        double score2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter score of third student: ");
        double score3 = Convert.ToDouble(Console.ReadLine());

       
        double average = (score1 + score2 + score3) / 3;

       
        Console.WriteLine("Average score = {0:F2}", average);
    }
}
