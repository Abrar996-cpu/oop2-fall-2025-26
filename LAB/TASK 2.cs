using System;

class Program
{
    static void Main()
    {
        double price = 250;           
        double discountRate = 15;     

       
        double discount = (price * discountRate) / 100;

        
        double finalPrice = price - discount;

        
        Console.WriteLine("Original Price: $" + price);
        Console.WriteLine("Discount: " + discountRate + "%");
        Console.WriteLine("Final Price after discount: $" + finalPrice);
    }
}