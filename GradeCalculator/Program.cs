using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a numeric grade between 0 and 100
            Console.Write("Enter your grade (0-100): ");
            string? input = Console.ReadLine();

            // Try to parse input to an integer
            if (!int.TryParse(input, out int grade))
            {
                Console.WriteLine("Invalid input. Please enter a whole number between 0 and 100.");
                return;
            }

            // Validate range
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            // Determine letter grade using if / else if / else
            string letter;
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Display result
            Console.WriteLine($"Grade: {letter}");
        }
    }
}
