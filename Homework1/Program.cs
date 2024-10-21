using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Welcome to the C# Console Application!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Data Types Display");
                Console.WriteLine("2. Basic Math Operations");
                Console.WriteLine("3. Conditional Statements");
                Console.WriteLine("4. Loop Demonstrations");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DataTypes.Display();
                        break;
                    case 2:
                        BasicMath.PerformOperations();
                        break;
                    case 3:
                        ConditionalStatements.CheckNumber();
                        break;
                    case 4:
                        Loops.DemonstrateLoops();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the application! Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine(); // Blank line for better readability
            } while (choice != 5);
        }
    }
}
