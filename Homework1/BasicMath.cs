using System;

namespace Homework1
{
    public static class BasicMath
    {
        public static void PerformOperations()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {num1 / num2}");
        }
    }
}
