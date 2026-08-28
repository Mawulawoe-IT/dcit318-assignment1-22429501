using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for the user's age
            Console.Write("Enter your age: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number for age.");
                return;
            }

            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
                return;
            }

            // Determine ticket price
            int normalPrice = 10;
            int discountedPrice = 7;

            int price;
            if (age <= 12 || age >= 65)
            {
                price = discountedPrice;
            }
            else
            {
                price = normalPrice;
            }

            Console.WriteLine($"Ticket Price: GHC{price}");
        }
    }
}
