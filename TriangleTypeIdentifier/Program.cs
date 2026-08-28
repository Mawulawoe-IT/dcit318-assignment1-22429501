using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Helper to read a side length
            double ReadSide(string prompt)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (!double.TryParse(input, out double value))
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                    return double.NaN;
                }
                return value;
            }

            double side1 = ReadSide("Enter the first side: ");
            if (double.IsNaN(side1)) return;
            double side2 = ReadSide("Enter the second side: ");
            if (double.IsNaN(side2)) return;
            double side3 = ReadSide("Enter the third side: ");
            if (double.IsNaN(side3)) return;

            // Basic validation: sides must be greater than 0
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("All sides must be greater than 0.");
                return;
            }

            // Triangle inequality validation
            if (!(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1))
            {
                Console.WriteLine("The values do not form a valid triangle.");
                return;
            }

            // Determine the triangle type
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Triangle Type: Equilateral");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Triangle Type: Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle Type: Scalene");
            }
        }
    }
}
